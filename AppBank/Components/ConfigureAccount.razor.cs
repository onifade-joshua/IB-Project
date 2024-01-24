using AppBank.Models;

namespace AppBank.Components
{
	public partial class ConfigureAccount
	{
		public List<Account> Accounts { set; get; } = new List<Account>();
        public ConfigureAccount()
        {
            Accounts.Add(new Account());
            Accounts.Add(new Account());
        }
    }
}
