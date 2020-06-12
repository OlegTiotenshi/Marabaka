using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Marabaka.UI.CustomLayouts
{
    public class SegmentedButtonControl : Grid
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(Command), typeof(SegmentedButtonControl), default(Command));
        public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create("SelectedIndex", typeof(int), typeof(SegmentedButtonControl), default(int));

        public Command Command
        {
            get { return (Command)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Style LabelStyle { get; set; }
        public IList<Label> SegmentedButtons { get; internal set; }

        public Command ItemTapped
        {
            get
            {
                return new Command((obj) =>
                {
                    int index = (int)obj;

                    SelectedIndex = index;

                    if (Command != null)
                    {
                        Command.Execute(this.SegmentedButtons[index].Text);
                    }
                });
            }
        }

        public SegmentedButtonControl()
        {
            var segmentedButtons = new ObservableCollection<Label>();
            segmentedButtons.CollectionChanged += SegmentedButtons_CollectionChanged;
            SegmentedButtons = segmentedButtons;
            this.ColumnSpacing = 0;
            this.RowSpacing = 0;
        }

        void SegmentedButtons_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            BuildButtons();
        }

        //protected override void OnBindingContextChanged()
        //{
        //    base.OnBindingContextChanged();

        //    BuildButtons();
        //}

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == "SelectedIndex")
            {
                SetSelectedIndex();
            }
        }

        void BuildButtons()
        {
            this.ColumnDefinitions.Clear();
            this.Children.Clear();
            for (int i = 0; i < SegmentedButtons.Count; i++)
            {
                var segButton = SegmentedButtons[i];
                segButton.Style = LabelStyle;
                segButton.VerticalOptions = LayoutOptions.FillAndExpand;

                BoxView separator = new BoxView()
                {
                    VerticalOptions = LayoutOptions.End,
                    HeightRequest = 2,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };

                if (i == SelectedIndex)
                {
                    segButton.TextColor = PrimaryColor;
                    separator.BackgroundColor = PrimaryColor;
                }
                else
                {
                    segButton.TextColor = SecondaryColor;
                    separator.BackgroundColor = Color.Transparent;
                }
                    
                segButton.HorizontalTextAlignment = TextAlignment.Center;
                segButton.VerticalTextAlignment = TextAlignment.Center;

                this.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                StackLayout stackLayout = new StackLayout()
                {
                    Spacing = 0,
                    HeightRequest = 50,
                    MinimumHeightRequest = 50,
                    Padding = new Thickness(5,0)
                };

                stackLayout.Children.Add(segButton);
                stackLayout.Children.Add(separator);

                var tapGesture = new TapGestureRecognizer();
                tapGesture.Command = ItemTapped;
                tapGesture.CommandParameter = i;
                stackLayout.GestureRecognizers.Add(tapGesture);

                this.Children.Add(stackLayout, i, 0);
            }
        }

        void SetSelectedIndex()
        {
            for (int i = 0; i < Children.Count; i++)
            {
                var stackLayout = Children[i] as StackLayout;
                var label = stackLayout.Children[0] as Label;
                var separator = stackLayout.Children[1] as BoxView;

                if (i == SelectedIndex)
                {
                    label.TextColor = PrimaryColor;
                    separator.BackgroundColor = PrimaryColor;
                }
                else
                {
                    label.TextColor = SecondaryColor;
                    separator.BackgroundColor = Color.Transparent;
                }
            }
        }
    }
}
