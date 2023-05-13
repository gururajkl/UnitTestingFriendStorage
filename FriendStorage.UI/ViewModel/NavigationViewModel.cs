using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using System.Collections.ObjectModel;

namespace FriendStorage.UI.ViewModel
{
    public interface INavigationViewModel
    {
        void Load();
    }

    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        public ObservableCollection<LookUpItem> Friends { get; set; }
        private readonly INavigationDataProvider navigationDataProvider;

        public NavigationViewModel(INavigationDataProvider navigationDataProvider)
        {
            Friends = new ObservableCollection<LookUpItem>();
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
