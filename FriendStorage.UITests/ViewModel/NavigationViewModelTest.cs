using FriendStorage.UI.ViewModel;
using Xunit;

namespace FriendStorage.UITests.ViewModel
{
    public class NavigationViewModelTest
    {
        [Fact]
        public void ShouldLoadFriends()
        {
            var viewModel = new NavigationViewModel();
            viewModel.Load();
            Assert.Equal(9, viewModel.Friends.Count);
        }
    }
}
