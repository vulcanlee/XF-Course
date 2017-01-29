using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeepLink.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        private readonly INavigationService _navigationService;
        public DelegateCommand 導航到一個頁面Command { get; private set; }
        public DelegateCommand 連續導航到兩個頁面Command { get; private set; }
        public DelegateCommand 連續導航到兩個頁面_但手動Command { get; private set; }
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            導航到一個頁面Command = new DelegateCommand(() =>
            {
                // 使用一個相對 URI 進行頁面導航
                _navigationService.NavigateAsync("NaviPage/New1Page");
            });
            連續導航到兩個頁面Command = new DelegateCommand(() =>
            {
                // 使用 Prism 的深度導航方法
                _navigationService.NavigateAsync("NaviPage/New1Page/New2Page/New3Page");
            });
            連續導航到兩個頁面_但手動Command = new DelegateCommand(() =>
            {
                //使用傳遞參數方式，告知下一個頁面，要自動導航到別的頁面
                _navigationService.NavigateAsync("NaviPage/New1Page?Auto=New2Page");
            });
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
