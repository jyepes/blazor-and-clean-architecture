

namespace BlazingPizza.ViewModels
{
    public class CheckoutViewModel : ICheckoutViewModel
    {
        readonly ICheckoutModel Model;
        readonly IOrderStateService OrderStateService;
        public CheckoutViewModel(ICheckoutModel model, 
            IOrderStateService orderSteteService )
        {
            Model = model;
            OrderStateService = orderSteteService;
        }
        public bool IsSubmitting { get; private set; }

        public Order Order => OrderStateService.Order;

        public async Task<int> PlaceOrderAsync()
        {
            IsSubmitting = true;
            int OrderId = await Model.PlaceOrderAsync(Order);
            OrderStateService.ResetOrder();
            IsSubmitting = false;
            return OrderId;
        }
    }
}
