using AppBank.Interfaces;
using AppBank.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBank.Services
{
    public class CreateUserService : ICreateUserService
    {
        public async Task<IEnumerable<User>> GetNewUserAsync()
        {
            await Task.Delay(100); 
            return new List<User>();
        }
    }
}