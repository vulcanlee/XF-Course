using PrismUnityApp4.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using MonoTouch.Foundation;
//using MonoTouch.UIKit;


[assembly: Xamarin.Forms.Dependency(typeof(WhoAreYou))]
namespace PrismUnityApp4.iOS
{
    public class WhoAreYou : IWhoAreYou
    {
        public string Hello()
        {
            return "§Ú¬O iOS";
        }
    }
}