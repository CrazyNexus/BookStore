using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace BookStore.iOS
{
   public partial class BooksTableViewController : UITableViewController
   {
      List<Book> bookList;

      public BooksTableViewController(IntPtr handle) : base(handle)
      {
         bookList = new List<Book>();

         bookList.Add(new Book()
         {
            author = "Thomas Dubiel",
            name = "Diplomarbeit",
            editor = "Hans-Jürgen Pfenning",
            year = 1996,
            imagePath = "Images/Bild1.JPG"
         });
         bookList.Add(new Book()
         {
            author = "Silja Dubiel",
            name = "Regeln der Ehe",
            editor = "Mariana Schumann",
            year = 2012,
            imagePath = "Images/Bild2.JPG"
         });
         bookList.Add(new Book()
         {
            author = "John Doe",
            name = "Wer bin ich?",
            editor = "John Smith",
            year = 2014,
            imagePath = "Images/Bild3.JPG"
         });
      }

      public override nint NumberOfSections(UITableView tableView)
      {
         return 1;
      }

      public override nint RowsInSection(UITableView tableView, nint section)
      {
         return bookList.Count;
      }

      public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
      {
         var cell = tableView.DequeueReusableCell("bookCell", indexPath) as BookTableViewCell;
         var data = bookList[indexPath.Row];

         cell.BookData = data;

         return cell;
      }

      public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
      {
         if (segue.Identifier == "showDetails")
         {
            var controller = segue.DestinationViewController as DetailsViewController;

            var indexPath = TableView.IndexPathForSelectedRow;
            var selectedData = bookList[indexPath.Row];
            controller.bookData = selectedData;
         }
      }
   }

   public class Book
   {
      public string name;
      public string author;
      public string editor;
      public int year;
      public string imagePath;
   }
}