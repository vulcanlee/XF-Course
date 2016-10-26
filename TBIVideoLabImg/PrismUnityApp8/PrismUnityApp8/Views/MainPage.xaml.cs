using PrismUnityApp8.ViewModels;
using Xamarin.Forms;

namespace PrismUnityApp8.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            MainPageViewModel foo = this.BindingContext as MainPageViewModel;
            foo.Title = "OK";
        }
    }
}
