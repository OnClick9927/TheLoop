/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.135
 *UnityVersion:   2018.4.24f1
 *Date:           2021-06-28
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using IFramework.Serialization;
using System.Collections.Generic;
using System.IO;
namespace IFramework.UI
{
    [System.Serializable]
    public class PanelGenData
    {
        [System.Serializable]
        public class NameMap
        {
            public string panelName;
            public string content;
        }
        public string MapName = "MVVMMap";
        public string ns = "";
        public string workspace = "";
        public List<NameMap> map = new List<NameMap>();

        public void AddMap(string name, string content)
        {
            var temp = map.Find(item => item.panelName == name);
            if (temp != null)
            {
                map.Remove(temp);
            }
            map.Add(new NameMap() { panelName = name, content = content });
        }
        public void RemoveMap(string name)
        {
            map.RemoveAll(item => item.panelName == name);
        }

        public static PanelGenData CheckExist(string work)
        {
            string name = Verifier.GetStringMD5(work);
            string path = EditorEnv.projectMemoryPath;
            path = path.CombinePath($"{name}.xml");
            if (!File.Exists(path))
            {
                var data = new PanelGenData() { workspace = work };
                data.Save();
                return data;
            }
            var str = File.ReadAllText(path);
            return Xml.FromXml<PanelGenData>(str);
        }
        public void Save()
        {
            string name = Verifier.GetStringMD5(workspace);
            string path = EditorEnv.projectMemoryPath;
            path = path.CombinePath($"{name}.xml");
            File.WriteAllText(path, Xml.ToXml(this));
            UnityEditor.AssetDatabase.Refresh();
        }
    }
}
