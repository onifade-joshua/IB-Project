using System;
using System.Collections.Generic;
using AppBank.Models;
using Microsoft.AspNetCore.Components;

namespace AppBank.Components
{
    public partial class Wizard
    {

        [Parameter] public List<WizardStep> Steps { get; set; }
        public int ActiveIndex { get; private set; } = 1;
        private bool prevDisabled;
        private bool nextDisabled;

        private WizardStep CurrentStep => Steps.FirstOrDefault(s => s.Index == ActiveIndex);

        public void Previous()
        {
            ActiveIndex--;
            if (ActiveIndex < 1)
            {
                ActiveIndex = 1;
            }
            UpdateBar();
        }

        public void Next()
        {
            ActiveIndex++;
            if (ActiveIndex > Steps.Count)
            {
                ActiveIndex = Steps.Count;
            }
            UpdateBar();
        }

        private void UpdateBar()
        {
            foreach (var step in Steps)
            {
                step.IsActive = step.Index == ActiveIndex;
            }    // To Add logic to update UI elements based on ActiveIndex
                 // For example, update the active class for the navigation steps.
            StateHasChanged();
        }

    }
}