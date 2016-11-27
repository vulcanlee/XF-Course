using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Events;
using Prism.Navigation;
using XFNaviService.Models;

namespace XFNaviService.ViewModels
{
    public class NaviPageViewModel : BindableBase, INavigationAware
    {

        private readonly IEventAggregator _eventAggregator;
        private readonly INavigationService _navigationService;
        public NaviPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {

            _navigationService = navigationService;

            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<NeedNavigation>().Subscribe(async x =>
            {
                await _navigationService.NavigateAsync(x);
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
