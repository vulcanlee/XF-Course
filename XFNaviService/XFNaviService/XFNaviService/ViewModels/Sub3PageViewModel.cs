using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace XFNaviService.ViewModels
{
    public class Sub3PageViewModel : BindableBase, INavigationAware
    {
        #region OnNavigationToLog
        private string _OnNavigationToLog = "OnNavigatedTo: ";
        /// <summary>
        /// OnNavigationToLog
        /// </summary>
        public string OnNavigationToLog
        {
            get { return this._OnNavigationToLog; }
            set { this.SetProperty(ref this._OnNavigationToLog, value); }
        }
        #endregion


        public DelegateCommand 回上一頁Command { get; set; }

        private readonly INavigationService _navigationService;
        public Sub3PageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;

            回上一頁Command = new DelegateCommand(async () =>
            {
                await _navigationService.GoBackAsync();
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Auto"))
            {
                var isAuto = parameters["Auto"] as string;
                var Next = "";
                await _navigationService.NavigateAsync($"{isAuto}");
            }

            OnNavigationToLog += Environment.NewLine + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
