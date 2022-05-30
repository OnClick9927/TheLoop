using IFramework;
using System.Timers;
using LoopSever.Project.Net;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.ServerCore.Plugins;


namespace LoopSever.Project.Game
{
    public static class ServerInstance
    {
        static System.Timers.Timer timer;
        public const EnvironmentType envType = EnvironmentType.Ev0;

        public static IEnvironment env { get; private set; }

        //服务器链接
        private static TcpSever sever;

        //数据库链接
        // private static GameDbContext SevicedbContext;


        public static void StartGame()
        {
            timer = new System.Timers.Timer(1000 / SeverConst.trickPerSecond);
            timer.Elapsed += Timer_Elapsed;
            Framework.CreateEnv(envType).InitWithAttribute();
            timer.Start();
            env = Framework.GetEnv(envType);
            InitIdGenerator();
            InitSocket();
            InitDb();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            env.Update();
        }

        public static void CloseGame()
        {
            Log.L($"开始关闭  {nameof(ServerInstance)}");
            Framework.GetEnv(envType).Dispose();
            sever.Dispose();
            // SevicedbContext.Destroy();
            Log.L($"关闭成功 {nameof(ServerInstance)}");
        }


   

        private static void InitIdGenerator()
        {
            IdGeneratorMgr.instance.Init(SeverConst.workerId, SeverConst.workerIdBitLength);
        }

        private static void InitSocket()
        {
            //TcpSever.enableLogMessage = false;
            sever = new TcpSever(SeverConst.port, SeverConst.connections, SeverConst.pkgSize, new NetPlayersData());
        }

        private static void InitDb()
        {
           
        }


        /**********************************************************/

        // public static T GetDbContext<T>() where T : class
        // {
        //     return GetDbContext() as T;
        // }
        //
        // public static GameDbContext GetDbContext()
        // {
        //     
        //     MySqlDbConf sqlConf = new MySqlDbConf
        //     {
        //         server = MySqlConst.server, port = MySqlConst.port, userid = MySqlConst.userid,
        //         pwd = MySqlConst.pwd, database = MySqlConst.database,
        //     };
        //     return new GameDbContext(sqlConf);
        //     
        //     return SevicedbContext;
        // }
        public static NetPlayersData GetClientsData()
        {
            return sever.GetClientsData<NetPlayersData>();
        }

        public static TcpSever GetServer()
        {
            return sever;
        }
    }
}