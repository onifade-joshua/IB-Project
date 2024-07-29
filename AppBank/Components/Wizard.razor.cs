using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBank.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace AppBank.Components
{
    public partial class Wizard : ComponentBase
    {
       
        [Parameter]
        public User User { get; set; } = new User();

        [Parameter]
        public List<WizardStep>? Steps { get; set; }

        public int ActiveIndex { get; private set; } = 0;

        private EditContext? editContext;

        private bool prevDisabled => ActiveIndex == 0;

        public WizardStep CurrentStep => Steps?[ActiveIndex] ?? throw new InvalidOperationException("Steps cannot be null");

        [Parameter]
        public EventCallback OnLastStepCompleted { get; set; }

        private bool showModal;
        
        protected override void OnInitialized()
        {
            if (Steps != null && Steps.Any())
            {
                InitializeEditContext();
            }
        }

        private void InitializeEditContext()
        {
            if (CurrentStep?.Model == null)
            {
                throw new ArgumentNullException(nameof(CurrentStep.Model), "Model cannot be null");
            }

            editContext = new EditContext(CurrentStep.Model);
            editContext.OnFieldChanged += (sender, eventArgs) => StateHasChanged();
        }

        public async Task Next()
        {
            if (editContext != null && editContext.Validate())
            {
                if (ActiveIndex < Steps.Count - 1)
                {
                    ActiveIndex++;
                    InitializeEditContext();
                    StateHasChanged();
                }
                else
                {
                    await SaveData();
                }
            }
            else
            {
                Console.WriteLine("Validation error: Please fill in the right details.");
            }
        }

        private async Task SaveData()
        {
            var result = await CoreAccountService.CreateUser(User);
            if (result)
            {
                AlertManager.Show("User created successfully. ", "Success", "lightgreen");
                Console.WriteLine("User created successfully.");
                showModal = true;
                await OnLastStepCompleted.InvokeAsync(null);
            }
            else
            {
                AlertManager.Show("Failed to create user.", "Error", "lightcoral");
                Console.WriteLine("Failed to create user.");
            }
            StateHasChanged();
        }

        public void Previous()
        {
            if (ActiveIndex > 0)
            {
                ActiveIndex--;
                InitializeEditContext();
                StateHasChanged();
            }
        }
    }
}
