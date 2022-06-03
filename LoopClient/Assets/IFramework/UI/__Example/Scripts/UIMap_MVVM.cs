/*********************************************************************************
 *Author:         
 *Version:        1.0
 *UnityVersion:   2019.4.36f1c1
 *Date:           2022-04-04
 *Description:    Description
 *History:        2022-04-04--
*********************************************************************************/
namespace IFramework.UI.Example
{
	partial class UIMap_MVVM
	{
		public const string Panel02 = "Panel02";
		public const string Panel01 = "Panel01";

	}
	public partial class UIMap_MVVM 
	{
		public static System.Collections.Generic.Dictionary<string, System.Tuple<System.Type, System.Type, System.Type>> map = 
		new System.Collections.Generic.Dictionary<string, System.Tuple<System.Type, System.Type, System.Type>>()
		{

			{ Panel02 ,System.Tuple.Create(typeof(IFramework.UI.Example.Panel02Model),typeof(IFramework.UI.Example.Panel02View),typeof(IFramework.UI.Example.Panel02ViewModel))},
			{ Panel01 ,System.Tuple.Create(typeof(IFramework.UI.Example.Panel01Model),typeof(IFramework.UI.Example.Panel01View),typeof(IFramework.UI.Example.Panel01ViewModel))},

		}
;	 }
}
