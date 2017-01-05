using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace BoilClock.Activities
{
    [Activity(
        Label = "SplashActivity",
        MainLauncher = true, 
        Icon = "@drawable/icon",
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Splash);
        }

        protected override void OnResume()
        {
            base.OnResume();

            Task.Run(async () =>
            {
                await Task.Delay(5000);
                var intent = new Intent(Application.Context, typeof(CategoryActivity));
                StartActivity(intent);
            });
        }
    }
}