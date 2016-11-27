using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Events;

namespace XFNaviService.ViewModels
{
    public class NaviDemoHomePageViewModel : BindableBase, INavigationAware
    {

        public DelegateCommand 導航到第1頁Command { get; set; }
        public DelegateCommand 深度導航到第123頁Command { get; set; }
        public DelegateCommand 深度導航到Navi第123頁Command { get; set; }
        public DelegateCommand 修正深度導航到第123頁Command { get; set; }

        private readonly INavigationService _navigationService;
        public NaviDemoHomePageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;

            導航到第1頁Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Sub1Page");
            });
            深度導航到第123頁Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Sub1Page/Sub2Page/Sub3Page");
            });
            深度導航到Navi第123頁Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("NaviPage/Sub1Page/Sub2Page/Sub3Page");
            });
            修正深度導航到第123頁Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Sub1Page?Auto=Sub2Page");
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
