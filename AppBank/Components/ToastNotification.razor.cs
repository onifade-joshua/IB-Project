using AppBank.Interfaces;
using AppBank.Services;
using Microsoft.AspNetCore.Components;

namespace AppBank.Components
{
    public partial class ToastNotification
    {
        private bool isVisible;
        private string? headerText;
        private string? bodyText;
        private string? toastColor;

        

        protected override void OnInitialized()
        {
            AlertManager.OnShow += Show;
        }

        private void Show(string message, string title, string color)
        {
            headerText = title;
            bodyText = message;
            toastColor = color;
            isVisible = true;
            StateHasChanged();
        }

        private void Close()
        {
            isVisible = false;
            StateHasChanged();
        }

        private string showClass => isVisible ? "show" : "";

        private void GoHome()
        {
            NavigationManager.NavigateTo("/dashboard");
        }
    }
}
