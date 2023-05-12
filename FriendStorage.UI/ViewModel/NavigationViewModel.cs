using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using System.Collections.ObjectModel;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        public ObservableCollection<Friend> Friends { get; set; }
        private readonly INavigationDataProvider navigationDataProvider;

        public NavigationViewModel(INavigationDataProvider navigationDataProvider)
        {
            Friends = new ObservableCollection<Friend>();
            this.navigationDataProvider = navigationDataProvider;
        }

        public void Load()
        {
            Friends.Clear();
            foreach (var friend in navigationDataProvider.GetAllFriends())
            {
                Friends.Add(friend);
            }
        }
    }
}
