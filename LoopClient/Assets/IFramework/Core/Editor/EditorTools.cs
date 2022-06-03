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
        private const string copyAssetPathPath = "Assets/IFramework/Copy Path";
        private const string findScriptPath = "CONTEXT/MonoBehaviour/IFramework.FindScript";



        [MenuItem(findScriptPath)]
        static void FindScript(MenuCommand command)
        {
            Selection.activeObject = MonoScript.FromMonoBehaviour(command.context as MonoBehaviour);
        }

        [MenuItem(copyAssetPathPath, priority = -100000000)]
        public static void CopyAssetPath()
        {
            if (EditorApplication.isCompiling)
            {
                return;
            }
            string path = AssetDatabase.GetAssetPath(Selection.activeInstanceID);
            GUIUtility.systemCopyBuffer = path;
        }
        public static void OpenFolder(string folder)
        {
            EditorUtility.OpenWithDefaultApp(folder);
        }
        public static Rect LocalPosition(this EditorWindow self)
        {
            return new Rect(Vector2.zero, self.position.size);
        }
    }
}
