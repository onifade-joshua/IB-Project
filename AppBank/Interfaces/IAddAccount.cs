using AppBank.Models;

namespace AppBank.Interfaces
{
    public interface IAddAccount
    {
        IEnumerable<User> GetUsers();
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
