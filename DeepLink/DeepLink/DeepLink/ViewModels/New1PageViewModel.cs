using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeepLink.ViewModels
{
    public class New1PageViewModel : BindableBase, INavigationAware
    {

        private readonly INavigationService _navigationService;
        public New1PageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
        }
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Auto"))
            {
                var isAuto = parameters["Auto"] as string;
                _navigationService.NavigateAsync($"{isAuto}?Auto=New3Page");
            }
        }
    }
}
