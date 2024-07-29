using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AppBank.Models
{
    public class Account
    {
        [Required]
        public string AccountNo { get; set; } = string.Empty;
        [Required]
        public string AccountName { get; set; } = string.Empty;
        [Required]
        public string Currency { get; set; } = string.Empty;
        //[Required]
        //public long CustomerID { get; set; }
        [Required]
        public string AccountType { get; set; } = string.Empty;
        [Required]
        public string ProductType { get; set; } = string.Empty;
        [Required]
        public string Permission { get; set; } = string.Empty;
        [Required]
        public string AccountLimit { get; set; } = string.Empty;
        [Required]
        public string AccountStatus { get; set; } = string.Empty;
        [JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }
        public string NewCustomerId { get; set; } = string.Empty;
        public List<string> CustomerIds { get; set; } = new List<string>();
        public string SelectedCustomerId { get; set; } = string.Empty;
        public bool Selected { get; set; }
    }
    public enum UserType
    {
        User,
        SuperUser,
        Admin
    }
}
