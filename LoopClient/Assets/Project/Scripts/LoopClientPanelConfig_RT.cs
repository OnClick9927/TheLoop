/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using System.Collections.Generic;
using IFramework.UI;
using UnityEngine;
namespace LoopClient
{
    public class LoopClientPanelConfig_RT
    {
        [System.Serializable]
        public class Data
        {
            public string panelName;
            public UILayer layer = UILayer.Common;
            public int layerOrder = 0;
        }
        [SerializeField] public List<Data> datas = new List<Data>();
    }
}
