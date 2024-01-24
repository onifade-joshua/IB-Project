using AppBank.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBank.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
