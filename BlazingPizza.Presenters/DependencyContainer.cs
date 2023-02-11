﻿namespace BlazingPizza.Presenters;
public static class DependencyContainer
{
    public static IServiceCollection AddPresentersServices(
        this IServiceCollection services, string imagesBaseUrl)
    {
        services.AddScoped<IGetSpecialsPresenter>(provider =>
        new GetSpecialsPresenter(imagesBaseUrl));

        return services;
    }
}
