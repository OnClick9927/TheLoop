/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using IFramework;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

namespace LoopClient
{
    [CustomEditor(typeof(LoopClientPanelConfig))]
    public class LoopClientPanelConfigEditor : Editor
    {
        private LoopClientPanelConfig data { get { return target as LoopClientPanelConfig; } }
        private ReorderableList list;
        private void OnEnable()
        {
            list = EditorTools.ReorderableListTool.CreateAutoLayout(
                          serializedObject.FindProperty("datas"),
                          new string[] { "界面名字", "层级", "层级次序" },
                          new float[] { 0, 120, 50 }
                          );

        }
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            list.DoLayoutList();
            if (EditorGUI.EndChangeCheck())
            {
                serializedObject.ApplyModifiedProperties();
            }
            if (GUILayout.Button("Save to Json"))
            {
                var str = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText("Assets/Project/Configs/Json/UI.json", str);
                AssetDatabase.Refresh();
            }
            if (GUILayout.Button("Load From Json"))
            {
                var str = File.ReadAllText("Assets/Project/Configs/Json/UI.json");
                var cfg = JsonConvert.DeserializeObject<LoopClientPanelConfig_RT>(str);
                data.datas.Clear();
                for (int i = 0; i < cfg.datas.Count; i++)
                {
                    data.datas.Add(new LoopClientPanelConfig.Data()
                    {
                        layer = cfg.datas[i].layer,
                        layerOrder = cfg.datas[i].layerOrder,
                        panelName = cfg.datas[i].panelName,
                    });
                }
                EditorTools.AssetTool.Update(this);
                serializedObject.Update();
                EditorApplication.RepaintProjectWindow();
            }
        }
    }
}
