using Foundation;
using System;
using UIKit;

namespace BookStore.iOS
{
   public partial class BookTableViewCell : UITableViewCell
   {
      private Book bookData;
      public Book BookData
      {
         get { return bookData; }
         set
         {
            bookData = value;

            lbAuthor.Text = bookData.author;
            lbName.Text = bookData.name;
            lbYear.Text = bookData.year.ToString();
            lbPublisher.Text = bookData.editor;
         }
      }

      public BookTableViewCell(IntPtr handle) : base(handle)
      {
      }
   }
}