/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.51
 *UnityVersion:   2018.4.24f1
 *Date:           2020-09-13
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEngine;

#pragma warning disable
namespace IFramework
{
    partial class RootWindow
    {
        class Contents
        {
            public const float lineHeight = 20;
            public const float gap = 10;

            public static GUIContent accop = new GUIContent("Account Operation");

            public static GUIContent go = new GUIContent("Go");
            public static GUIContent logout = new GUIContent("Logout");
            public static GUIContent select = new GUIContent("Select");
            public static GUIContent remove = new GUIContent("Remove");
            public static GUIContent install = new GUIContent("Install");
            public static GUIContent delete = new GUIContent("Delete");

            public static GUIContent newest = new GUIContent("Newset");
            public static GUIContent refresh = EditorGUIUtility.IconContent("TreeEditor.Refresh");
            public static GUIContent help = EditorGUIUtility.IconContent("SoftlockProjectBrowser Icon");

        }

    }

}
