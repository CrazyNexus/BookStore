using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace BookStore.Droid
{
   [Activity(Label = "BookStore.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
   public class MainActivity : ListActivity
   {
      List<Book> bookList;
      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);

         bookList = new List<Book>();

         bookList.Add(new Book()
         {
            author = "Thomas Dubiel",
            name = "Diplomarbeit",
            editor = "Hans-Jürgen Pfenning",
            year = 1996
         });
         bookList.Add(new Book()
         {
            author = "Silja Dubiel",
            name = "Regeln der Ehe",
            editor = "Mariana Schumann",
            year = 2012
         });
         bookList.Add(new Book()
         {
            author = "John Doe",
            name = "Wer bin ich?",
            editor = "John Smith",
            year = 2014
         });

         var listAdapter = new BooksAdapter(this, bookList);
         ListAdapter = listAdapter;
      }
   }

   public class Book
   {
      public long id;
      public string name;
      public string author;
      public string editor;
      public int year;

      public override string ToString()
      {
         return string.Format("{0} - {1} - {2} - {3}", this.name, this.author, this.editor, this.year);
      }
   }
}

