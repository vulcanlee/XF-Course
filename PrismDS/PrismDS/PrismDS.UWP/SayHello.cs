using PrismDS.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: Xamarin.Forms.Dependency(typeof(SayHello))]
namespace PrismDS.UWP
{
    public class SayHello : ISayHello
    {
        public string Hello()
        {
            return "I am UWP";
        }
    }
}
