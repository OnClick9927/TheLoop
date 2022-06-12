/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using IFramework.Hotfix.Asset;

namespace LoopClient
{
    public class LoopClientAssetsSetting : AssetsSetting
    {
        public override string GetUrlByBundleName(string buildTarget, string bundleName)
        {
            return "";
        }

        public override string GetVersionUrl()
        {
            return "";
        }
    }
}
