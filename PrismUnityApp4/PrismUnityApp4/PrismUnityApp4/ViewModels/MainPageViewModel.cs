using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services;
using Prism.Events;

namespace PrismUnityApp4.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #region EchoMessageLabel
        private string _EchoMessageLabel;
        /// <summary>
        /// EchoMessageLabel
        /// </summary>
        public string EchoMessageLabel
        {
            get { return this._EchoMessageLabel; }
            set { this.SetProperty(ref this._EchoMessageLabel, value); }
        }
        #endregion

        #region 你是誰Label
        private string _你是誰Label;
        /// <summary>
        /// 你是誰Label
        /// </summary>
        public string 你是誰Label
        {
            get { return this._你是誰Label; }
            set { this.SetProperty(ref this._你是誰Label, value); }
        }
        #endregion

        public DelegateCommand 顯示New1PageCommand { get; private set; }
        public DelegateCommand 深層連結Command { get; private set; }
        public DelegateCommand 顯示對話窗Command { get; private set; }
        public DelegateCommand 你是誰Command { get; private set; }

        private readonly INavigationService _navigationService;

        public readonly IPageDialogService _dialogService;
        public IWhoAreYou _IWhoAreYou;

        private readonly IEventAggregator _eventAggregator;
        public MainPageViewModel(INavigationService navigationService,
            IPageDialogService dialogService, IWhoAreYou iWhoAreYou,
            IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            _IWhoAreYou = iWhoAreYou;
            _dialogService = dialogService;
            _navigationService = navigationService;
            顯示New1PageCommand = new DelegateCommand(顯示New1Page);
            深層連結Command = new DelegateCommand(深層連結);
            顯示對話窗Command = new DelegateCommand(顯示對話窗);
            你是誰Command = new DelegateCommand(你是誰);

            _eventAggregator.GetEvent<EchoMessage>().Subscribe(EchoDeletage);
        }

        private void EchoDeletage(string obj)
        {
            EchoMessageLabel = $"{obj} ... {obj} ...{obj} ...";
        }

        /// <summary>
        /// 使用相依性服務注入技巧，取得注入的物件，並且執行該注入物件方法(會在原生系統內，使用原生API來執行)
        /// </summary>
        private void 你是誰()
        {
            你是誰Label = _IWhoAreYou.Hello();
        }

        private async void 顯示對話窗()
        {
            var foo = await _dialogService.DisplayAlertAsync("警告", "我正在學習 Xamarin.Forms", "OK", "沒有");
        }

        /// <summary>
        /// 使用 Prism 深層導航 URI，一次導航到多個頁面
        /// </summary>
        private async void 深層連結()
        {
            await _navigationService.NavigateAsync("New1Page/NaviPage/New2Page");
        }

        /// <summary>
        /// 切換到另外一個頁面，但是，需要傳遞一些參數過去
        /// </summary>
        private async void 顯示New1Page()
        {
            NavigationParameters foo = new NavigationParameters();
            foo.Add("Where", "Taiwan");
            await _navigationService.NavigateAsync("New1Page?From=台灣", foo);
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
