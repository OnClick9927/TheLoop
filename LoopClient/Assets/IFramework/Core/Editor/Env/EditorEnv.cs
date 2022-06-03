/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.1f1
 *Date:           2019-03-22
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEditor.Compilation;
using System.IO;
using IFramework.Modules;
using System.Runtime.CompilerServices;
using UnityEngine;
using IFramework.Modules.Message;

namespace IFramework
{
    public partial class EditorEnv
    {
        private const string _relativeCorePath = "Core";
        private static string _fpath;
        public const EnvironmentType envType = EnvironmentType.Ev0;
        public static IEnvironment env { get { return Framework.GetEnv(envType); } }
        public static IModules moudules { get { return env.modules; } }

        public static string frameworkPath
        {
            get
            {
                if (string.IsNullOrEmpty(_fpath))
                {
                    var path = GetFilePath().ToAssetsPath();
                    int index = path.IndexOf(_relativeCorePath);
                    path = path.Substring(0, index);
                    _fpath = path;
                }
                return _fpath;
            }
        }
        public static string scriptablePath
		{
            get
            {
                string path = Path.Combine(projectMemoryPath, "ScriptableObjectCopy");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return path;
            }
        }
        public static string memoryPath
        {
            get
            {
                string path = Path.Combine(Application.persistentDataPath + "/../", "IFrameworkMemory");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path); 
                    File.SetAttributes(path, FileAttributes.Hidden);
                }
                return path;
            }
        }
        public static string formatScriptsPath
        {
            get
            {
                string path = Path.Combine(projectMemoryPath, "FormatScriptsCopy");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return path;
            }
        }
        public static string projectMemoryPath
        {
            get {
                string path = "Assets/IFrameworkProjectMemory/Editor";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return path;
            }
        }
        public static event EditorApplication.CallbackFunction delayCall { add { EditorApplication.delayCall += value; } remove { EditorApplication.delayCall -= value; } }

        [InitializeOnLoadMethod]
        static void EditorEnvInit()
        {
            Debug.Log("IFramework: EditorEnv Init?   " + frameworkPath);
            Framework.CreateEnv(envType).InitWithAttribute();
            CompilationPipeline.assemblyCompilationStarted += Dispose;
            EditorApplication.update += env.Update;
            env.modules.Message.fitSubType = true;
            env.modules.Message.processesPerFrame = 20;
            env.modules.Message.Subscribe<ICommand>(Listen);
            SendCommand(new ScriptEnvCheckCommand());
            SendCommand(new FileInitializeCommand());
        }
        private static string GetFilePath([CallerFilePath] string path = "")
        {
            return path;
        }
        private static void Dispose(string obj)
        {
            if (env != null)
                env.Dispose();
            UnityEngine.Debug.Log("IFramework: EditorEnv Dispose");
        }
        private static void Listen(IMessage message)
        {
            if (message.args.Is<ICommand>())
            {
                message.args.As<ICommand>().Excute();
            }
        }


        /// <summary>
        /// 发送命令
        /// </summary>
        /// <param name="command"></param>
        public static void SendCommand(ICommand command)
        {
            env.modules.Message.Publish<ICommand>(command);
        }
        /// <summary>
        /// 注册消息
        /// </summary>
        /// <typeparam name="type"></typeparam>
        /// <param name="listener"></param>
        /// <returns></returns>
        public static void SubscribeRootMessage<type>(IMessageListener listener)
        {
            env.modules.Message.Subscribe<type>(listener);
        }
        /// <summary>
        /// 取消监听
        /// </summary>
        /// <typeparam name="type"></typeparam>
        /// <param name="listener"></param>
        /// <returns></returns>
        public static void UnSubscribeRootMessage<type>(IMessageListener listener)
        {
            env.modules.Message.UnSubscribe<type>(listener);
        }
        /// <summary>
        /// 发布消息
        /// </summary>
        /// <typeparam name="Type"></typeparam>
        /// <param name="args"></param>
        /// <param name="priority"></param>
        /// <returns></returns>
        public static IMessage PublishRootMessage<Type>(IEventArgs args, MessageUrgencyType priority = MessageUrgencyType.Common)
        {
            return env.modules.Message.Publish<Type>(args, priority);
        }
    }

}
