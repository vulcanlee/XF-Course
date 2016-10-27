using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace DeepLink.ViewModels
{
    public class NewMPageViewModel : BindableBase, INavigationAware
    {

        private readonly INavigationService _navigationService;
        public NewMPageViewModel(INavigationService navigationService)
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
                _navigationService.NavigateAsync(isAuto);
            }
        }
    }
}
