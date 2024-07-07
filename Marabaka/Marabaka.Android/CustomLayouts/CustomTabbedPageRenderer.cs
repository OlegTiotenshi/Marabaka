using Android.Content;
using Android.Graphics;
using Android.Widget;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.Internal;
using Marabaka.Droid.CustomLayouts;
using Marabaka.UI.CustomLayouts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace Marabaka.Droid.CustomLayouts
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        BottomNavigationView bottomNavigationView;

        public CustomTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.TabbedPage> e)
        {
            base.OnElementChanged(e);

            bottomNavigationView = (GetChildAt(0) as Android.Widget.RelativeLayout).GetChildAt(1) as BottomNavigationView;

            bottomNavigationView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilitySelected;
            bottomNavigationView.ItemIconTintList = null;
            bottomNavigationView.Elevation = 0;

            ChangeFont();
        }

        void ChangeFont()
        {
            var fontFace = Typeface.CreateFromAsset(Context.Assets, "Rubik-Medium.ttf");
            var bottomNavMenuView = bottomNavigationView.GetChildAt(0) as BottomNavigationMenuView;

            for (int i = 0; i < bottomNavMenuView.ChildCount; i++)
            {
                var item = bottomNavMenuView.GetChildAt(i) as BottomNavigationItemView;
                var itemTitle = item.GetChildAt(1);

                var smallTextView = ((TextView)((BaselineLayout)itemTitle).GetChildAt(0));
                var largeTextView = ((TextView)((BaselineLayout)itemTitle).GetChildAt(1));

                smallTextView.SetTypeface(fontFace, TypefaceStyle.Normal);
                smallTextView.SetTextSize(Android.Util.ComplexUnitType.Dip, 11);
                largeTextView.SetTypeface(fontFace, TypefaceStyle.Normal);
                largeTextView.SetTextSize(Android.Util.ComplexUnitType.Dip, 11);
            }
        }
    }
}