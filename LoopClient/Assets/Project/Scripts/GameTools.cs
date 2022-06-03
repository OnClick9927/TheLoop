/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-09
 *Description:    Description
 *History:        2022-04-09--
*********************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using IFramework;
using UnityEngine;
using IFramework.Hotfix.Asset;
using System.Threading.Tasks;

namespace LoopClient
{
    public class GameTools
    {
        public static async Task<string> LoadText(string path) 
        {
            var asset = await Assets.LoadAsset(path); 
            TextAsset txt = asset.GetAsset<TextAsset>();
            return txt.text; 
        }
        public static string GetDeviceUniqueIdentifier()
        {
            return SystemInfo.deviceUniqueIdentifier;
        }
    }
}
