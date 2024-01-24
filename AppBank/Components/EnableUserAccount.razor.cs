using AppBank.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;

namespace AppBank.Components
{
	public partial class EnableUserAccount
	{
		public string SelectedOption { get; set; }
		[Parameter] public User User { get; set; }
		[Parameter] public EventCallback<EditContext> OnValidSubmit { get; set; }

		private async Task OnValidSubmitHandler(EditContext editContext)
		{
			await OnValidSubmit.InvokeAsync(editContext);
		}
	}
}
