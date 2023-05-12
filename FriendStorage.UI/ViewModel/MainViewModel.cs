using FriendStorage.DataAccess;
using FriendStorage.UI.DataProvider;
using System;

namespace FriendStorage.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Copyright => $"Copyrights by Friends @{DateTime.Now.Year}";
        public NavigationViewModel NavigationViewModel { get; set; }

        public MainViewModel()
        {
            NavigationViewModel = new NavigationViewModel(new NavigationDataProvider(
                () => new FileDataService()));
        }

        public void Load()
        {
            NavigationViewModel.Load();
        }
    }
}
