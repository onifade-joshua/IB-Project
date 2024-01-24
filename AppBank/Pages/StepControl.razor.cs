using AppBank.Components;
using AppBank.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace AppBank.Pages
{
	public partial class StepControl
	{
		User User = new User();
		public Wizard wizard;
		private List<WizardStep> wizardSteps;
		private bool prevDisabled;
		private bool nextDisabled;

		private void Previous()
		{
			wizard?.Previous();
			UpdateBar();
		}

		private void NextStep()
		{
			if (IsValidForm())
			{
				wizard?.Next();
				UpdateBar();
			}
		}
		private bool IsValidForm()
		{
			// Validate the form using the EditContext
			var editContext = new EditContext(User);
			var isValid = editContext.Validate();

			// If the form is not valid, you can optionally display an error message
			if (!isValid)
			{
				// You can display an error message or perform other actions
				Console.WriteLine("Form is not valid. Please check the input.");
			}

			return isValid;
		}

		private void UpdateBar()
		{
			// Add logic to update prevDisabled and nextDisabled based on ActiveIndex
			prevDisabled = wizard.ActiveIndex <= 1;
			nextDisabled = wizard.ActiveIndex >= wizardSteps.Count;
		}
		private void HandleValidSubmit(EditContext editContext)
		{
			// Handle valid submit as needed
			// This method will be called when the user information form is submitted and valid
			NextStep();
		}
	}
}
