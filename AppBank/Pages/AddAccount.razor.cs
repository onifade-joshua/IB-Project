using AppBank.Interfaces;
using AppBank.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBank.Pages
{
    public partial class AddAccount
    {
        [Parameter]
        public User? User { get; set; }

        [Parameter]
        public Account Account { get; set; } = new Account();
        private List<string> CustomerIds { get; set; } = new List<string>();

        [Inject]
        public ICoreAccountService? CoreAccountService { get; set; }
        public string? SelectedCustomerId { get; set; }
        public IEnumerable<Account> AvailableUsers { get; set; } = new List<Account>();

        protected override async Task OnInitializedAsync()
        {
            var customerIds = await FetchCustomerIdsAsync();
            if (customerIds.Any())
            {
                CustomerIds = customerIds;
            }
            else
            {
                Console.WriteLine("Failed to fetch customer IDs.");
            }
        }

        private async Task<List<string>> FetchCustomerIdsAsync()
        {
            try
            {
                return await CoreAccountService.GetUserCustomerIds();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching customer IDs: {ex.Message}");
                return new List<string>();
            }
        }

        private async Task ShowCustomerIDAction()
        {
            try
            {
                if (string.IsNullOrEmpty(SelectedCustomerId))
                {
                    Console.WriteLine("Selected Customer ID is null or empty.");
                    return;
                }

                Console.WriteLine($"Fetching accounts for CustomerId: {SelectedCustomerId}");

                var accounts = await CoreAccountService.GetAccountsByCustomerId(SelectedCustomerId);

                if (accounts != null)
                {
                    AvailableUsers = accounts;
                    StateHasChanged();
                }
                else
                {
                    Console.WriteLine("No accounts returned for the selected customer ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching accounts: {ex.Message}");
            }
        }

        private async Task AddCustomerIdAction()
        {
            try
            {
                bool success = await CoreAccountService.AddNewCustomerId(Account.NewCustomerId);
                if (success)
                {
                    CustomerIds.Add(Account.NewCustomerId);
                    Account.NewCustomerId = string.Empty;
                }
                else
                {
                    Console.WriteLine("Failed to add new customer ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding customer ID: {ex.Message}");
            }
        }

        private async Task OnCustomerIdChanged(ChangeEventArgs e)
        {
            SelectedCustomerId = e.Value?.ToString();
        }
    }
}
