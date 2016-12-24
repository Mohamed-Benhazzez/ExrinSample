using Android.App;
using Android.Content.PM;
using Android.OS;
using Exrin.Framework;
using Xamarin.Forms;

namespace ExrinSample.Droid
{
    [Activity(Label = "ExrinSample.Droid", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MainTheme", LaunchMode = LaunchMode.SingleTop)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Exrin.Framework.App.Init(new PlatformOptions() { Platform = Device.OS.ToString() });
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

