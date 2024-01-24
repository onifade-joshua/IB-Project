using AppBank.Interfaces;
using AppBank.Models;

namespace AppBank.Services
{
	public class AccountService : IAddAccount 
	{
        private List<User> users = new List<User>();

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
