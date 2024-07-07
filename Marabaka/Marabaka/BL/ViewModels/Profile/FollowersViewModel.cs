using Marabaka.BL.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Marabaka.BL.ViewModels.Profile
{
    public class FollowersViewModel : BaseViewModel
    {
        public int SelectedFilterId
        {
            get => Get<int>();
            set => Set(value);
        }
        public ObservableCollection<FollowerModel> FollowersList
        {
            get => Get<ObservableCollection<FollowerModel>>();
            set => Set(value);
        }

        public FollowersViewModel()
        {
            FollowersList = new ObservableCollection<FollowerModel>();
        }

        protected override async Task LoadDataAsync()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                //обращение к апи сервера
                GetFollowers();
            }
            catch (Exception ex)
            {
                //отправка краша в AppCenter
                Console.WriteLine(ex.ToString());
            }
        }

        void GetFollowers()
        {
            for (int i = 0; i < 20; i++)
            {
                var follower = new FollowerModel()
                {
                    Avatar = "avatar",
                    Name = $"Матвей {i}",
                    Rating = new Random().Next(1, 1000),
                    IsFollow = new Random().Next(2) == 0
                };
                FollowersList.Add(follower);
            }
        }

        public ICommand FollowCommand => MakeCommand((obj) =>
        {
            var profile = (FollowerModel)obj;

            profile.IsFollow = !profile.IsFollow;
        });
    }
}
