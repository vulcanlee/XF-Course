using Prism.Commands;
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

        private readonly INavigationService _navigationService;
        public MDPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            Page1Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync(new Uri("xf:///MDPage/NaviPage/APage", UriKind.Absolute));
            });
            Page2Command = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync(new Uri("xf:///MDPage/NaviPage/BPage", UriKind.Absolute));
            });
        }
    }
}
