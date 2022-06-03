/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
namespace LoopClient
{
	partial class UIMap_MVVM
	{
		public const string UpdatePanel = "UpdatePanel";

	}
	public partial class UIMap_MVVM 
	{
		public static System.Collections.Generic.Dictionary<string, System.Tuple<System.Type, System.Type, System.Type>> map = 
		new System.Collections.Generic.Dictionary<string, System.Tuple<System.Type, System.Type, System.Type>>()
		{

			{ UpdatePanel ,System.Tuple.Create(typeof(LoopClient.UpdatePanelModel),typeof(LoopClient.UpdatePanelView),typeof(LoopClient.UpdatePanelViewModel))},

		}
;	 }
}
