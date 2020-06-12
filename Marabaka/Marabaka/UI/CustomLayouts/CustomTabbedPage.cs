using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Marabaka.UI.CustomLayouts
{
    public class CustomTabbedPage : Xamarin.Forms.TabbedPage
    {
        public CustomTabbedPage()
        {
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Xamarin.Forms.PlatformConfiguration.Android>().DisableSmoothScroll();
            On<Xamarin.Forms.PlatformConfiguration.Android>().DisableSwipePaging();

            SelectedTabColor = Color.FromHex("#fff");
            UnselectedTabColor = Color.FromHex("#414651");
        }
    }
}
