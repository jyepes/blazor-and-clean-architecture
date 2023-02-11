namespace BlazingPizza.BusinessObjects.Interfaces.PlaceOrder
{
    public interface IPlaceOrderController
    {
        Task<int> PlaceorderAsync(PlaceOrderOrderDto order);
    }
}
