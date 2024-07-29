using AppBank.Interfaces;
using AppBank.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppBank.Services
{
    public class CoreAccountService : ICoreAccountService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _jsonOptions;
        private const string BaseUrl = "https://localhost:7027/";
        private const string AddCustomerPath = "api/Account/addnewcustomerid";
        private const string GetCustomerAccountPath = "api/Account/getbycustomerid/";
        private const string GetUserCustomerIdsPath = "api/Account/getusercustomerids";
        private const string CreateUserPath = "api/User/create";

        public CoreAccountService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<bool> AddNewCustomerId(string newCustomerId)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(BaseUrl);

                var response = await client.PostAsJsonAsync(AddCustomerPath, newCustomerId);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error adding new customer ID: {ex.Message}");
                return false;
            }
        }
        public async Task<List<Account>> GetAccountsByCustomerId(string customerId)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(BaseUrl);

                var response = await client.GetAsync($"{GetCustomerAccountPath}{customerId}");
                response.EnsureSuccessStatusCode();

                var accounts = await response.Content.ReadFromJsonAsync<List<Account>>(_jsonOptions);
                return accounts ?? new List<Account>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error getting accounts by customer ID: {ex.Message}");
                return new List<Account>();
            }
        }

        public async Task<List<string>> GetUserCustomerIds()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(BaseUrl);

                var response = await client.GetFromJsonAsync<List<string>>(GetUserCustomerIdsPath);
                return response ?? new List<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all customer IDs: {ex.Message}");
                return new List<string>();
            }
        }
        public async Task<bool> CreateUser(User user)
        {
            try
            {
                if (user == null)
                {
                    throw new ArgumentNullException(nameof(user), "User object is null");
                }

                var userJson = JsonSerializer.Serialize(user);
                Console.WriteLine($"Sending user data: {userJson}");
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(BaseUrl);
                var content = new StringContent(userJson, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(CreateUserPath, content);

                if (!response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error creating user: {response.StatusCode}, {responseContent}");
                    return false;
                }

                return true;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error creating user: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }
    }
}
