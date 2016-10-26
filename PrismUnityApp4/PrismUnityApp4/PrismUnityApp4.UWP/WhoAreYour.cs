using PrismUnityApp4.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: Xamarin.Forms.Dependency(typeof(WhoAreYour))]
namespace PrismUnityApp4.UWP
{
    public class WhoAreYour : IWhoAreYou
    {
        public string Hello()
        {
            return "我是 UWP";
        }
    }
}
