using System.ComponentModel.DataAnnotations;

namespace AppBank.Models
{
    public class User
    {
        [Required]
        public string FirstName { get; set; } = String.Empty;
        [Required]
        public string LastName { get; set; } = String.Empty;
        [Required]
        public string MiddleName { get; set; } = String.Empty;
        [Required]
        public string Email { get; set; } = String.Empty;
        [Required]
        public long PhoneNo { get; set; }
        [Required]
        public string Username { get; set; } = String.Empty;
        [Required]
        public int NoOfAccount { get; set; }
        [Required]
        public string Action { get; set; } = String.Empty;
        [Required]
        public string MemorableWord { get; set; } = String.Empty;
        [Required]
        public string DeliveryMethod { get; set; } = String.Empty;
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string AccountName { get; set; } = String.Empty;
        [Required]
        public string Currency { get; set; } = String.Empty;
        [Required]
        public string AccountNo { get; set; } = String.Empty;
        [Required]
        public List<int> CustomerIds { get; set; } = new List<int>();
        [Required]
        public string SelectedCustomerId { get; set; } = String.Empty;
        [Required]
        public List<int> AddedCustomerIds { get; set; } = new List<int>();
        [Required]
        public string Selected { get; set; } = String.Empty;
        [Required]
        public string SelectedOption { get; set; } = String.Empty;

        // Properties from the Account class
        public string AccountType { get; set; } = String.Empty;
        public string ProductType { get; set; } = String.Empty;
        public string Permission { get; set; } = String.Empty;
        public string AccountLimit
        {
            get; set;
        } = String.Empty;
    }
}
