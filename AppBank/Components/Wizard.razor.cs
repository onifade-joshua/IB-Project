using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using AppBank.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace AppBank.Components
{
	public partial class Wizard
	{
        [Parameter] public List<WizardStep> Steps { get; set; }
        public int ActiveIndex { get; private set; } = 0;

        private bool prevDisabled => ActiveIndex == 0;
        private bool nextDisabled => !ValidateForm();

        private WizardStep CurrentStep => Steps[ActiveIndex];

        public async Task Next()
        {
            if (!nextDisabled)
            {
                if (ActiveIndex < Steps.Count - 1)
                {
                    ActiveIndex++;
                    StateHasChanged();
                }
                else
                {
                    Console.WriteLine("Step's completed!");
                }
            }
        }

        public void Previous()
        {
            if (ActiveIndex > 0)
            {
                ActiveIndex--;
            }
        }

        private bool ValidateForm()
        {
            var editContext = new EditContext(CurrentStep.Model);

            // Check if the form is valid
            if (!editContext.Validate())
            {
                // If the form is not valid, display validation messages
                editContext.OnValidationStateChanged += (sender, eventArgs) =>
                {
                    StateHasChanged();
                };
                return false;
            }

            // Check if there are any required fields that are empty
            foreach (var prop in CurrentStep.Model.GetType().GetProperties())
            {
                if (prop.GetCustomAttributes(typeof(RequiredAttribute), true).Length > 0)
                {
                    var value = prop.GetValue(CurrentStep.Model);
                    if (value == null || (value is string && string.IsNullOrWhiteSpace((string)value)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
