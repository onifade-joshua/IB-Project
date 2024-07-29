using AppBank.Models;
using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace AppBank.Components
{
    public partial class WizardButton
    {
        [Parameter] public EventCallback Previous { get; set; }
        [Parameter] public EventCallback Next { get; set; }
        [Parameter] public bool IsFirstStep { get; set; }
        [Parameter] public bool IsFormValid { get; set; }
        [Parameter] public string? NextButtonText { get; set; }

    }
}
