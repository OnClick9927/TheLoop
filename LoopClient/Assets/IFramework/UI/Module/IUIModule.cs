using System;
using UnityEngine;

namespace IFramework.UI
{
    public interface IUIModule
    {
        Canvas canvas { get; }
        void AddLoader(IPanelLoader loader);
        void Close(string name);
        void CreateCanvas();
        UIPanel Find(string name);
        void Hide(string name);
        void Load(string name, Action<UIPanel> callback);
        void Pause(string name);
        void PutCamera(Camera camera);
        void SetCanvas(Canvas canvas);
        void SetGroups(IGroups groups);
        void Show(string name);
        void Resume(string name);
        void SetArg(string name, IEventArgs arg);
        void RemoveArg(string name);
        void SetLayerConfig(UILayerConfig[] config);
        IEventArgs GetArg(string name);

        GameObject GetItem(string name);
        void SetItem(string name, GameObject go);
        void SetItemLoader(Func<string, GameObject> loader);
        void SetReleaseAsset(Action<string> releaseAsset);
    }
}