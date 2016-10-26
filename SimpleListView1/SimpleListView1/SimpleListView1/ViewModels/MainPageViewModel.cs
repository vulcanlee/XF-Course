using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using SimpleListView1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SimpleListView1.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #region 學生List
        private ObservableCollection<學生> _學生List;
        /// <summary>
        /// 學生List
        /// </summary>
        public ObservableCollection<學生> 學生List
        {
            get { return _學生List; }
            set { SetProperty(ref _學生List, value); }
        }
        #endregion


        #region 選擇的學生
        private 學生 _選擇的學生;
        /// <summary>
        /// 選擇的學生
        /// </summary>
        public 學生 選擇的學生
        {
            get { return this._選擇的學生; }
            set { this.SetProperty(ref this._選擇的學生, value); }
        }
        #endregion

        public readonly IPageDialogService _dialogService;
        public DelegateCommand 學生點選Command { get; private set; }
        public MainPageViewModel(IPageDialogService dialogService)
        {

            _dialogService = dialogService;
            學生List = new ObservableCollection<學生>();
            學生List.Add(new 學生
            {
                姓名 = "A",
                性別 = "女",
                年齡 = 18
            });
            學生List.Add(new 學生
            {
                姓名 = "A1",
                性別 = "男",
                年齡 = 15
            });
            學生List.Add(new 學生
            {
                姓名 = "A2",
                性別 = "男",
                年齡 = 22
            });
            學生List.Add(new 學生
            {
                姓名 = "A3",
                性別 = "女",
                年齡 = 1215
            });

            學生點選Command = new DelegateCommand(() =>
            {
                _dialogService.DisplayAlertAsync("Info", 選擇的學生.姓名, "OK");
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
