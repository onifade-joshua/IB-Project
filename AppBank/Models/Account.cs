using System.ComponentModel.DataAnnotations;

namespace AppBank.Models
{
	public class Account
	{
		[Required]
		public long CustomerID { get; set; }
		[Required]
		public string AccountType { get; set; } = String.Empty;
		[Required]
		public string ProductType { get; set; } = String.Empty;
		[Required]
		public string Permission { get; set; } = String.Empty;
		[Required]
		public string AccountLimit { get; set; } = string.Empty;
		[Required]
		public string AccountStatus { get; set; } = string.Empty;
		[Required]
		public string Currency { get; set; } = String.Empty;
	}
}
