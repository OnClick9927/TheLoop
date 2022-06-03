/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using IFramework.Hotfix.Asset;
using IFramework.UI;
using UnityEngine;

namespace LoopClient
{
    public class UILoader : IPanelLoader
    {
        public UIPanel Load(ref string name)
        {
            var asset = Assets.LoadAsset($"Assets/Project/Prefabs/UI/{name}.prefab");
            return asset.GetAsset<GameObject>().GetComponent<UIPanel>();
        }

        public bool LoadAsync(ref string name, LoadPanelAsyncOperation op)
        {
            return false;
        }
    }
}
