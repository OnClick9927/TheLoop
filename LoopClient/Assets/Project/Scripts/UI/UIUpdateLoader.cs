/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using IFramework.UI;
using UnityEngine;

namespace LoopClient
{
    public class UIUpdateLoader : IPanelLoader
    {
        public UIPanel Load(ref string name)
        {
            switch (name)
            {
                case nameof(UpdatePanel):
                    return Resources.Load<GameObject>("UI/UpdatePanel").GetComponent<UpdatePanel>();

                default:
                    return null;
            }
        }

        public bool LoadAsync(ref string name, LoadPanelAsyncOperation op)
        {
            return false;
        }
    }
}
