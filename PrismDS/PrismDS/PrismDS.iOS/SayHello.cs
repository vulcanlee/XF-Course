using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PrismDS.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(SayHello))]
namespace PrismDS.iOS
{
    public class SayHello : ISayHello
    {
        public string Hello()
        {
            return "I am iOS";
        }
    }
}