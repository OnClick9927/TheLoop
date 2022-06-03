/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IFramework;
using IFramework.Hotfix.Asset;
using System.Linq;
using static IFramework.Hotfix.Asset.Assets;

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
    public class LoopClientUpdate : MonoBehaviour
    {
        public event Action<float> downLoadProgress;
        public event Action beginDownLoad;
        public event Action endDownLoad;
        public event Action beginPrepare, endPrepare;
        public event Action<float> prepareProgress;
        public async void Check()
        {
            LoopClientGame game = Launcher.Instance.game as LoopClientGame;
            if (game.AssetCheck)
            {
                Assets.SetAssetsSetting(new LoopClientAssetsSetting());
                var op = await Assets.VersionCheck();
                int count = op.downLoadOnes.Count;
                if (count > 0)
                {
                    beginDownLoad?.Invoke();
                    for (int i = 0; i < count; i++)
                    {
                        await Assets.DownLoadBundle(op.downLoadOnes[i].bundleName);
                        downLoadProgress?.Invoke(i / (float)count);
                    }
                    endDownLoad?.Invoke();
                }
                Init();

            }
            else
            {
                await System.Threading.Tasks.Task.Delay(1000);
                Init();

              
            }

        }
        private async void Init()
        {
            beginPrepare?.Invoke();
            await Assets.InitAsync();
            var paths = Assets.GetAllAssetPaths();
            var prepareOP = Assets.PrepareAssets(paths.ToArray());
            StartCoroutine(CallProgress(prepareOP));
        }
        private IEnumerator CallProgress(AssetsGroupOperation prepareOP)
        {
            while (!prepareOP.isDone)
            {
                prepareProgress?.Invoke(prepareOP.progress);
                yield return null;
            }
            endPrepare?.Invoke();
        }
    }
}
