// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSLab
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnOK { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblYourName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtYourName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnOK != null) {
                btnOK.Dispose ();
                btnOK = null;
            }

            if (lblYourName != null) {
                lblYourName.Dispose ();
                lblYourName = null;
            }

            if (txtYourName != null) {
                txtYourName.Dispose ();
                txtYourName = null;
            }
        }
    }
}