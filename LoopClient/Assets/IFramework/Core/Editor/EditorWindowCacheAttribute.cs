/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.1f1
 *Date:           2019-03-18
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;

namespace IFramework
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class EditorWindowCacheAttribute : Attribute
    {
        public string searchName { get; private set; }
        public EditorWindowCacheAttribute() { }
        public EditorWindowCacheAttribute(string searchName)
        {
            this.searchName = searchName;
        }

    }
}
