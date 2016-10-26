using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UserCtrlEntry.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        #region Name
        private MyEntryViewModel _Name;
        /// <summary>
        /// 這個屬性，將會用於綁定到 姓名 欄位輸入
        /// </summary>
        public MyEntryViewModel Name
        {
            get { return this._Name; }
            set { this.SetProperty(ref this._Name, value); }
        }
        #endregion


        #region ID
        private MyEntryViewModel _ID;
        /// <summary>
        /// 這個屬性，將會用於綁定到 身分證字號 欄位輸入
        /// </summary>
        public MyEntryViewModel ID
        {
            get { return this._ID; }
            set { this.SetProperty(ref this._ID, value); }
        }
        #endregion


        #region Email
        private MyEntryViewModel _Email;
        /// <summary>
        /// 這個屬性，將會用於綁定到 電子郵件 欄位輸入
        /// </summary>
        public MyEntryViewModel Email
        {
            get { return this._Email; }
            set { this.SetProperty(ref this._Email, value); }
        }
        #endregion


        public MainPageViewModel()
        {
            // 進行三個文字輸入盒要綁定的 ViewModel 的物件初始化
            Name = new MyEntryViewModel();
            Name.更新文字輸入盒的浮水印文字設定("Name");
            ID = new MyEntryViewModel();
            ID.更新文字輸入盒的浮水印文字設定("ID");
            Email = new MyEntryViewModel();
            Email.更新文字輸入盒的浮水印文字設定("Email");
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
