using Android.App;
using Android.Content.PM;
using Android.OS;

namespace ExrinSample.Droid
{
    [Activity(Label = "ExrinSample.Droid", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MainTheme", LaunchMode = LaunchMode.SingleTop)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Exrin.Framework.App.Init();
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

