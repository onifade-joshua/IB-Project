using AppBank.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;

namespace AppBank.Pages
{
    public partial class CreateUser
    {
        [Parameter] public User User { get; set; }
        [Parameter] public EventCallback<EditContext> OnValidSubmit { get; set; }

        private async Task OnValidSubmitHandler(EditContext editContext)
        {
            if (editContext.Validate())
            {
                await OnValidSubmit.InvokeAsync(editContext);
            }
            else
            {
                Console.WriteLine("Validation error: Please fill in the right details.");
            }
        }
    }
}
