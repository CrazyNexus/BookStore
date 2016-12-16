
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BookStore.Droid
{
   [Activity(Label = "DetailsActivity")]
   public class DetailsActivity : Activity
   {
      TextView bookName;
      ImageView bookCoverImageView;
      Book selectedBook;

      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);
         SetContentView(Resource.Layout.Details);

         bookName = FindViewById<TextView>(Resource.Id.bookName2);
         bookCoverImageView = FindViewById<ImageView>(Resource.Id.bookCoverImageView);

         selectedBook = new Book();
         selectedBook.name = Intent.Extras.GetString("selected_book");
         selectedBook.imageId = Intent.Extras.GetInt("selected_image_id");

         bookName.Text = selectedBook.name;
         bookCoverImageView.SetImageResource(selectedBook.imageId);

      }
   }
}
