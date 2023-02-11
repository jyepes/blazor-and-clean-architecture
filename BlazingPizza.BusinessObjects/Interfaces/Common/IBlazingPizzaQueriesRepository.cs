namespace BlazingPizza.BusinessObjects.Interfaces.Common;
public interface IBlazingPizzaQueriesRepository
{
    Task<IReadOnlyCollection<PizzaSpecial>> GetSpecialsAsync();
    Task<IReadOnlyCollection<Topping>> GetToppingsAsync();
}
