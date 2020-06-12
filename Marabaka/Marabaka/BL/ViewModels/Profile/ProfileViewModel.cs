using System.Windows.Input;

namespace Marabaka.BL.ViewModels.Profile
{
    public class ProfileViewModel : BaseViewModel
    {
        public int SelectedFilterId
        {
            get => Get<int>();
            set => Set(value);
        }

        public ICommand SelectedFilterCommand => MakeCommand(async () =>
        {
        });

        public ICommand GoToCustomizeProfilePageCommand => MakeCommand(async () =>
        {
            await NavigateTo(Pages.CustomizeProfile, null, NavigationMode.Modal);
        });

        public ICommand GoToFollowersPageCommand => MakeCommand(async () =>
        {
            await NavigateTo(Pages.Followers, null, NavigationMode.Normal);
        });
    }
}
