using System;

namespace SAPLib
{
    public class SayHello
    {
        public static string Hello()
        {
            //在這裡使用條件式的編譯符號，定義各平台下要執行的程式碼，您可以透過左上角的下來選單，進行切換
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

