using System;

namespace IFramework.Modules.Timer
{
    internal interface ITimerModule
    {
        /// <summary>
        /// 注册方法
        /// </summary>
        /// <param name="actionItem"></param>
        void Subscribe(ITimerEntity actionItem);
        /// <summary>
        /// 清除所有定时方法
        /// </summary>
        void Clear();
        /// <summary>
        /// 分配
        /// </summary>
        /// <returns></returns>
        ITimerEntity Allocate(Action action, float delay, int times, float timeScale);
    }
}
