/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-07-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using IFramework.Modules;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace IFramework.UI
{
    public class UIModule : UpdateModule, IUIModule
    {
        public Canvas canvas { get; private set; }
        private IGroups _groups;
        private List<IPanelLoader> _loaders;
        private Dictionary<UILayer, List<UIPanel>> _panelOrders;
        private Dictionary<UILayer, RectTransform> _layers;
        private Dictionary<string, UILayerConfig> _layerSettings;
        private Queue<LoadPanelAsyncOperation> asyncLoadQueue;
        private UIItemsPool _itemPool;
        private Func<string, GameObject> loadPrefab;
        private Action<string> releaseAsset;
        private List<UIPanel> _orderHelp = new List<UIPanel>();

        protected override void Awake()
        {
            _loaders = new List<IPanelLoader>();
            _panelOrders = new Dictionary<UILayer, List<UIPanel>>();
            _layerSettings = new Dictionary<string, UILayerConfig>();
            _layers = new Dictionary<UILayer, RectTransform>();
            asyncLoadQueue = new Queue<LoadPanelAsyncOperation>();
            _itemPool = new UIItemsPool(LoadItem, SetItem, GetItem, ClearItem, RelaseAsset);
        }
        protected override void OnDispose()
        {
            if (_groups != null)
                _groups.Dispose();
            asyncLoadQueue.Clear();
            _loaders.Clear();
            _layers.Clear();
            if (canvas != null)
                GameObject.Destroy(canvas.gameObject);
            _itemPool.Clear();
        }
        protected override void OnUpdate()
        {
            CheckAsyncLoad();
        }


        private RectTransform CreateLayer(string name)
        {
            GameObject go = new GameObject(name);
            RectTransform rect = go.AddComponent<RectTransform>();
            rect.SetParent(canvas.transform);
            rect.anchorMin = Vector2.zero;
            rect.anchorMax = Vector2.one;
            rect.localPosition = Vector3.zero;
            rect.sizeDelta = Vector3.zero;
            rect.LocalIdentity();
            return rect;
        }
        private void CreateLayers()
        {
            var names = Enum.GetValues(typeof(UILayer));
            foreach (UILayer item in names)
            {
                var rect = CreateLayer(item.ToString());
                _layers.Add(item, rect);
            }
            var items = GetLayerParent(UILayer.Items);
            CanvasGroup group = items.gameObject.AddComponent<CanvasGroup>();
            group.alpha = 0f;
            group.interactable = false;
        }
        private RectTransform GetLayerParent(UILayer layer)
        {
            return _layers[layer];
        }
        private void SetOrder(UIPanel panel)
        {
            UILayer layer = GetPanelLayer(panel);
            int order = GetPanelLayerOrder(panel);
            if (!_panelOrders.ContainsKey(layer))
                _panelOrders.Add(layer, new List<UIPanel>());
            var list = _panelOrders[layer];
            _orderHelp.Clear();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                UIPanel _tmp = list[i];
                _orderHelp.Add(_tmp);
            }
            if (_orderHelp.Contains(panel)) return;
            _orderHelp.Sort((a, b) => { return GetPanelLayerOrder(a) - GetPanelLayerOrder(b); });
            int sbindex = 0;
            bool bigExist = false;
            for (int i = 0; i < _orderHelp.Count; i++)
            {
                if (GetPanelLayerOrder(_orderHelp[i]) > order)
                {
                    sbindex = _orderHelp[i].transform.GetSiblingIndex();
                    bigExist = true;
                    break;
                }
            }
            if (bigExist)
            {
                panel.transform.SetSiblingIndex(sbindex);
            }
            list.Add(panel);
        }
        private void DestroyPanel(UIPanel panel)
        {
            _panelOrders[GetPanelLayer(panel)].Remove(panel);
            GameObject.Destroy(panel.gameObject);
        }
        private UILayer GetPanelLayer(UIPanel panel)
        {
            if (_layerSettings.ContainsKey(panel.name))
            {
                return _layerSettings[panel.name].layer;
            }
            return UILayer.Common;
        }
        private int GetPanelLayerOrder(UIPanel panel)
        {
            if (_layerSettings.ContainsKey(panel.name))
            {
                return _layerSettings[panel.name].order;
            }
            return 0;
        }



        private void RelaseAsset(string obj)
        {
            releaseAsset?.Invoke(obj);
        }
        private void GetItem(GameObject obj, string name) { }
        private void SetItem(GameObject obj, string name)
        {
            var parent = GetLayerParent(UILayer.Items);
            obj.transform.SetParent(parent, false);
        }
        private void ClearItem(GameObject obj, string name)
        {
            GameObject.Destroy(obj);
        }
        private GameObject LoadItem(string name)
        {
            return loadPrefab?.Invoke(name);
        }


        private void UILoadComplete(UIPanel ui, string name, Action<UIPanel> callback)
        {
            if (ui != null)
            {
                ui = UnityEngine.Object.Instantiate(ui, GetLayerParent(GetPanelLayer(ui)));
                ui.name = name;
                SetOrder(ui);
                _groups.Subscribe(ui);
                _groups.OnLoad(name);
            }
            callback?.Invoke(ui);
        }
        private void CheckAsyncLoad()
        {
            if (asyncLoadQueue.Count == 0) return;
            while (asyncLoadQueue.Count > 0 && asyncLoadQueue.Peek().isDone)
            {
                LoadPanelAsyncOperation op = asyncLoadQueue.Dequeue();
                UILoadComplete(op.panel, op.panelName, op.callback);
                op.SetToDefault();
                op.GlobalRecyle();
            }
        }
        private void OnShowCallBack(UIPanel panel)
        {
            if (panel == null) return;
            string name = panel.name;
            this._groups.OnShow(name);
        }
        private UIPanel Find(string name)
        {
            return _groups.FindPanel(name);
        }
        private void Load(string name, Action<UIPanel> callback)
        {
            if (_groups == null)
                throw new Exception("Please Set IGroups First");
            if (_loaders == null || _loaders.Count == 0)
                throw new Exception("Please Set UILoader First");
            for (int i = 0; i < _loaders.Count; i++)
            {
                var result = _loaders[i].Load(ref name);
                if (result == null) continue;
                UILoadComplete(result, name, callback);
                return;
            }
            LoadPanelAsyncOperation op = Framework.GlobalAllocate<LoadPanelAsyncOperation>();
            op.callback = callback;
            op.panelName = name;
            for (int i = 0; i < _loaders.Count; i++)
            {
                if (_loaders[i].LoadAsync(ref name, op))
                {
                    asyncLoadQueue.Enqueue(op);
                    return;
                }
            }
            throw new Exception($"Can't load ui with Name: {name}");
        }



        public GameObject GetItem(string name)
        {
            return _itemPool.Get(name);
        }
        public void SetItem(string name, GameObject go)
        {
            _itemPool.Set(name, go);
        }
        public void SetItemLoader(Func<string, GameObject> loader)
        {
            this.loadPrefab = loader;
        }
        public void SetReleaseAsset(Action<string> releaseAsset)
        {
            this.releaseAsset = releaseAsset;
        }


        /// <summary>
        /// 创建 画布
        /// </summary>
        public void CreateCanvas()
        {
            var root = new GameObject(name);
            root.AddComponent<RectTransform>();
            canvas = root.AddComponent<Canvas>();
            root.AddComponent<CanvasScaler>();
            root.AddComponent<GraphicRaycaster>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            CreateLayers();
        }
        /// <summary>
        /// 设置画布
        /// </summary>
        /// <param name="canvas"></param>
        public void SetCanvas(Canvas canvas)
        {
            this.canvas = canvas;
            canvas.name = name;
            CreateLayers();
        }
        /// <summary>
        /// 设置加载器
        /// </summary>
        /// <param name="loader"></param>
        public void AddLoader(IPanelLoader loader)
        {
            _loaders.Add(loader);
        }
        /// <summary>
        /// 设置ui组管理器
        /// </summary>
        /// <param name="groups"></param>
        public void SetGroups(IGroups groups)
        {
            this._groups = groups;
        }
        public void SetLayerConfig(UILayerConfig[] config)
        {
            foreach (var item in config)
            {
                if (_layerSettings.ContainsKey(item.name))
                {
                    _layerSettings[item.name] = item;
                }
                else
                {
                    _layerSettings.Add(item.name, item);
                }
            }
        }
        /// <summary>
        /// 放置相机到 ui模块的 camera 层级
        /// </summary>
        /// <param name="camera"></param>
        public void PutCamera(Camera camera)
        {
            camera.transform.SetParent(GetLayerParent(UILayer.AboveTop));
        }
        /// <summary>
        /// 展示一个界面
        /// </summary>
        /// <param name="name"></param>
        public void Show(string name)
        {
            var panel = Find(name);
            if (panel == null)
                Load(name, OnShowCallBack);
            else
                OnShowCallBack(panel);
        }
        /// <summary>
        /// 藏一个界面
        /// </summary>
        /// <param name="name"></param>
        public void Hide(string name)
        {
            var panel = Find(name);
            if (panel != null)
            {
                this._groups.OnHide(name);
            }
        }
        /// <summary>
        /// 彻底关闭一个界面
        /// </summary>
        /// <param name="name"></param>
        public void Close(string name)
        {
            var panel = Find(name);

            if (panel != null)
            {
                this._groups.OnClose(name);
                _groups.UnSubscribe(panel);
                DestroyPanel(panel);
            }
        }

    }
}
