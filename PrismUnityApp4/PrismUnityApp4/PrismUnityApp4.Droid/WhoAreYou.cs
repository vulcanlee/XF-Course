using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PrismUnityApp4.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(WhoAreYou))]
namespace PrismUnityApp4.Droid
{
    public class WhoAreYou : IWhoAreYou
    {
        public string Hello()
        {
            return "§Ú¬O Android";
        }
    }
}