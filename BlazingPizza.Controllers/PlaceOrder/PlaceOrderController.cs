namespace BlazingPizza.Controllers.PlaceOrder
{
    public class PlaceOrderController : IPlaceOrderController
    {
        readonly IPlaceOrderInputPort InputPort;

        public PlaceOrderController(IPlaceOrderInputPort inputPort)
        {
            InputPort = inputPort;
        }

        public async Task<int> PlaceorderAsync(PlaceOrderOrderDto order)
        {
            return await InputPort.PlaceorderAsync(order);
        }
    }
}
