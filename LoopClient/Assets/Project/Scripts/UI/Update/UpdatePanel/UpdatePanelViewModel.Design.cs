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
	public partial class UpdatePanelViewModel : IFramework.UI.UIViewModel<LoopClient.UpdatePanelModel>
	{
 		private System.Single _progress;
		public System.Single progress
		{
			get { return GetProperty(ref _progress); }
			private set			{
				Tmodel.progress = value;
				SetProperty(ref _progress, value);
			}
		}


		protected override void SyncModelValue()
		{
 			this.progress = Tmodel.progress;

		}

	}
}