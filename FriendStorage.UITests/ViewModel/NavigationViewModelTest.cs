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
            Assert.Equal("Guru", friend.FirstName);
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
            Assert.Equal("Guru", friend.FirstName);
        }
    }

    public class NavigationDataProviderMock : INavigationDataProvider
    {
        public IEnumerable<Friend> GetAllFriends()
        {
            yield return new Friend { Id = 1, FirstName = "Guru" };
            yield return new Friend { Id = 2, FirstName = "Ram" };
        }
    }
}
