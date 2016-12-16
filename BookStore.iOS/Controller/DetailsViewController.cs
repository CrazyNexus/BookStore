using Foundation;
using System;
using UIKit;

namespace BookStore.iOS
{
   public partial class DetailsViewController : UIViewController
   {
      public Book bookData;

      public DetailsViewController(IntPtr handle) : base(handle)
      {
      }

      public override void ViewWillAppear(bool animated)
      {
         base.ViewWillAppear(animated);

         lbBookName.Text = bookData.name;
         ivBook.Image = UIImage.FromFile(bookData.imagePath);
      }
   }
}