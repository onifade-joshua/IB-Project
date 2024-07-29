using AppBank.Interfaces;
using AppBank.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBank.Services
{
    public class UserService : IUserService
    {
        private List<User> users = new List<User>();

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            users = new List<User>
                {
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
                new User { FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNo = "1234567890", Username = "alice123", NoOfAccount = 2, Action = ":" },
                new User { FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNo = "9876543210", Username = "bob456", NoOfAccount = 1, Action = ":" },
            };
            await Task.Delay(0); 

            return users;
        }
        public IEnumerable<User> GetUsers()
        {
           
            return GetUsersAsync().Result;
        }
    }
}
