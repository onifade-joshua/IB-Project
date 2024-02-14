using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppBank.Models;
using BlazorBootstrap;
using Microsoft.Extensions.Http;
using Microsoft.AspNetCore.Components; 

namespace AppBank.Components
{
    public partial class AvailableAccount
    {
        private IEnumerable<Account> availableUsers = default!;
        private IEnumerable<Account> selectedUsers = default!;
        private readonly IHttpClientFactory httpClientFactory;
        private HttpClient httpClient;

        public AvailableAccount()
        {
            
        }

        [Inject]
        public IHttpClientFactory HttpClientFactory { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            httpClient = HttpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("https://localhost:7027/"); 
        }
        public async Task<GridDataProviderResult<Account>> AvailableUserDataProvider(GridDataProviderRequest<Account> request)
        {
            Console.WriteLine("AvailableUserDataProvider called...");

            if (availableUsers is null)
                availableUsers = await GetAvailableUsers();

            return await Task.FromResult(request.ApplyTo(availableUsers));
        }

        public async Task<GridDataProviderResult<Account>> SelectedUserDataProvider(GridDataProviderRequest<Account> request)
        {
            Console.WriteLine("SelectedUserDataProvider called...");

            if (selectedUsers is null)
                selectedUsers = await GetSelectedUsers();

            return await Task.FromResult(request.ApplyTo(selectedUsers));
        }

        public async Task<IEnumerable<Account>> GetAvailableUsers()
        {
            var response = await httpClient.GetFromJsonAsync<List<Account>>("api/Account/getbycustomerid/123456");
            return response ?? new List<Account>();
        }

        public async Task<IEnumerable<Account>> GetSelectedUsers()
        {
            var response = await httpClient.GetFromJsonAsync<List<Account>>("api/Account/getbycustomerid/123456");
            return response ?? new List<Account>();
        }
        public Task OnAvailableSelectedItemsChanged(HashSet<Account> accounts)
        {
            return Task.CompletedTask;
        }

        public Task OnSelectedSelectedItemsChanged(HashSet<Account> accounts)
        {
            return Task.CompletedTask;
        }
    }
}
