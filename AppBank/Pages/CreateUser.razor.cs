using AppBank.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using AppBank.Services;

namespace AppBank.Pages
{
    public partial class CreateUser : ComponentBase
    {
        [Parameter]
        public User User { get; set; } = new User();

        [Parameter]
        public EventCallback<EditContext> Submit{ get; set; }

        [CascadingParameter]
        private EditContext? editContext { get; set; }


        private async Task OnValidSubmit()
        {
            var result = await CoreAccountService.CreateUser(User);
            if (result)
            {
                Console.WriteLine("User created successfully");
            }
            else
            {
                Console.WriteLine("Failed to create user");
            }
        }
    }
}
