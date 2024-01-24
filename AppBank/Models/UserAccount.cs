using System.ComponentModel.DataAnnotations;

namespace AppBank.Models
{
	public class UserAccount
	{
		[Required]
		public string AccountName { get; set; } = String.Empty;
		[Required]
		public string AccountNo { get; set; } = String.Empty;
		[Required]
		public string Currency { get; set; } = String.Empty;

		// Properties from the Account class
		public string AccountType { get; set; } = String.Empty;
		[Required]
		public string ProductType { get; set; } = String.Empty;
		[Required]
		public string Permission { get; set; } = String.Empty;
		[Required]
		public string AccountLimit
		{
			get; set;
		} = String.Empty;
	}
}
