using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp10.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand Page2Command { get; set; }

        private readonly IEventAggregator _eventAggregator;
        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            _navigationService = navigationService;

            Page2Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("BPage");
            });

            _eventAggregator.GetEvent<NaviEvent>().Subscribe(async x =>
            {
                await _navigationService.NavigateAsync(x);
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
