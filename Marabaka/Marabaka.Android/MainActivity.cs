using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using PanCardView.Droid;
using Plugin.CurrentActivity;

namespace Marabaka.Droid
{
    [Activity(Label = "Marabaka", Icon = "@mipmap/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, WindowSoftInputMode = SoftInput.AdjustResize, LaunchMode = LaunchMode.SingleTop, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetTheme(Resource.Style.MainTheme);

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            UserDialogs.Init(() => CrossCurrentActivity.Current.Activity);
            //Xamarin.Forms.Forms.SetFlags("CarouselView_Experimental");

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            CardsViewRenderer.Preserve();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}