using AppBank;
using AppBank.Interfaces;
using AppBank.Models;
using AppBank.Services;
using Blazorise;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICreateUserService, CreateUserService>();


builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
    Timeout = TimeSpan.FromSeconds(30) 
});

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();
