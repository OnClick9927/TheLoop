/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-07-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;
using System.Collections.Generic;
using UnityEngine;
namespace IFramework.UI
{
    class UIItemsPool
    {
        class UIItemPool : ObjectPool<GameObject>
        {
            private GameObject prefab;
            private string name;
            private Action<GameObject, string> onSet;
            private Action<GameObject, string> onGet;
            private Action<GameObject, string> onClear;

            public UIItemPool(GameObject prefab, string name, Action<GameObject, string> onSet, Action<GameObject, string> onGet, Action<GameObject, string> onClear)
            {
                this.prefab = prefab;
                this.name = name;
                this.onSet = onSet;
                this.onGet = onGet;
                this.onClear = onClear;
            }

            protected override GameObject CreatNew(IEventArgs arg)
            {
                return GameObject.Instantiate(prefab);
            }
            protected override void OnGet(GameObject t, IEventArgs arg)
            {
                onGet?.Invoke(t, name);
            }
            protected override bool OnSet(GameObject t, IEventArgs arg)
            {
                onSet?.Invoke(t, name);
                return base.OnSet(t, arg);
            }
            protected override void OnClear(GameObject t, IEventArgs arg)
            {
                onClear?.Invoke(t, name);
            }
        }

        private Dictionary<string, UIItemPool> pools = new Dictionary<string, UIItemPool>();
        private Func<string, GameObject> loadPrefab;
        private Action<GameObject, string> onSet;
        private Action<GameObject, string> onGet;
        private Action<GameObject, string> onClear;
        private Action<string> onRelase;

        public UIItemsPool(Func<string, GameObject> loadPrefab, Action<GameObject, string> onSet, Action<GameObject, string> onGet, Action<GameObject, string> onClear, Action<string> onRelase)
        {
            this.loadPrefab = loadPrefab;
            this.onSet = onSet;
            this.onGet = onGet;
            this.onClear = onClear;
            this.onRelase = onRelase;
        }

        public GameObject Get(string name)
        {
            if (pools.ContainsKey(name))
                return pools[name].Get();
            else
            {
                return LoadPrefab(name);
            }
        }
        public GameObject LoadPrefab(string name)
        {
            var go = loadPrefab?.Invoke(name);
            UIItemPool pool = new UIItemPool(go, name, onSet, onGet, onClear);
            pools.Add(name, pool);
            return pool.Get();
        }
        public void Set(string name, GameObject go)
        {
            pools[name].Set(go);
        }

        public void Clear()
        {
            foreach (var item in pools.Values)
            {
                item.Clear();
            }
            foreach (var item in pools.Keys)
            {
                onRelase?.Invoke(item);
            }
        }

    }


}
