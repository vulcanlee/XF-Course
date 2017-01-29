using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp1.ViewModels
{
    public class MDPageViewModel : BindableBase
    {

        #region IsPresented
        private bool _IsPresented = false;
        /// <summary>
        /// IsPresented
        /// </summary>
        public bool IsPresented
        {
            get { return this._IsPresented; }
            set { this.SetProperty(ref this._IsPresented, value); }
        }
        #endregion


        private readonly IEventAggregator _eventAggregator;
        public MDPageViewModel(IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;

            // 訂閱一個 Prism 事件聚合器有興趣的事件，收到該事件後，則顯示導航抽屜面板
            _eventAggregator.GetEvent<OpenDrawer>().Subscribe(
                (s) =>
                {
                    IsPresented = s;
                });
        }
    }
}
