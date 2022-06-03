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
using IFramework.GUITool;
using UnityEditor.IMGUI.Controls;
using System.Collections.Generic;
using Object = UnityEngine.Object;

namespace IFramework.Hotfix.Asset
{
    partial class AssetsWindow
    {
        public partial class Collection
        {
            private class AtlasDirs : TreeView
            {
                public AtlasDirs(TreeViewState state) : base(state)
                {
                    this.Reload();
                    showAlternatingRowBackgrounds = true;
                }
                protected override TreeViewItem BuildRoot()
                {
                    return new TreeViewItem() { id = -1, depth = -1 };
                }
                public override void OnGUI(Rect rect)
                {
                    base.OnGUI(rect);
                    GUI.Label(rect, "<color=#777777>Drag\nDirectory\nHere\nThat\nWant\nBuild\nAtlas</color>",
                        new GUIStyle(GUIStyles.BoldLabel)
                        {
                            fontSize = 30,
                            alignment = TextAnchor.MiddleCenter,
                            richText = true,
                        });
                }
                protected override IList<TreeViewItem> BuildRows(TreeViewItem root)
                {
                    List<TreeViewItem> result = new List<TreeViewItem>();

                    var paths = buildSetting.GetAtlasPaths();
                    foreach (var path in paths)
                    {
                        TreeViewItem item = new TreeViewItem()
                        {
                            id = result.Count,
                            depth = 0,
                            displayName = path,
                            parent = root,
                            icon = AssetInfo.GetMiniThumbnail(path),
                        };
                        result.Add(item);
                    }
                    SetupParentsAndChildrenFromDepths(root, result);

                    return result;
                }
                protected override void RowGUI(RowGUIArgs args)
                {
                    GUI.Label(args.rowRect, new GUIContent(args.item.displayName, args.item.icon));
                    if (GUI.Button(new Rect(args.rowRect.xMax - 20, args.rowRect.y, 20, 20), "", GUIStyles.minus))
                    {
                        buildSetting.RemoveAtlasPath(args.item.displayName);
                        Reload();
                    }
                }
                protected override void AfterRowsGUI()
                {
                    base.AfterRowsGUI();
                    var info = EditorTools.DragAndDropTool.Drag(Event.current, this.treeViewRect);
                    if (info.enterArera && info.dragging)
                    {
                        if (info.paths != null)
                        {
                            for (int i = 0; i < info.paths.Length; i++)
                            {
                                var path = info.paths[i].ToAssetsPath();
                                if (path.IsDirectory())
                                    buildSetting.AddAtlasPath(path);
                            }
                            Reload();
                        }
                    }
                }
                protected override void DoubleClickedItem(int id)
                {
                    var rows = this.FindRows(new List<int>() { id });
                    EditorGUIUtility.PingObject(AssetDatabase.LoadAssetAtPath<Object>(rows[0].displayName));
                    base.DoubleClickedItem(id);
                }
                protected override bool CanMultiSelect(TreeViewItem item)
                {
                    return false;
                }
            }
        }
    }
}
