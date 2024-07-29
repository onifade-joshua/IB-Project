using AppBank.Models;
using AppBank.Components;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppBank.Interfaces;
using AppBank.Services;
using Microsoft.AspNetCore.Components.Forms;

namespace AppBank.Pages
{
    public partial class StepControl
    {
        private User User = new User();
        private EditContext editContext;
        private Wizard? wizard;
        private List<WizardStep>? wizardSteps;
        private bool prevDisabled;
        private bool nextDisabled;

        [Inject]
        public IAlertManager? AlertManager { get; set; }

        [Inject]
        public NavigationManager? NavigationManager { get; set; }

        [Inject]
        public ICoreAccountService? CoreAccountService { get; set; }

        protected override void OnInitialized()
        {
            editContext = new EditContext(User);
            wizardSteps = new List<WizardStep>
        {
            new WizardStep
            {
                Index = 0,
                Title = "Create User",
                Model = User,
                Content = (builder) =>
                {
                    builder.OpenComponent<CreateUser>(0);
                    builder.AddAttribute(1, "User", User);
                    builder.CloseComponent();
                }
            },
            new WizardStep
            {
                Index = 1,
                Title = "Add Customer ID & Account",
                Content = (builder) =>
                {
                    builder.OpenComponent<AddAccount>(0);
                    builder.AddAttribute(1, "User", User);
                    builder.CloseComponent();
                }
            },
            new WizardStep
            {
                Index = 2,
                Title = "Configure User Account",
                Content = (builder) =>
                {
                    builder.OpenComponent<ConfigureAccount>(0);
                    builder.CloseComponent();
                }
            },
            new WizardStep
            {
                Index = 3,
                Title = "Confirmation Review",
                Content = (builder) =>
                {
                    builder.OpenComponent<ConfirmationReview>(0);
                    builder.AddAttribute(1, "User", User);
                    builder.CloseComponent();
                }
            }
        };

            base.OnInitialized();
        }

        private async Task OnWizardNext()
        {
            AlertManager?.Show("User created successfully.", "Success", "lightgreen");
        }

        private void Previous()
        {
            if (wizard != null && wizard.ActiveIndex > 0)
            {
                wizard.Previous();
                UpdateBar();
            }
        }

        private async Task Next()
        {
            var currentStep = wizardSteps[wizard.ActiveIndex];
            var editContext = new EditContext(currentStep.Model);

            if (editContext.Validate())
            {
                if (wizard.ActiveIndex < wizardSteps.Count - 1)
                {
                    await wizard.Next();
                    UpdateBar();
                }
                else
                {
                    // Save to database
                    await SaveData();
                }
            }
            else
            {
                Console.WriteLine("Form is not valid. Please check the input.");
            }
        }

        private async Task SaveData()
        {
            var result = await CoreAccountService.CreateUser(User);
            if (result)
            {
                AlertManager?.Show("User created successfully.", "Success", "lightgreen");
            }
            else
            {
                AlertManager?.Show("Failed to create user.", "Error", "lightcoral");
            }
        }

        private void UpdateBar()
        {
            if (wizard != null)
            {
                prevDisabled = wizard.ActiveIndex == 0;
                nextDisabled = wizard.ActiveIndex == wizardSteps.Count - 1;
            }
        }

        private async Task OnValidSubmitHandler(EditContext editContext)
        {
            await Next();
        }
    }
}
