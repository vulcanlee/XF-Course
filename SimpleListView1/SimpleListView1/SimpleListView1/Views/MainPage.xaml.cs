using SimpleListView1.Models;
using Xamarin.Forms;

namespace SimpleListView1.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            學生 foo學生 = e.SelectedItem as 學生;
            DisplayAlert("Info", foo學生.姓名, "OK");
        }
    }
}
