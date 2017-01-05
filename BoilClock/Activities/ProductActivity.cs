using Android.App;
using Android.OS;
using Android.Widget;
using BoilClock.Services;
using Com.Bumptech.Glide;

namespace BoilClock.Activities
{
    [Activity(Label = "ProductActivity")]
    public class ProductActivity : Activity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Product);

            var id = Intent.GetStringExtra("id");
            var product = await RestService.GetProduct(id);

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.SetText(product.Description, TextView.BufferType.Spannable);

            var imageView = FindViewById<ImageView>(Resource.Id.imageView7);
            Glide.With(this).Load(product.Image).Into(imageView);
        }
    }
}