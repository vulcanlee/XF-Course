using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace XFNaviService.Models
{
    public class NeedNavigation : PubSubEvent<string>
    {
    }
}
