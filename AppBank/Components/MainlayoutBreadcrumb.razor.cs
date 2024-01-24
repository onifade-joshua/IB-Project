using BlazorBootstrap;
using Microsoft.AspNetCore.Components;

namespace AppBank.Components
{
    public partial class MainlayoutBreadcrumb
    {
        [Parameter] public string? CurrentPage { get; set; }

        private List<BreadcrumbItem>? NavItems { get; set; }

        protected override void OnParametersSet()
        {
            // Update NavItems based on the CurrentPage
            switch (CurrentPage)
            {
                case "/existinguser":
                    NavItems = new List<BreadcrumbItem>
                {
                    new BreadcrumbItem{ Text = "Users", Href ="/existinguser"},
                };
                    break;
                case "/createuser":
                    NavItems = new List<BreadcrumbItem>
                {
                    new BreadcrumbItem{ Text = "Users", Href ="/existinguser"},
                    new BreadcrumbItem{ Text = "New User", Href ="/createuser" },
                };
                    break;
                case "/addaccount":
                    NavItems = new List<BreadcrumbItem>
                {
                    new BreadcrumbItem{ Text = "Users", Href ="/existinguser"},
                    new BreadcrumbItem{ Text = "New User", Href ="/createuser" },
                    new BreadcrumbItem{ Text = "Add Customer ID & Accounts", Href ="/addaccount" },
                };
                    break;
                case "/confirmationreview":
                    NavItems = new List<BreadcrumbItem>
                {
                    new BreadcrumbItem{ Text = "Users", Href ="/existinguser"},
                    new BreadcrumbItem{ Text = "New User", Href ="/createuser" },
                    new BreadcrumbItem{ Text = "Add Customer ID & Accounts", Href ="/addaccount" },
                    new BreadcrumbItem{ Text = "Confirmation Review", Href ="/confirmationreview" },
                };
                    break;
                case "/confirmation":
                    NavItems = new List<BreadcrumbItem>
                {
                    new BreadcrumbItem{ Text = "Users", Href ="/existinguser"},
                    new BreadcrumbItem{ Text = "New User", Href ="/createuser" },
                    new BreadcrumbItem{ Text = "Add Customer ID & Accounts", Href ="/addaccount" },
                    new BreadcrumbItem{ Text = "Confirmation Review", Href ="/confirmationreview" },
                    new BreadcrumbItem{ Text = "Confirmation", Href ="/confirmation" },
                };
                    break;
                default:
                    // Default case for the home page or other cases
                    NavItems = new List<BreadcrumbItem>
                {
                    new BreadcrumbItem{ Text = "Dashboard", Href ="/" },
                };
                    break;
            }
        }
    }
}
