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
	public partial class UpdatePanelView
	{
		protected override void BindProperty()
		{
			base.BindProperty();
			//ToDo
			this.handler.BindProperty(() =>
			{
				this.Progress.value = Tcontext.progress;
			});
		}

		protected override void OnLoad()
		{
		}

		protected override void OnShow()
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnPause()
		{
		}

		protected override void OnResume()
		{
		}

		protected override void OnClose()
		{
		}

	}
}