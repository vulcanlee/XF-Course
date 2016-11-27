using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFNaviService.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand 不使用MasterDetailPageCommand { get; set; }
        public DelegateCommand 使用MasterDetailPageCommand { get; set; }
        public DelegateCommand 沒有MD與NaviCommand { get; set; }

        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            沒有MD與NaviCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("NaviDemoHomePage");
            });
            不使用MasterDetailPageCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("NaviPage/NaviDemoHomePage");
            });
            使用MasterDetailPageCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("MDPage/NaviPage/NaviDemoHomePage");
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
