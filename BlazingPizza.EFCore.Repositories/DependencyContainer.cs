namespace BlazingPizza.EFCore.Repositories;
public static class DependencyContainer
{
    public static IServiceCollection AddRepositoriesServices(
        this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContext<BlazingPizzaContext>(options =>
        options.UseSqlServer(connectionString));

        services.AddScoped<IBlazingPizzaQueriesRepository, BlazingPizzaQueriesRepository>();

        return services;
    }
}
