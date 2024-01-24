using AppBank.Interfaces;
using AppBank.Models;
using BlazorBootstrap;
using Microsoft.AspNetCore.Components;

namespace AppBank.Pages
{
    public partial class AwaitingApproval
    {
        private IEnumerable<User> users;
        [Inject]
        IUserService _userService { get; set; }
        protected override void OnInitialized()
        {
            users = _userService.GetUsers();
        }

        private async Task<GridDataProviderResult<User>> UsersDataProvider(GridDataProviderRequest<User> request)
        {
            return await Task.FromResult(request.ApplyTo(users));
        }

        private string text = "Action";

        private void ChangeTooltip() => text = $"Updated {DateTime.Now.ToLongTimeString()}";
    }
}
