using System.ComponentModel.DataAnnotations;

namespace AppBank.Models
{
    public class User
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Middle Name is required")]
        public string MiddleName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone Number is required")]
        public long PhoneNo { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "No of account is required")]
        public int NoOfAccount { get; set; }
        [Required]
        public string Action { get; set; } = string.Empty;
        [Required(ErrorMessage = "Memorable word is required")]
        public string MemorableWord { get; set; } = string.Empty;
        [Required(ErrorMessage = "Delivery method is required")]
        public string DeliveryMethod { get; set; } = string.Empty;
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string AccountName { get; set; } = string.Empty;
        [Required]
        public string Currency { get; set; } = string.Empty;
        [Required]
        public string AccountNo { get; set; } = string.Empty;
        [Required]
        public List<int> CustomerIds { get; set; } = new List<int>();
        [Required]
        public string SelectedCustomerId { get; set; } = string.Empty;
        [Required]
        public List<int> AddedCustomerIds { get; set; } = new List<int>();
        [Required]
        public string Selected { get; set; } = string.Empty;
        [Required]
        public string SelectedOption { get; set; } = string.Empty;

        // Properties from the Account class
        public string AccountType { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string Permission { get; set; } = string.Empty;
        public string AccountLimit
        {
            get; set;
        } = string.Empty;
		public object Model { get; set; } = string.Empty;
	}
}
