using Microsoft.AspNetCore.Components;

namespace AppBank.Pages
{
    public partial class Confirmation : ComponentBase
    {
        [Parameter]
        public string? Name { get; set; }

        [Parameter]
        public string? Username { get; set; }

        [Parameter]
        public string? UserEmail { get; set; }

        [Parameter]
        public string? UserPhone { get; set; }

        [Parameter]
        public EventCallback<bool> OnConfirmation { get; set; }

        private void NavigateToDashboard()
        {
            NavigationManager.NavigateTo("/dashboard");
        }
    }
}
