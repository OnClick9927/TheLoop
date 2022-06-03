/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-07-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/

using System;
using UnityEngine;

namespace IFramework.UI
{
    public class LoadPanelAsyncOperation
    {
        public Action<UIPanel> callback;
        public UIPanel panel;
        public bool isDone;
        public string panelName;

        public void SetPanel(UIPanel panel)
        {
            this.panel = panel;
            this.isDone = true;
        }
        public void SetToDefault()
        {
            callback = null;
            panel = null;
            isDone = false;
            panelName = null;
        }
    }
}
