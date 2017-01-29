using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp1.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }



        #region PageTitle
        private string _PageTitle;
        /// <summary>
        /// PageTitle
        /// </summary>
        public string PageTitle
        {
            get { return this._PageTitle; }
            set { this.SetProperty(ref this._PageTitle, value); }
        }
        #endregion


        public DelegateCommand 顯示抽屜Command { get; private set; }

        private readonly IEventAggregator _eventAggregator;
        public MainPageViewModel(IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            顯示抽屜Command = new DelegateCommand(()=>
            {
                // 透過 Prism 事件聚合器，發出事件，要求顯示導航抽屜面板
                // 這是一個很重要的技巧，可以讓您不同的 ViewModel  或者不同頁面，進行溝通
                _eventAggregator.GetEvent<OpenDrawer>().Publish(true);
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";

            PageTitle = "這是子頁面";
        }
    }
}
