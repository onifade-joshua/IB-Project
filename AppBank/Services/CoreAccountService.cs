using AppBank.Interfaces;
using AppBank.Models;
using System.Text.Json;

namespace AppBank.Services
{
    public class CoreAccountService : ICoreAccountService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        public CoreAccountService(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<Account>> GetAccountsByCustomerId(string customerId)
        {
            var response = await _client.GetAsync($"api/Account/getbycustomerid{customerId}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var results = JsonSerializer.Deserialize<List<Account>>(content, _options);
            return results;
        }
    }
}
