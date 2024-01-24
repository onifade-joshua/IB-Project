using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBank.Models;
using BlazorBootstrap;

namespace AppBank.Components
{
    public partial class AvailableAccount
    {
        private IEnumerable<User> availableUsers = default!;
        private IEnumerable<User> selectedUsers = default!;

        public async Task<GridDataProviderResult<User>> AvailableUserDataProvider(GridDataProviderRequest<User> request)
        {
            Console.WriteLine("AvailableUserDataProvider called...");

            if (availableUsers is null)
                availableUsers = GetAvailableUsers();

            return await Task.FromResult(request.ApplyTo(availableUsers));
        }

        public async Task<GridDataProviderResult<User>> SelectedUserDataProvider(GridDataProviderRequest<User> request)
        {
            Console.WriteLine("SelectedUserDataProvider called...");

            if (selectedUsers is null)
                selectedUsers = GetSelectedUsers();

            return await Task.FromResult(request.ApplyTo(selectedUsers));
        }

        public IEnumerable<User> GetAvailableUsers()
        {
            return new List<User>
            {
			    new User { AccountNo = "0940353267", AccountName = "Alice John",  Currency = "USD" },
				new User { AccountNo = "0140443267", AccountName = "Motunrayo Mutiu", Currency = "EU"},
				new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
				new User { AccountNo = "6040353234", AccountName = "George Philip", Currency = "ZAR" },
				new User { AccountNo = "5040353288", AccountName = "Grace Jones", Currency = "GBP" },
				new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
				new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
				new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
				new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
				new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
				new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
				new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
				new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
				new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
			};
        }

        public IEnumerable<User> GetSelectedUsers()
        {
            return new List<User>
            {
                new User { AccountNo = "0940353267", AccountName = "Alice John",  Currency = "USD" },
                new User { AccountNo = "0140443267", AccountName = "Motunrayo Mutiu", Currency = "EU"},
                new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
                new User { AccountNo = "6040353234", AccountName = "George Philip", Currency = "ZAR" },
                new User { AccountNo = "5040353288", AccountName = "Grace Jones", Currency = "GBP" },
                new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
                new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
                new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
                new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
                new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
                new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
                new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
                new User { AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP" },
                new User { AccountNo = "6040353234",  AccountName = "George Philip", Currency = "ZAR" },
            };
        }

        public Task OnAvailableSelectedItemsChanged(HashSet<User> users)
        {
          
            return Task.CompletedTask;
        }

        public Task OnSelectedSelectedItemsChanged(HashSet<User> users)
        {
            
            return Task.CompletedTask;
        }
    }
}