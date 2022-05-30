
namespace IFramework.Modules.Timer
{
    /// <summary>
    /// TimeEntity接口
    /// </summary>
    public interface ITimerEntity
    {
        /// <summary>
        /// 等待时间
        /// </summary>
        float delay { get; }
        /// <summary>
        /// 执行次数
        /// </summary>
        int times { get; }
        /// <summary>
        /// 时间比例
        /// </summary>
        float timeScale { get; }
        /// <summary>
        /// 状态
        /// </summary>
        EntityState state { get; }
        /// <summary>
        /// 继续
        /// </summary>
        void Start();
        /// <summary>
        /// 暂停
        /// </summary>
        void Pause();
        /// <summary>
        /// 取消
        /// </summary>
        void Cancel(bool callComplete);
        /// <summary>
        /// 设置子定时器
        /// </summary>
        /// <param name="timerEntity">子定时器</param>
        /// <param name="type">子定时器类型</param>
        void SetInnerTimer(ITimerEntity timerEntity, InnerType type = InnerType.Parallel);
        /// <summary>
        /// 注册
        /// </summary>
        void Subscribe();
    }
}
