/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using IFramework;
namespace LoopClient
{
    public partial class UpdatePanelViewModel
    {
        private LoopClientGame game { get { return Launcher.Instance.game as LoopClientGame; } }
        protected override void Initialize()
        {
            game.update.beginDownLoad += Update_beginDownLoad;
            game.update.downLoadProgress += Update_downLoadProgress;
            game.update.endDownLoad += Update_endDownLoad;
            game.update.beginPrepare += Update_beginPrepare;
            game.update.prepareProgress += Update_prepareProgress;
            game.update.endPrepare += Update_endPrepare;
        }



        protected override void OnDispose()
        {
            game.update.beginDownLoad -= Update_beginDownLoad;
            game.update.downLoadProgress -= Update_downLoadProgress;
            game.update.endDownLoad -= Update_endDownLoad;
            game.update.beginPrepare -= Update_beginPrepare;
            game.update.prepareProgress -= Update_prepareProgress;
            game.update.endPrepare -= Update_endPrepare; 
        }

        protected override void Listen(IFramework.IEventArgs message)
        {

        }
        private void Update_endPrepare()
        {
            game.StartGame();
        }

        private void Update_prepareProgress(float obj)
        {
            this.progress = obj;
        }

        private void Update_beginPrepare()
        {

        }

        private void Update_endDownLoad()
        {
        }

        private void Update_downLoadProgress(float obj)
        {
            this.progress = obj;
        }

        private void Update_beginDownLoad()
        {
        }
    }
}