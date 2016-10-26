using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailPageLab
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            //在這裡，可以使用後置程式碼來設定 Master / Detail 頁面
            //this.Master = new Page1();
            //this.Detail = new Page2();
        }
    }
}
