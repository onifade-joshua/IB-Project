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

        private async Task Next()
        {
            var currentStep = wizardSteps[wizard.ActiveIndex];
            var editContext = new EditContext(currentStep.Model);

            if (editContext.Validate())
            {
                wizard?.Next();
                UpdateBar();
            }
            else
            {
                Console.WriteLine("Form is not valid. Please check the input.");
            }
        }

        private bool IsValidForm()
        {
            var currentStep = wizardSteps[wizard.ActiveIndex];
            var editContext = new EditContext(currentStep.Model);
            var isValid = editContext.Validate();

            if (!isValid)
            {
                Console.WriteLine("Form is not valid. Please check the input.");
            }

            return isValid;
        }


        private void UpdateBar()
        {
            prevDisabled = wizard.ActiveIndex <= 1;
            nextDisabled = wizard.ActiveIndex >= wizardSteps.Count - 1;
        }

        private async Task OnValidSubmitHandler(EditContext editContext)
        {
            await Next();
        }
    }
}
