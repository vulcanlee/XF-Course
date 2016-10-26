using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismDS.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        #region HelloText
        private string helloText;
        /// <summary>
        /// HelloText
        /// </summary>
        public string HelloText
        {
            get { return this.helloText; }
            set { this.SetProperty(ref this.helloText, value); }
        }
        #endregion

        ISayHello _SayHello;
        public MainPageViewModel(ISayHello sayHello)
        {
            _SayHello = sayHello;
            HelloText = _SayHello.Hello();
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
