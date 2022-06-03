/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.204
 *UnityVersion:   2019.4.36f1c1
 *Date:           2022-03-09
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using System.Linq;
using static IFramework.EditorTools;

namespace IFramework.Hotfix.Asset
{
    [EditorWindowCache("AssetsWindow")]
    partial class AssetsWindow : EditorWindow
    {
        private Collection collection = new Collection();
        private static AssetBuildSetting buildSetting { get { return AssetBuildSetting.Load(); } }
        private static string[] types;
        private static string[] shortTypes;

        private static int typeIndex;
        private void OnEnable()
        {
            types = typeof(ICollectAssetBundleBuild).GetSubTypesInAssemblys()
                  .Where(type => !type.IsAbstract)
                  .Select(type => type.FullName).ToArray();
            shortTypes = typeof(ICollectAssetBundleBuild).GetSubTypesInAssemblys()
                  .Where(type => !type.IsAbstract)
                  .Select(type => type.Name).ToArray();  
            collection.OnEnable();
        }
        private void OnGUI()
        {
            collection.OnGUI(this.LocalPosition());
        }
    }
}
