using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContentPagePrism.ViewModels
{
    /// <summary>
    /// 使用 MVVM 的方式來開發，因此，所有該頁面中的商業邏輯與C#程式碼，都會寫在這個 ViewModel 中
    /// 原則上，ViewModel 並不知道是哪個頁面正在使用它
    /// </summary>
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #region 是否啟用(用來控制頁面上的按鈕，是否可以使用)
        private bool _是否啟用 = true;
        /// <summary>
        /// 是否啟用
        /// </summary>
        public bool 是否啟用
        {
            get { return this._是否啟用; }
            set
            {
                this.SetProperty(ref this._是否啟用, value);
                // 在這裡，發出通知事件，告知這個 ICommand 是否可以被啟用的狀態有變更了
                切換到新頁面Command.RaiseCanExecuteChanged();
            }
        }
        #endregion

        private readonly INavigationService _navigationService;
        public DelegateCommand 切換到新頁面Command { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            // 在這裡透過建構式注入方法，注入了 Prism 的導航物件，透過這個物件，您就可以在 Xamarin.Forms中進行，頁面導航的操作
            _navigationService = navigationService;
            //在這裡設定當這個 ICommand 是否可以被執行的委派方法和當這個命令要執行的時候，要執行的委派方法
            切換到新頁面Command = new DelegateCommand(切換到新頁面, Can切換到新頁面);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
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
        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
