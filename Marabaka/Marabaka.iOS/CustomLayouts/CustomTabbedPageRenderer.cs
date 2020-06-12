using Marabaka.iOS.CustomLayouts;
using Marabaka.UI.Pages;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HomeTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace Marabaka.iOS.CustomLayouts
{
    public class CustomTabbedPageRenderer : TabbedRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (TabBar == null)
                return;

            //TabBar.ClipsToBounds = true;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (TabBar?.Items == null)
                return;

            foreach (var uiTabBarItem in TabBar.Items)
            {
                uiTabBarItem.SetTitleTextAttributes(new UITextAttributes() { Font = UIFont.FromName("Rubik-Medium", 11) }, UIControlState.Normal);
                uiTabBarItem.SetTitleTextAttributes(new UITextAttributes() { Font = UIFont.FromName("Rubik-Medium", 11) }, UIControlState.Selected);
            }
        }
    }
}