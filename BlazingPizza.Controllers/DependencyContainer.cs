namespace BlazingPizza.Controllers;
public static class DependencyContainer
{
    public static IServiceCollection AddControllersServices(
        this IServiceCollection services)
    {
        services.AddScoped<IGetSpecialsController, GetSpecialsController>();
        services.AddScoped<IGetToppingsController, GetToppingsController>();
        services.AddScoped<IPlaceOrderController, PlaceOrderController>();
        return services;
    }
}
