namespace BlazingPizza.Gateways;
public static class DependencyContainer
{
    public static IServiceCollection AddBlazingPizzaWebApiGateways(
        this IServiceCollection services,
        EndpointsOptions endpointsOptions,
        Action<IHttpClientBuilder> httpClientConfigurator = null)
    {
        IHttpClientBuilder Builder =
            services.AddHttpClient<IBlazingPizzaWebApiGateway,
            BlazingPizzaWebApiGateway>(httpClient =>
            {
                httpClient.BaseAddress = new Uri(endpointsOptions.WebApiBaseAddress);
                return new BlazingPizzaWebApiGateway(httpClient, endpointsOptions);
            });

        httpClientConfigurator?.Invoke(Builder);

        return services;
    }
}
