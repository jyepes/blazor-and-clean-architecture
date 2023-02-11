namespace BlazingPizza.UseCases.PlaceOrder
{
    public class PlaceOrderInteractor : IPlaceOrderInputPort
    {
        readonly IBlazingPizzaCommandsRepository Repository;
        public PlaceOrderInteractor(IBlazingPizzaCommandsRepository repository)
        {
            Repository = repository;
        }
        public async Task<int> PlaceorderAsync(PlaceOrderOrderDto order)
        {
            return await Repository.PlaceOrderAsync(order);
        }
    }
}
