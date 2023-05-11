using System;

namespace FriendStorage.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Copyright => $"Copyrights by Friends @{DateTime.Now.Year}";
    }
}
