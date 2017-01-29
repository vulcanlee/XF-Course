using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidLab
{
    //這個專案讓您練習如何使用 Xamarin.Android工具，透過 原生 Android  API，建立一個原生 Android 應用程式
    [Activity(Label = "AndroidLab", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            //找出這個 Activity 上面有興趣的 Widget
            TextView fooTextView = FindViewById<TextView>(Resource.Id.textviewYourName);
            EditText fooEditText = FindViewById<EditText>(Resource.Id.edittextYourName);

            //設定標籤文字成為空字串
            fooTextView.Text = "";

            //訂閱按鈕事件
            button.Click += delegate
            {
                fooTextView.Text = fooEditText.Text;
            };
        }
    }
}

