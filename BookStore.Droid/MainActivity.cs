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

         ListView.ItemClick += ListView_ItemClick;

         bookList = new List<Book>();

         bookList.Add(new Book()
         {
            author = "Thomas Dubiel",
            name = "Diplomarbeit",
            editor = "Hans-Jürgen Pfenning",
            year = 1996,
            imageId = Resource.Drawable.Bild1
         });
         bookList.Add(new Book()
         {
            author = "Silja Dubiel",
            name = "Regeln der Ehe",
            editor = "Mariana Schumann",
            year = 2012,
            imageId = Resource.Drawable.Bild2
         });
         bookList.Add(new Book()
         {
            author = "John Doe",
            name = "Wer bin ich?",
            editor = "John Smith",
            year = 2014,
            imageId = Resource.Drawable.Bild3
         });

         var listAdapter = new BooksAdapter(this, bookList);
         ListAdapter = listAdapter;
      }

      void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
      {
         if (e != null)
         {
            var selectedBook = bookList[e.Position];
            var intent = new global::Android.Content.Intent(this, typeof(DetailsActivity));

            Bundle bundle = new Bundle();
            bundle.PutString("selected_book", selectedBook.name);
            bundle.PutInt("selected_image_id", selectedBook.imageId);

            intent.PutExtras(bundle);

            StartActivity(intent);
         }
         else
         {
            return;
         }
      }
   }

   public class Book
   {
      public long id;
      public string name;
      public string author;
      public string editor;
      public int year;
      public int imageId;

      public override string ToString()
      {
         return string.Format("{0} - {1} - {2} - {3}", this.name, this.author, this.editor, this.year);
      }
   }
}

