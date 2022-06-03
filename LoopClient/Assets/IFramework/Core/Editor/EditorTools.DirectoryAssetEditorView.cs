/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.1f1
 *Date:           2019-03-18
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEngine;

namespace IFramework
{
    partial class EditorTools
    {
        [CustomEditor(typeof(DefaultAsset))]
        class DirectoryAssetEditorView : Editor
        {
            private string _path;
            private bool _isdir;
            private void OnEnable()
            {
                _path = AssetDatabase.GetAssetPath(this.target);
                _isdir = _path.IsDirectory();
            }
            public override void OnInspectorGUI()
            {
                base.OnInspectorGUI();
                if (_isdir)
                {
                    GUI.enabled = true;
                    if (GUILayout.Button("Open"))
                    {
                        EditorTools.OpenFolder(_path);
                    }
                }
            }
        }



    }
}
