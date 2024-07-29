using AppBank.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBank.Interfaces
{
    public interface ICoreAccountService
    {
        Task<bool> AddNewCustomerId(string newCustomerId);
        Task<List<Account>> GetAccountsByCustomerId(string customerId);
        Task<List<string>> GetUserCustomerIds();
        Task<bool> CreateUser(User user);
    }
}
