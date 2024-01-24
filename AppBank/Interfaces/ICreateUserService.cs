using AppBank.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBank.Interfaces
{
    public interface ICreateUserService
    {
        Task<IEnumerable<User>> GetNewUserAsync();
    }
}
