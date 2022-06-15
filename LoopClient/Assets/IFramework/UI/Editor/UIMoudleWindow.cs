/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.11f1
 *Date:           2020-01-13
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEngine;
using System.Linq;
using System;
using System.Collections.Generic;

namespace IFramework.UI
{
    [EditorWindowCache("UIModule")]
    partial class UIMoudleWindow : EditorWindow
    {
        private Dictionary<string, UIMoudleWindowTab> _tabs;
        private string[] _names;
        private int viewIndex;
        private const string key = "UIMoudleWindow";
        public static UIMoudleWindow _window;

        private void OnEnable()
        {
            _tabs = typeof(UIMoudleWindowTab).GetSubTypesInAssemblys()
                                     .ToList()
                                     .ConvertAll((type) => { return Activator.CreateInstance(type) as UIMoudleWindowTab; })
                                     .ToDictionary((tab) => { return tab.name; });

            _names = _tabs.Keys.ToArray();
            foreach (var item in _tabs.Values)
            {
                item.OnEnable();
            }
            EditorApplication.hierarchyChanged += () =>{ Repaint(); };

        }
        private void OnDisable()
        {
            foreach (var item in _tabs.Values)
            {
                item.OnDisable();
            }
        }
        private void OnGUI()
        {
            viewIndex = GUILayout.Toolbar(viewIndex, _names);
            _tabs[_names[viewIndex]].OnGUI();
        }
        private void OnHierarchyChange()
        {
            _tabs[_names[viewIndex]].OnHierarchyChanged();
            Repaint();
        }
    }
}
