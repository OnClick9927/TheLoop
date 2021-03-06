/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.146
 *UnityVersion:   2018.4.17f1
 *Date:           2020-04-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEngine;

namespace IFramework.Tweens
{
    class Vector3TweenValue : TweenValue<Vector3>
    {
        protected override void MoveNext()
        {
            Vector3 dest = Vector3.Lerp(start, end, convertPercent);
            current = Vector3.Lerp(pluginValue, dest, deltaPercent);
        }
        protected override Vector3 Snap(Vector3 value)
        {
            value.x = value.x.RoundToInt();
            value.y = value.y.RoundToInt();
            value.z = value.z.RoundToInt();
            return value;
        }
    }

}
