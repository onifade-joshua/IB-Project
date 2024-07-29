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
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Phone Number is required.")]
        [RegularExpression(@"^\+[1-9]\d{1,14}$", ErrorMessage = "PhoneNo should start with a country code and be followed by 10-14 digits.")]
        public string PhoneNo { get; set; } = string.Empty;
        [Required(ErrorMessage = "No of account is required")]
        public int NoOfAccount { get; set; }
        public string Action { get; set; } = string.Empty;
        [Required(ErrorMessage = "Memorable word is required")]
        public string MemorableWord { get; set; } = string.Empty;
        [Required(ErrorMessage = "Delivery method is required")]
        public string DeliveryMethod { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public string AccountName { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string AccountNo { get; set; } = string.Empty;
        public List<int> CustomerIds { get; set; } = new List<int>();
        public string SelectedCustomerId { get; set; } = string.Empty;
        public List<int> AddedCustomerIds { get; set; } = new List<int>();
        public string Selected { get; set; } = string.Empty;
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
