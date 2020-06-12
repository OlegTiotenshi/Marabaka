using Marabaka.UI;
using Xamarin.Forms;

namespace Marabaka
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DialogService.Init(this);
            //DataServices.Init();

            NavigationService.Init(Pages.HomeTabbed);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
