namespace BlazingPizza.WebApi.Endpoints;

public static class Toppings
{
    public static WebApplication UseToppingsEndpoints(
        this WebApplication app)
    {
        app.MapGet("/toppings",
            async (IGetToppingsController controller) =>
            {
                var Result = await controller.GetToppingsAsync();
                return Results.Ok(Result);
            });
        return app;
    }
}
