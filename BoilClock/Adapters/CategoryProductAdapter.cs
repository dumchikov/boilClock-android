using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using BoilClock.Models;
using Com.Bumptech.Glide;

namespace BoilClock.Adapters
{
    public class CategoryProductAdapter : ArrayAdapter<ProductListItem>
    {
        private readonly Activity _activity;

        public CategoryProductAdapter(Activity activity, IList<ProductListItem> products)
            :base(activity, 0, products)
        {
            _activity = activity;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = GetItem(position);

            var view = convertView ?? 
                _activity.LayoutInflater.Inflate(Resource.Layout.CategoryProductListItem, parent, false);

            var imageView = view.FindViewById<ImageView>(Resource.Id.imageView1);
            Glide.With(_activity).Load(item.Image).Into(imageView);

            var textView = view.FindViewById<TextView>(Resource.Id.textView1);
            textView.SetText(item.Name, TextView.BufferType.Normal);

            return view;
        }
    }
}