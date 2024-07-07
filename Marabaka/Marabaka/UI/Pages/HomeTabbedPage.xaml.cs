using Marabaka.BL.ViewModels;
using Marabaka.UI.CustomLayouts;
using Xamarin.Forms.Xaml;

namespace Marabaka.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : CustomTabbedPage
    {
        HomeTabbedViewModel viewModel;
        int lastIndex = 0;

        public HomeTabbedPage()
        {
            InitializeComponent();

            viewModel = new HomeTabbedViewModel();

            BindingContext = viewModel;

            this.CurrentPageChanged += HomeTabbedPage_CurrentPageChanged;
        }

        private void HomeTabbedPage_CurrentPageChanged(object sender, System.EventArgs e)
        {
            var i = this.Children.IndexOf(this.CurrentPage);

            if(lastIndex != i)
            {
                var oldPageIcon = ReturnIcon(lastIndex);
                var newPageIcon = ReturnIcon(i);

                this.Children[lastIndex].IconImageSource = oldPageIcon + ".png";
                this.Children[i].IconImageSource = newPageIcon + "_on.png";

                lastIndex = i;
            }
        }

        string ReturnIcon(int index)
        {
            switch (index)
            {
                case (0):
                    return "profile";
                case (1):
                    return "courses";
                case (2):
                    return "issues";
                case (3):
                    return "tv";
                case (4):
                    return "notify";
                default:
                    return "profile";
            }
        }
    }
}