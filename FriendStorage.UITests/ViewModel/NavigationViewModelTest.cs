using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using FriendStorage.UI.ViewModel;
using Xunit;

namespace FriendStorage.UITests.ViewModel
{
    public class NavigationViewModelTest
    {
        [Fact]
        public void ShouldLoadFriends()
        {
            var viewModel = new NavigationViewModel(new NavigationDataProviderMock());
            viewModel.Load();
            Assert.Equal(2, viewModel.Friends.Count);

            var friend = viewModel.Friends.SingleOrDefault(f => f.Id == 1);
            Assert.NotNull(friend);
            Assert.Equal("Guru", friend.DisplayMember);
        }

        [Fact]
        public void ShouldLoadFriendsOnlyOnce()
        {
            var viewModel = new NavigationViewModel(new NavigationDataProviderMock());
            viewModel.Load();
            viewModel.Load();
            Assert.Equal(2, viewModel.Friends.Count);

            var friend = viewModel.Friends.SingleOrDefault(f => f.Id == 1);
            Assert.NotNull(friend);
            Assert.Equal("Guru", friend.DisplayMember);
        }
    }

    public class NavigationDataProviderMock : INavigationDataProvider
    {
        public IEnumerable<LookUpItem> GetAllFriends()
        {
            yield return new LookUpItem { Id = 1, DisplayMember = "Guru" };
            yield return new LookUpItem { Id = 2, DisplayMember = "Ram" };
        }
    }
}
