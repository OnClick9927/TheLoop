﻿/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
namespace LoopClient
{
	public partial class UpdatePanelView : IFramework.UI.UIView<UpdatePanelViewModel, UpdatePanel> 
	{
		private UnityEngine.UI.Slider Progress { get { return Tpanel.Progress; } }

	}
}