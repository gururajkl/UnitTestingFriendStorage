using FriendStorage.DataAccess;
using FriendStorage.Model;
using System;
using System.Collections.Generic;

namespace FriendStorage.UI.DataProvider
{
    public class NavigationDataProvider : INavigationDataProvider
    {
        private readonly Func<IDataService> dataServiceCreator;

        public NavigationDataProvider(Func<IDataService> dataServiceCreator)
        {
            this.dataServiceCreator = dataServiceCreator;
        }

        public IEnumerable<LookUpItem> GetAllFriends()
        {
            using (var dataService = dataServiceCreator())
                return dataService.GetAllFriends();
        }
    }
}
