using System;

namespace SAPLib
{
    public class SayHello
    {
        public static string Hello()
        {
#if __ANDROID__
            return "I am Android";
#elif __IOS__
            return "I am iOS";
#else
            return "I am UWP";
#endif
        }
    }
}

