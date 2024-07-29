using AppBank;
using AppBank.Components;
using AppBank.Interfaces;
using AppBank.Models;
using AppBank.Pages;
using AppBank.Services;
using Blazorise;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICreateUserService, CreateUserService>();
builder.Services.AddScoped<AvailableAccount>();
builder.Services.AddScoped<AddAccount>();
builder.Services.AddScoped<ICoreAccountService, CoreAccountService>();
builder.Services.AddScoped<IAlertManager, AlertManager>();

builder.Services.AddHttpClient();

//Authorization service
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<CoreAccountService>();
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7027/"),
    Timeout = TimeSpan.FromSeconds(30) 
});

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();
