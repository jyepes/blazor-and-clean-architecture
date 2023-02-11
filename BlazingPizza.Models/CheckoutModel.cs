namespace BlazingPizza.Models
{
    public class CheckoutModel : ICheckoutModel
    {
        public async Task<int> PlaceOrderAsync(Order order)
        {
            //TODO: Implementar
            return await Task.FromResult(0);
        }
    }
}
