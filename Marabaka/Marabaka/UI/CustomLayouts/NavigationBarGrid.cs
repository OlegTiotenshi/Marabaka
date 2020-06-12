using Xamarin.Forms;

namespace Marabaka.UI.CustomLayouts
{
    public class NavigationBarGrid : Grid
    {
        public static readonly BindableProperty DegreeOfViewProperty = BindableProperty.Create(
            nameof(DegreeOfView),
            typeof(double),
            typeof(NavigationBarGrid),
            defaultValue: 2.0,
            propertyChanged: CountOfView_PropertyChanged);

        public double DegreeOfView
        {
            get => (double)GetValue(DegreeOfViewProperty);
            set => SetValue(DegreeOfViewProperty, value);
        }

        public NavigationBarGrid()
        {
            HeightRequest = 41;
            MinimumHeightRequest = 41;
            Padding = new Thickness(16, 0);
            ColumnSpacing = 0;
            RowSpacing = 0;
            BackgroundColor = (Color)Application.Current.Resources["secondColor"];

            CountOfView_PropertyChanged(this, null, null);
        }

        private static void CountOfView_PropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var layout = (bindable as NavigationBarGrid);
            layout.ColumnDefinitions.Clear();

            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(layout.DegreeOfView, GridUnitType.Star) });
            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            layout.RowDefinitions.Add(new RowDefinition { Height = 40 });
            layout.RowDefinitions.Add(new RowDefinition { Height = 1 });

            BoxView separator = new BoxView()
            {
                Style = (Style)Application.Current.Resources["SeparatorLine"],
                Margin = new Thickness(-16, 0),
                VerticalOptions = LayoutOptions.End
            };
            layout.Children.Add(separator, 0, 1);
            SetColumnSpan(separator, 3);
        }
    }
}
