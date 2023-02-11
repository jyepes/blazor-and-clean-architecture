namespace BlazingPizza.BusinessObjects.Interfaces.PlaceOrder
{
    public interface IPlaceOrderInputPort
    {
        Task<int> PlaceorderAsync(PlaceOrderOrderDto order);
    }
}
