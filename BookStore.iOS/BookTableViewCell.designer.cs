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

namespace BookStore.iOS
{
    [Register ("BookTableViewCell")]
    partial class BookTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbAuthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbPublisher { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbYear { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lbAuthor != null) {
                lbAuthor.Dispose ();
                lbAuthor = null;
            }

            if (lbName != null) {
                lbName.Dispose ();
                lbName = null;
            }

            if (lbPublisher != null) {
                lbPublisher.Dispose ();
                lbPublisher = null;
            }

            if (lbYear != null) {
                lbYear.Dispose ();
                lbYear = null;
            }
        }
    }
}