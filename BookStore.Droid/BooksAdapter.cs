using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Java.Lang;

namespace BookStore.Droid
{
   public class BooksAdapter : BaseAdapter
   {
      public List<Book> books;
      Activity activity;

      public BooksAdapter(Activity activity)
      {
         books = new List<Book>();
         this.activity = activity;
      }

      public BooksAdapter(Activity activity, List<Book> books)
      {
         this.books = books;
         this.activity = activity;
      }


      public override int Count
      {
         get
         {
            return books.Count;
         }
      }

      public override global::Android.Views.View GetView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
      {
         var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.BookCell, parent, false);

         var nameLabel = view.FindViewById<TextView>(Resource.Id.bookNameTextView);
         var yearLabel = view.FindViewById<TextView>(Resource.Id.boockYearTextView);
         var authorLabel = view.FindViewById<TextView>(Resource.Id.bookAuthorTextView);
         var publisherLabel = view.FindViewById<TextView>(Resource.Id.bookPublisherTextView);

         var data = books[position];

         nameLabel.Text = data.name;
         yearLabel.Text = data.year.ToString();
         authorLabel.Text = data.author;
         publisherLabel.Text = data.editor;

         return view;
      }

      public override Java.Lang.Object GetItem(int position)
      {
         return null;
      }

      public override long GetItemId(int position)
      {
         return books[position].id;
      }

   }
}
