using BlazingPizza.BusinessObjects.ValueObjects;
using BlazingPizza.Frontend.IoC;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingPizza.WinFormsClient;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        RegisterServices();
    }

    void RegisterServices()
    {
        IServiceCollection Services= new ServiceCollection();
        Services.AddWindowsFormsBlazorWebView();

        IConfiguration Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();


        Services.AddBlazingPizzaFrontendServices(
            Configuration.GetSection("BlazingPizzaEndpoints")
            .Get<EndpointsOptions>());

        blazorWebView1.HostPage = "wwwroot\\index.html";
        blazorWebView1.Services = Services.BuildServiceProvider();
        blazorWebView1.RootComponents.Add<App>(
            "#app");
    }
}
