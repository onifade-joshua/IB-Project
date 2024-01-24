using AppBank.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;

namespace AppBank.Components
{
    public partial class ConfigureUserAccount
    {
        [Parameter] public Account Account { get; set; } = new Account();

		private void OnValidSubmitHandler()
		{
			// Handle form submission logic here
		}

	}
}
