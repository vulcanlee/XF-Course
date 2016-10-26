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

            _eventAggregator.GetEvent<OpenDrawer>().Subscribe(
                (s) =>
                {
                    IsPresented = s;
                });
        }
    }
}
