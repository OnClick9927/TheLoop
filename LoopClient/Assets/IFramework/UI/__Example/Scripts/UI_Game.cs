/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2018.4.24f1
 *Date:           2021-06-27
 *Description:    Description
 *History:        2021-06-27--
*********************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using IFramework;
using UnityEngine;
namespace IFramework.UI.Example
{
    public class UI_Game : Game, IPanelLoader
    {
        public UIModule module;
        public override void Init()
        {
            module = modules.GetModule<UIModule>("Example");
            module.CreateCanvas();
            module.AddLoader(this);
            module.SetGroups(new MvvmGroups(UIMap_MVVM.map));
        }

        public UIPanel Load(ref string name)
        {
            return null;
            //return Resources.Load<GameObject>(name).GetComponent<UIPanel>();
        }

        public bool LoadAsync(ref string name, LoadPanelAsyncOperation op)
        {
            LoadAsync(op);
            return true;
        }
        private async void LoadAsync(LoadPanelAsyncOperation op)
        {
            await System.Threading.Tasks.Task.Delay(1000);
            var ui = Resources.Load<GameObject>(op.panelName).GetComponent<UIPanel>();
            op.SetPanel(ui);
        }

        public override void Startup()
        {
            module.Show(UIMap_MVVM.Panel02);
            module.Show(UIMap_MVVM.Panel01);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                module.Show(UIMap_MVVM.Panel01);
                module.Hide(UIMap_MVVM.Panel02);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                module.Hide(UIMap_MVVM.Panel01);
                module.Show(UIMap_MVVM.Panel02);
            }
        }
    }
}
