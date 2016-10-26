using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Events;

namespace PrismUnityApp4.ViewModels
{
    public class New1PageViewModel : BindableBase, INavigationAware
    {

        #region FromLabel
        private string _FromLabel;
        /// <summary>
        /// FromLabel skdfjskdjf sdkfjsl
        /// </summary>
        public string FromLabel
        {
            get { return this._FromLabel; }
            set { this.SetProperty(ref this._FromLabel, value); }
        }
        #endregion

        public DelegateCommand 發布事件內容Command { get; private set; }

        private readonly IEventAggregator _eventAggregator;
        public New1PageViewModel(IEventAggregator eventAggregator)
        {

            _eventAggregator = eventAggregator;
            發布事件內容Command = new DelegateCommand(發布事件內容);
        }

        private void 發布事件內容()
        {
            _eventAggregator.GetEvent<EchoMessage>().Publish("我在學習 Xamarin.Forms");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Where"))
            {
                var foo1 = parameters["Where"] as string;
                var foo2 = parameters["From"] as string;

                FromLabel = $"{foo1} / {foo2}";
            } else
            {
                FromLabel = "我不知道從哪裡來";
            }
        }
    }
}
