using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Marabaka.BL.ViewModels.Profile
{
    public class CustomizeProfileViewModel : BaseViewModel
    {
        public ObservableCollection<string> StickersList
        {
            get => Get<ObservableCollection<string>>();
            set => Set(value);
        }

        public CustomizeProfileViewModel()
        {
            StickersList = new ObservableCollection<string>()
            {
                "Yellow", "Blue", "Green", "Red", "Orange", "Purple", "Aqua",
                "Yellow", "Blue", "Green", "Red", "Orange", "Purple", "Aqua",
                "Yellow", "Blue", "Green", "Red", "Orange", "Purple", "Aqua",
            };
        }
        public ICommand PopModalCommand => MakeCommand(async () =>
        {
            await NavigateBack(NavigationMode.Modal);
        });
    }
}
