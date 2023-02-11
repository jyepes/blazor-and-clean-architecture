namespace BlazingPizza.EFCore.Repositories.Mappers;
internal static class EntitiesMapper
{
    public static BusinessObjects.Entities.PizzaSpecial ToPizzaSpecial(
        this Repositories.Entities.PizzaSpecial pizzaSpecial) =>
        new BusinessObjects.Entities.PizzaSpecial
        {
            Id = pizzaSpecial.Id,
            Name = pizzaSpecial.Name,
            BasePrice = pizzaSpecial.BasePrice,
            Description = pizzaSpecial.Description,
            ImageUrl = pizzaSpecial.ImageUrl
        };

    public static BusinessObjects.Entities.Topping ToTopping(
        this Repositories.Entities.Topping topping) =>
        new BusinessObjects.Entities.Topping
        {
            Id = topping.Id,
            Name = topping.Name,
            Price = topping.Price
        };
}

