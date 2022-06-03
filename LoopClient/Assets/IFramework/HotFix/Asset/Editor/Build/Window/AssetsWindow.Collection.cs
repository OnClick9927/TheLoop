/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.204
 *UnityVersion:   2019.4.36f1c1
 *Date:           2022-03-09
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEngine;
using System;
using IFramework.GUITool;
using UnityEditor.IMGUI.Controls;

namespace IFramework.Hotfix.Asset
{
    partial class AssetsWindow
    {
        [Serializable]
        public partial class Collection : GUIBase
        {
            private CollectType m_CollectType;
            private TreeViewState state_col = new TreeViewState();
            private TreeViewState state_dir = new TreeViewState();
            private TreeViewState state_atlas = new TreeViewState();

            private Tools tools = new Tools();
            [SerializeField] private AtlasDirs atlas;
            [SerializeField] private CollectTree col;
            [SerializeField] private Directorys dirs;
            private SplitView splitView = new SplitView();
            public void Collect()
            {
                col.Reload();
            }
            public void OnEnable()
            {
                if (atlas == null)
                    atlas = new AtlasDirs(state_atlas);
                if (col == null)
                    col = new CollectTree(state_col);
                if (dirs == null)
                    dirs = new Directorys(state_dir);
                tools.collection = this;
                splitView.fistPan += PanLeft;
                splitView.secondPan += col.OnGUI;
            }
            public void PanLeft(Rect position)
            {
                var rs = position.HorizontalSplit(20);
                m_CollectType = (CollectType)GUI.Toolbar(rs[0], (int)m_CollectType, Enum.GetNames(typeof(CollectType)));
                switch (m_CollectType)
                {
                    case CollectType.Tools:
                        tools.OnGUI(rs[1]);
                        break;
                    case CollectType.Atlas:
                        atlas.OnGUI(rs[1]);
                        break;
                    case CollectType.Directory:
                        dirs.OnGUI(rs[1]);
                        break;
                    default:
                        break;
                }
            }
            public override void OnGUI(Rect position)
            {
                base.OnGUI(position);
                splitView.OnGUI(position);
            }
            protected override void OnDispose()
            {

            }
        }
    }
}
