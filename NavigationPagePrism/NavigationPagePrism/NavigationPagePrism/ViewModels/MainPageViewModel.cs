using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NavigationPagePrism.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }



        #region 是否啟用
        private bool _是否啟用 = true;
        /// <summary>
        /// 是否啟用
        /// </summary>
        public bool 是否啟用
        {
            get { return this._是否啟用; }
            set { this.SetProperty(ref this._是否啟用, value); 切換到新頁面Command.RaiseCanExecuteChanged(); }
        }
        #endregion

        private readonly INavigationService _navigationService;
        public DelegateCommand 切換到新頁面Command { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            切換到新頁面Command = new DelegateCommand(切換到新頁面, Can切換到新頁面);
        }

        private bool Can切換到新頁面()
        {
            return 是否啟用;
        }

        private async void 切換到新頁面()
        {
            // 這行為相對 URI ，所以，可以返回到前一頁面
            await _navigationService.NavigateAsync("NewPage");
            // 這行為相對 URI ，所以，無法返回到前一頁面
            //await _navigationService.NavigateAsync("xf:///NewPage");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
