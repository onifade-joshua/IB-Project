using AppBank.Models;

namespace AppBank.Interfaces
{
    public interface ICoreAccountService
    {
        Task<List<Account>> GetAccountsByCustomerId(string customerId);
    }
}
