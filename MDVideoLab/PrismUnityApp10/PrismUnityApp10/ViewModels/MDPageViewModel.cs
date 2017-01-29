using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp10.ViewModels
{
    public class MDPageViewModel : BindableBase
    {
        public DelegateCommand Page1Command { get; private set; } 
        public DelegateCommand Page2Command { get; private set; }
        public DelegateCommand Page2EventCommand { get; private set; }

        private readonly IEventAggregator _eventAggregator;
        private readonly INavigationService _navigationService;
        public MDPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            _navigationService = navigationService;
            Page1Command = new DelegateCommand(async () =>
            {
                // 清空導航堆疊，使用的是絕對導航路徑
                await _navigationService.NavigateAsync("xf:///MDPage/NaviPage/APage");
            });
            Page2Command = new DelegateCommand(async () =>
            {
                // 清空導航堆疊，使用的是絕對導航路徑
                //await _navigationService.NavigateAsync(new Uri("xf:///MDPage/NaviPage/BPage", UriKind.Absolute));

                // 使用相對導航
                await _navigationService.NavigateAsync("BPage");
            });

            Page2EventCommand = new DelegateCommand( () =>
            {
                _eventAggregator.GetEvent<NaviEvent>().Publish("BPage");
            });
        }
    }
}
