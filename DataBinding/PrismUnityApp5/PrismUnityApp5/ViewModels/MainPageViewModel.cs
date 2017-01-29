using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrismUnityApp5.ViewModels
{
    public class MyItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public MySubItem MySubItemData { get; set; }
    }

    public class MySubItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        #region MyItemObject
        private MyItem _MyItemObject;
        /// <summary>
        /// MyItemObject
        /// </summary>
        public MyItem MyItemObject
        {
            get { return this._MyItemObject; }
            set { this.SetProperty(ref this._MyItemObject, value); }
        }
        #endregion


        #region MyItemList
        private ObservableCollection<MyItem> myItemList;
        /// <summary>
        /// MyItemList
        /// </summary>
        public ObservableCollection<MyItem> MyItemList
        {
            get { return myItemList; }
            set { SetProperty(ref myItemList, value); }
        }
        #endregion


        public Dictionary<string, int> Dict { get; set; }

        // ?????????????????????????????????????????????????????????????????????????????????????????????????????????
        // 使用建構式與OnNavigatedTo來建立這個 ViewModel 的資料初始化工作，有何不同，請試著比較說明看看
        // ?????????????????????????????????????????????????????????????????????????????????????????????????????????

        public MainPageViewModel()
        {
            // 這些資料初始化的相關工作，您也可以使用 OnNavigatedTo 來做到
            MyItemObject = new MyItem
            {
                 FirstName = "Main FirstName",
                 MySubItemData = new MySubItem
                 {
                      FirstName = "Sub Firstname",
                 }
            };

            MyItemList = new ObservableCollection<MyItem>();
            MyItemList.Add(new MyItem() { FirstName = "FN1", LastName = "LN1" });
            MyItemList.Add(new MyItem() { FirstName = "FN2", LastName = "LN2" });
            MyItemList.Add(new MyItem() { FirstName = "FN3", LastName = "LN3" });

            Dict = new Dictionary<string, int>();
            Dict.Add("item1", 100);
            Dict.Add("item2", 120);
            Dict.Add("item3", 140);
            Dict.Add("item4", 160);

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
