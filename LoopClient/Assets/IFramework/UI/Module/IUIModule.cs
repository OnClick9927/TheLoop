using System;
using UnityEngine;

namespace IFramework.UI
{
    public interface IUIModule
    {
        Canvas canvas { get; }
        void SetLayerConfig(UILayerConfig[] config);
        void AddLoader(IPanelLoader loader);
        void SetGroups(IGroups groups);
        void CreateCanvas();
        void SetCanvas(Canvas canvas);
        void PutCamera(Camera camera);

        void Hide(string name);
        void Show(string name);
        void Close(string name);


        GameObject GetItem(string name);
        void SetItem(string name, GameObject go);
        void SetItemLoader(Func<string, GameObject> loader);
        void SetReleaseAsset(Action<string> releaseAsset);
    }
}