﻿/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-08-19
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEngine;
namespace IFramework.UI
{
    /// <summary>
    /// ui 基类
    /// </summary>
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class UIPanel : MonoBehaviour
    {

        private CanvasGroup _group;
        private RectTransform _rect;
        public IUIModule module { get; set; }


        public RectTransform rectTransform
        {
            get
            {
                if (_rect == null)
                {
                    _rect = GetComponent<RectTransform>();
                }
                return _rect;
            }
        }

        public CanvasGroup group
        {
            get
            {
                if (_group == null)
                {
                    _group = GetComponent<CanvasGroup>();
                }
                return _group;
            }
        }
        public void SetArgs(IEventArgs args)
        {
            this.module.SetArg(this.name, args);
        }
        public void RemoveArg()
        {
            this.module.RemoveArg(this.name);
        }
        public IEventArgs GetArg()
        {
            return this.module.GetArg(this.name);
        }

        /// <summary>
        /// 使ui不响应事件
        /// </summary>
        public void Pause()
        {
            group.interactable = false;
        }
        /// <summary>
        /// 使ui响应事件
        /// </summary>
        public void Resume()
        {
            group.interactable = true;
        }
        /// <summary>
        /// 把ui藏起来
        /// </summary>
        public void Hide()
        {
            gameObject.SetActive(false);
        }
        /// <summary>
        /// 展示出ui
        /// </summary>
        public void Show()
        {
            gameObject.SetActive(true);
        }
    }
}
