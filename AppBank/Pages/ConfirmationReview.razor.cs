using AppBank.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace AppBank.Pages
{
    public partial class ConfirmationReview
    {
        private User selectedUser;
        private List<UserAccount> selectedUserAccounts = new List<UserAccount>();

        [Parameter]
        public User User
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                OnSelectedUserChanged();
            }
        }

        private void OnSelectedUserChanged()
        {
            selectedUserAccounts = GetUserAccounts(selectedUser);
        }

        private List<UserAccount> GetUserAccounts(User user)
        {
            return new List<UserAccount>();
        }


		private List<User> GetStaticUserData()
		{
			return new List<User>
	        {
		        new User { FirstName = "Alice", LastName = "John", AccountNo = "0940353267", AccountName = "Alice John", Currency = "USD", AccountType = "Savings", ProductType = "Basic", Permission = "Declined", AccountLimit = "10000" },
		        new User { FirstName = "Motunrayo", LastName = "Mutiu", AccountNo = "0140443267", AccountName = "Motunrayo Mutiu", Currency = "EU", AccountType = "Checking", ProductType = "Premium", Permission = "Approved", AccountLimit = "50000" },
		        new User { FirstName = "Grace", LastName = "Jones", AccountNo = "5040353288",  AccountName = "Grace Jones", Currency = "GBP", AccountType = "Investment", ProductType = "Gold", Permission = "Approved", AccountLimit = "100000" },
		        new User { FirstName = "George", LastName = "Philip", AccountNo = "6040353234", AccountName = "Alice John",  Currency = "ZAR", AccountType = "Checking", ProductType = "Basic", Permission = "Declined", AccountLimit = "20000" },
	        };
		}

	}
}
