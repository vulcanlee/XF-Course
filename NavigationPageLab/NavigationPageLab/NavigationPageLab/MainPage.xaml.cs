using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationPageLab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnPage1.Clicked += (s, e) =>
            {
                //使用這種方式切換頁面，為何無法回到上一頁
                App.Current.MainPage = new Page1();
            };
            btnNaviPage1.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new Page1());
            };
        }
    }
}
