using FriendStorage.DataAccess;
using FriendStorage.UI.DataProvider;
using System;

namespace FriendStorage.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Copyright => $"Copyrights by Friends @{DateTime.Now.Year}";
        public INavigationViewModel NavigationViewModel { get; set; }

        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            NavigationViewModel = navigationViewModel;
        }

        public void Load()
        {
            NavigationViewModel.Load();
        }
    }
}
