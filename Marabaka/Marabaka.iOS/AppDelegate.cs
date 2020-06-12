using Foundation;
using PanCardView.iOS;
using UIKit;

namespace Marabaka.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Rg.Plugins.Popup.Popup.Init();
            //Xamarin.Forms.Forms.SetFlags("CarouselView_Experimental");

            global::Xamarin.Forms.Forms.Init();

            CardsViewRenderer.Preserve();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
