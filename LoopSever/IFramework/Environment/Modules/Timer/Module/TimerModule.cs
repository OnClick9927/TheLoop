using System;
using System.Collections.Generic;

namespace IFramework.Modules.Timer
{
    /// <summary>
    /// 时间模块
    /// </summary>
    public class TimerModule : UpdateModule, ITimerModule
    {
        private List<TimerEntity> _entities;
        DateTime _lastTime; //保存上一次的时间，便于计算DeltaTime;
        /// <summary>
        /// 清除方法
        /// </summary>
        public void Clear()
        {
            _entities.Clear();
        }
        /// <summary>
        /// 注册定时方法
        /// </summary>
        /// <param name="entity"></param>
        public void Subscribe(ITimerEntity entity)
        {
             
            if (entity.state != EntityState.NotStart)
            {
                Log.E("Don't Subscribe an Used entity");
            }

            if ((entity as TimerEntity).timer == null)
                Log.E("Don't Create new entity ,Use Allocate");

            if (_entities.Contains((entity as TimerEntity)))
            {
                throw new InvalidOperationException("This item has been already subscribed");
            }
            _entities.Add((entity as TimerEntity));
            entity.Start();
        }
        /// <summary>
        /// awake
        /// </summary>
        protected override void Awake()
        {
            _entities = new List<TimerEntity>();
            _lastTime = DateTime.Now;
        }

        /// <summary>
        /// dispose
        /// </summary>
        protected override void OnDispose()
        {
            for (int i = 0; i < _entities.Count; i++)
            {
                _entities[i].Reset();
                _entities[i].GlobalRecyle();
            }
            _entities.Clear();
        }

        /// <summary>
        /// update
        /// </summary>
        protected override void OnUpdate()
        {
            if (_entities.Count <= 0) return;

            var deltaTime = (float)(DateTime.Now - _lastTime).TotalMilliseconds;

            _lastTime = DateTime.Now;
            
            for (int i = _entities.Count - 1; i >= 0; i--)
            {
                var entity = _entities[i];
                if (entity.state == EntityState.Done)
                {
                    _entities.Remove(entity);
                    entity.Reset();
                    entity.GlobalRecyle();
                    continue;
                }

                entity.Update(deltaTime);
            }
        }

        /// <summary>
        ///  全局分配
        /// </summary>
        /// <param name="action">调用的方法</param>
        /// <param name="delay">延迟时间</param>
        /// <param name="times">执行次数</param>
        /// <param name="timeScale">时间比例</param>
        /// <returns>获取的TimerEntity</returns>
        public ITimerEntity Allocate(Action action, float delay, int times = 1, float timeScale = 1f)
        {
            var entity = Framework.GlobalAllocate<TimerEntity>();
            entity.timer = this;
            entity._action = action;
            entity._delay = delay;
            entity._times = times;
            entity._timeScale = timeScale;
            entity._state = EntityState.NotStart;
            return entity;
        }
    }
}
