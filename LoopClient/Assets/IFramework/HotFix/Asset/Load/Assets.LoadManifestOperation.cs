/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.179
 *UnityVersion:   2019.4.36f1c1
 *Date:           2022-03-07
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/

using UnityEngine;
namespace IFramework.Hotfix.Asset
{
    public partial class Assets
    {
        public class LoadManifestOperation : AssetOperation
        {
            public override float progress
            {
                get
                {
                    if (isDone) return 1;
                    if (op == null)
                        return bundle.progress * 0.5f;
                    return bundle.progress * 0.5f + op.progress * 0.5f;
                }
            }

            private Bundle bundle;
            private AssetBundleRequest op;

            public LoadManifestOperation()
            {
                Done();
            }

            private async void Done()
            {
                if (!fastMode)
                {
                    string path = AssetManifest.Path;
                    bundle = await LoadBundleAsync(AssetsTool.GetMd5(path));
                    op = await bundle.LoadAssetAsync(path, typeof(AssetManifest));
                    manifest = op.asset as AssetManifest;
                }
                InvokeComplete();
            }
        }
    }
}
