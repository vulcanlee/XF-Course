﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeepLink.ViewModels
{
    public class New3PageViewModel : BindableBase, INavigationAware
    {

        private readonly INavigationService _navigationService;
        public New3PageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
        }
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
