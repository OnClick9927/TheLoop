/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-10
 *Description:    Description
 *History:        2022-04-10--
*********************************************************************************/
using UnityEngine;
using UnityEngine.UI;

namespace LoopClient
{
    public class ImageRaycastAlphaFitter : MonoBehaviour
	{
        public float alphaThreshold = 0.1f;

        void Start()
        {
            GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
        }
    }
}
