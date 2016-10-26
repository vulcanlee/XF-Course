using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidLab
{
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

            TextView fooTextView = FindViewById<TextView>(Resource.Id.textviewYourName);
            EditText fooEditText = FindViewById<EditText>(Resource.Id.edittextYourName);

            fooTextView.Text = "";

            button.Click += delegate
            {
                fooTextView.Text = fooEditText.Text;
            };
        }
    }
}

