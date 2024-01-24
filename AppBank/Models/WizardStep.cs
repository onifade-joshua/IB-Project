using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace AppBank.Models
{
    public class WizardStep
    {
		[Required]
		public int Index { get; set; }
		[Required]
		public string Title { get; set; } = String.Empty;

		public RenderFragment? Content { get; set; }
		public bool IsActive { get; set; }
		[Required]
		public bool ShowTitleInContent { get; set; } = true;
		[Required]
		public bool User { get; internal set; }
    }
}
