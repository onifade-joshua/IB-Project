using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBank.Models;
using AppBank.Interfaces;
using Microsoft.AspNetCore.Components;

namespace AppBank.Components
{
    public partial class AvailableAccount
    {
        public List<Account> AvailableUsers { get; set; } = new List<Account>();
        [Parameter]
        public string SelectedCustomerId { get; set; } = default!;
        public bool DisplayTable { get; set; } = false;
        public bool SelectAll { get; set; }
        public List<Account> SelectedAccounts { get; set; } = new List<Account>();

        protected override async Task OnParametersSetAsync()
        {
            await ShowCustomerIDAction();
        }

        private async Task ShowCustomerIDAction()
        {
            try
            {
                var accounts = await CoreAccountService.GetAccountsByCustomerId(SelectedCustomerId);

                if (accounts != null)
                {
                    AvailableUsers = accounts;
                    DisplayTable = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void MoveAccounts()
        {
            var selectedAccounts = AvailableUsers.Where(a => a.Selected).ToList();
            SelectedAccounts.AddRange(selectedAccounts);
            AvailableUsers.RemoveAll(a => a.Selected);
            StateHasChanged();
        }

        private void DeleteAccounts()
        {
            SelectedAccounts.RemoveAll(a => a.Selected);
            StateHasChanged();
        }

        private void ToggleSelectAll()
        {
            foreach (var account in AvailableUsers)
            {
                account.Selected = SelectAll;
            }
            StateHasChanged();
        }

        private void ToggleSelectAllSelected()
        {
            foreach (var account in SelectedAccounts)
            {
                account.Selected = SelectAll;
            }
            StateHasChanged();
        }
    }
}
