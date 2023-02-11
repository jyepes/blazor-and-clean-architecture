using BlazingPizza.BusinessObjects.Dtos;

namespace BlazingPizza.BusinessObjects.Aggregates;
public class Order : BaseOrder
{
    public Order()
    {
        PizzasField = new();
    }
    readonly List<Pizza> PizzasField;

    public Address DeliveryAddress { get; private set; }
    public LatLong DeliveryLocation { get; private set; }
    public IReadOnlyCollection<Pizza> Pizzas =>
        PizzasField;

    public void AddPizza(Pizza pizza) =>
        PizzasField.Add(pizza);

    public void RemovePizza(Pizza pizza) =>
        PizzasField.Remove(pizza);

    public void SetDeliveryAddress(Address deliveryAddress) =>
        DeliveryAddress = deliveryAddress;

    public void SetDeliveryLocation(LatLong deliveryLocation) =>
        DeliveryLocation = deliveryLocation;

    public decimal GetTotalPrice() =>
        PizzasField.Sum(p => p.GetTotalPrice());

    public string GetFormattedTotalPrice() =>
        GetTotalPrice().ToString("$ #.##");

    public bool HasPizzas => Pizzas.Any();

    public static explicit operator PlaceOrderOrderDto(Order order) =>
        new PlaceOrderOrderDto
        {
            UserId = order.UserId,
            DeliveryAddress = order.DeliveryAddress,
            DeliveryLocation = order.DeliveryLocation,
            Pizzas = order.Pizzas.Select(p => (PlaceOrderPizzaDto)p).ToList()
        };
}
