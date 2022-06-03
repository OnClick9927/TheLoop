/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.204
 *UnityVersion:   2019.4.36f1c1
 *Date:           2022-03-09
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEngine;
using System;
using IFramework.GUITool;

namespace IFramework.Hotfix.Asset
{
    partial class AssetsWindow
    {
        public partial class Collection
        {
            private class Tools : GUIBase
            {
                public Collection collection;
                private Vector2 scroll;
                public override void OnGUI(Rect position)
                {
                    base.OnGUI(position);
                    GUILayout.BeginArea(position);
                    {
                        scroll = GUILayout.BeginScrollView(scroll);
                        {
                            Draw();
                        }
                        GUILayout.EndScrollView();
                    }
                    GUILayout.EndArea();
                }
                private void Draw()
                {
                    EditorGUI.BeginChangeCheck();
                    Box("LoadType In Editor Mode",FastMode);
                    Box("SpriteAtlas Tool",Atlas);
                    Box("Collect All Asset For Build",Collect);
                    Box("Build AssetBundle By Collected Assets",Build);
                    if (EditorGUI.EndChangeCheck())
                    {
                        buildSetting.Save();
                    }
                }
                private void Build()
                {
                    typeIndex = EditorGUILayout.Popup("AssetBundleBuildCollect",typeIndex, shortTypes);
                    var op = (BuildAssetBundleOptions)EditorGUILayout.EnumFlagsField("BuildAssetBundleOptions", buildSetting.option);
                    if (buildSetting.option != op)
                    {
                        buildSetting.option = op;
                        buildSetting.Save();
                    }
                    if (GUILayout.Button("Build AssetBundle"))
                    {
                        var type_str = types[typeIndex];
                        Type type = Type.GetType(type_str);
                        AssetsBuild.Build(type);
                        GUIUtility.ExitGUI();
                    }
                    if (GUILayout.Button("Open Output Directory"))
                    {
                        EditorTools.OpenFolder(AssetBuildSetting.outputPath);
                    }
                }
                private void FastMode()
                {
                    buildSetting.fastMode = EditorGUILayout.Toggle("FastMode", buildSetting.fastMode);
                }
                private void Atlas()
                {
                    if (GUILayout.Button("Build Atlas"))
                    {
                        AssetsBuild.BuildAtlas();
                    }
                    if (GUILayout.Button("Edit Atlas Collect"))
                    {
                        collection.m_CollectType = CollectType.Atlas;
                    }
                }
                private void Collect()
                {
                    SerializedObject obj = new SerializedObject(buildSetting);
                    var prop = obj.FindProperty("ignoreFileEtend");
                    EditorGUILayout.PropertyField(prop, new GUIContent("Ignore File Extends"), true);
                    if (GUILayout.Button("Collect"))
                    {
                        buildSetting.Colllect();
                        collection.Collect();
                        buildSetting.Save();
                    }
                    if (GUILayout.Button("Edit Asset Collect"))
                    {
                        collection.m_CollectType = CollectType.Directory;
                    }
                }
                private void Box(string label,Action action)
                {
                    GUILayout.BeginVertical("box");
                    {
                        GUILayout.Space(5);
                        GUILayout.Label(label,GUIStyles.largeLabel);
                        action.Invoke();
                        GUILayout.Space(5);
                    }
                    GUILayout.EndVertical();
                }
                protected override void OnDispose()
                {

                }
            }
        }
    }
}
