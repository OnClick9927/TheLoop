/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.146
 *UnityVersion:   2018.4.17f1
 *Date:           2020-04-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;

namespace IFramework.Tweens
{
    public class RecyclablePlugin<T> : RecyclableObject, IPlugin<T> where T : struct
    {
        public T start { get; set; }
        public T end { get; set; }
        public Action<T> setter { get; set; }
        public Func<T> getter { get; set; }
        public float duration { get; set; }
        public bool snap { get; set; }

        public void Config(T start, T end, float duration, Func<T> getter, Action<T> setter, bool snap)
        {
            this.start = start;
            this.end = end;
            this.duration = duration;
            this.setter = setter;
            this.getter = getter;
            this.snap = snap;
            SetDataDirty();
        }

        protected override void OnDataReset()
        {
            this.snap = false;
            duration = 0;
            start = end = default(T);
            setter = null;
            getter = null;
        }
    }
}
