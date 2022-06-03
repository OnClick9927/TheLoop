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
	public partial class Panel01ViewModel : IFramework.UI.UIViewModel<IFramework.UI.Example.Panel01Model>
	{
 		private System.Int32 _count;
		public System.Int32 count
		{
			get { return GetProperty(ref _count); }
			private set			{
				Tmodel.count = value;
				SetProperty(ref _count, value);
			}
		}


		protected override void SyncModelValue()
		{
 			this.count = Tmodel.count;

		}

	}
}