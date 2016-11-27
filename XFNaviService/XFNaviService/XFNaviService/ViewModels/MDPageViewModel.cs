using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Events;
using XFNaviService.Models;

namespace XFNaviService.ViewModels
{
    public class MDPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand 絕對導航切換到頁面2Command { get; set; }
        public DelegateCommand 絕對導航2切換到頁面2Command { get; set; }
        public DelegateCommand 在MD頁面中切換到頁面2Command { get; set; }
        public DelegateCommand 在導航頁面中切換到頁面2Command { get; set; }

        private readonly IEventAggregator _eventAggregator;
        private readonly INavigationService _navigationService;
        public MDPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            _navigationService = navigationService;

            // 你可以分辨出，在導航抽屜(MasterDetail)頁面中，這些導航功能的差異嗎?請說明這些運作情況。
            // 並且嘗試是否可以在導航之後，回到上一頁面
            在MD頁面中切換到頁面2Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("Sub2Page");
            });
            在導航頁面中切換到頁面2Command = new DelegateCommand( () =>
            {
                _eventAggregator.GetEvent<NeedNavigation>().Publish("Sub2Page");
            });
            絕對導航切換到頁面2Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("xf:///MDPage/NaviPage/Sub2Page");
            });
            絕對導航2切換到頁面2Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("xf:///NaviPage/Sub2Page");
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
