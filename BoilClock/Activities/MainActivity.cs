using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Android.App;
using Android.Widget;
using Android.OS;
using BoilClock.Services;

namespace BoilClock.Activities
{
    [Activity(Label = "BoilClock"/*, MainLauncher = true, Icon = "@drawable/icon"*/)]
    public class MainActivity : Activity
    {
        protected  override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var caterories = await RestService.GetCategories();
            var favorites = await RestService.GetFavorites();


            //var textView = FindViewById<TextView>(Resource.Id.textView1);
            //textView.SetText(t.Name, TextView.BufferType.Spannable);

            //var textView2 = FindViewById<TextView>(Resource.Id.textView2);
            //textView2.SetText(t.Recipe, TextView.BufferType.Spannable);

            //var btn = FindViewById<Button>(Resource.Id.button1);
            //btn.SetText(t.Timers.First().Description, TextView.BufferType.Spannable);
        }
    }
}

