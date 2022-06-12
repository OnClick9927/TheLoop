/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-07-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;
using System.Collections.Generic;
using IFramework.MVVM;

namespace IFramework.UI
{
    /// <summary>
    /// ui MVVM 组容器
    /// </summary>
    public class MvvmGroups : IGroups
    {
        internal interface IViewStateEventHandler
        {
            void OnLoad();
            void OnShow();
            void OnHide();
            void OnClose();
        }
        private MVVMGroups _moudule;
        private Dictionary<string, Tuple<Type, Type, Type>> _map;

        public MvvmGroups(Dictionary<string, Tuple<Type, Type, Type>> map)
        {
            _moudule = new MVVMGroups();
            this._map = map;
        }

        private MVVMGroup FindGroup(string name)
        {
            return _moudule.FindGroup(name);
        }




        UIPanel IGroups.FindPanel(string name)
        {
            var group = FindGroup(name);
            if (group == null) return null;
            return (group.view as UIView).panel;
        }
        bool IGroups.Subscribe(UIPanel panel)
        {
            var _group = FindGroup(panel.name);
            if (_group != null) {
                Log.E(string.Format("Have Subscribe Panel Name: {0} ready", panel.name));
                return false;
            } 

            Tuple<Type, Type, Type> tuple;
            _map.TryGetValue(panel.name, out tuple);
            if (tuple == null)
            {
                Log.L(string.Format("Could Not Find map with Type: {0}", panel.name));
                return false;
            } 
            var model = Activator.CreateInstance(tuple.Item1) as IModel;

            var view = Activator.CreateInstance(tuple.Item2) as UIView;
            var vm = Activator.CreateInstance(tuple.Item3) as UIViewModel;
            view.panel = panel;

            var group = new MVVMGroup(panel.name, view, vm, model);
            _moudule.AddGroup(group);
            return true;
        }
        bool IGroups.UnSubscribe(UIPanel panel)
        {
            var group = FindGroup(panel.name);
            if (group != null)
            {
                group.Dispose();
                return true;
            }
            return false;
        }
        void IDisposable.Dispose()
        {
            _moudule.Dispose();
        }


        void IGroups.OnShow(string panel)
        {
            (FindGroup(panel).view as IViewStateEventHandler).OnShow();
        }
        void IGroups.OnHide(string panel)
        {
            (FindGroup(panel).view as IViewStateEventHandler).OnHide();
        }
        void IGroups.OnClose(string panel)
        {
            (FindGroup(panel).view as IViewStateEventHandler).OnClose();
        }
        void IGroups.OnLoad(string panel)
        {
            (FindGroup(panel).view as IViewStateEventHandler).OnLoad();
        }
    }
}
