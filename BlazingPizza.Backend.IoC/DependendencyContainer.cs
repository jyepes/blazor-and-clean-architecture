namespace BlazingPizza.Backend.IoC;
public static class DependendencyContainer
{
    public static IServiceCollection AddBlazingPizzaBackendServices(
        this IServiceCollection services, string connectionString,
        string imagesBaseUrlName)
    {
        services.AddUseCasesServices()
            .AddRepositoriesServices(connectionString)
            .AddControllersServices()
            .AddPresentersServices(imagesBaseUrlName);

        return services;
    }
}
