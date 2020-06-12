using Marabaka.Helpers;

namespace Marabaka.BL.Models
{
    public class FollowerModel : Bindable
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Avatar { get; set; }
        public bool IsFollow
        {
            get => Get<bool>();
            set => Set(value);
        }
    }
}
