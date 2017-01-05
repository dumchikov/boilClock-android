using Android.App;
using Android.OS;
using Android.Widget;
using BoilClock.Adapters;
using BoilClock.Services;
using System.Linq;
using Android.Content;
using Android.Runtime;
using BoilClock.Helpers;
using BoilClock.Models;

namespace BoilClock.Activities
{
    [Activity(Label = "CategoryActivity")]
    public class CategoryActivity : Activity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Category);

            var id = Intent.GetIntExtra("id", 0);
            var products = await RestService.GetProductsByCategory(id);

            var gridview = (GridView) FindViewById(Resource.Id.gridview);
            var adapter = new CategoryProductAdapter(this, products.ToList());

            gridview.ItemClick += (sender, e) =>
            {
                var productActivity = new Intent(this, typeof(ProductActivity));

                var javaObject = e.Parent.GetItemAtPosition(e.Position);
                var item = javaObject.Cast<ProductListItem>();

                productActivity.PutExtra("id", item.Id);
                StartActivity(productActivity); 
            };

            gridview.Adapter = adapter;
        }
    }
}