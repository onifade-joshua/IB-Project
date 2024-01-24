using AppBank.Components;
using AppBank.Models;
using Microsoft.AspNetCore.Components;

namespace AppBank.Pages
{
    public partial class AddAccount
    {
        [Parameter]
        public User user { get; set; } = new User();
        private IEnumerable<User> users;
        private Wizard wizard;
        private List<WizardStep> wizardSteps;

        public AddAccount()
        {
        }

        private void AddCustomerId()
        {
            user.AddedCustomerIds.Add(user.CustomerId);
            user.CustomerId = 0;
        }

        private void ShowCustomerID()
        {
            foreach (var addedCustomerId in user.AddedCustomerIds)
            {
                Console.WriteLine($"Added Customer ID: {addedCustomerId}");
                // Or display it in a user interface element
            }
        }

        private void AddCustomerIdAction()
        {
            user.CustomerIds.Add(user.CustomerId);
            user.CustomerId = 0;
        }

        private void ShowCustomerIDAction()
        {
            foreach (var addedCustomerId in user.CustomerIds)
            {
                Console.WriteLine($"Added Customer ID: {addedCustomerId}");
            }
        }
    }
}
