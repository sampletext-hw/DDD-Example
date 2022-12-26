namespace DDD_Example.Aggregates.Order;

public class OrderRoot
{
    public Order Order { get; set; }

    public ICollection<OrderItem> Items { get; set; }

    public ICollection<OrderStatus> Statuses { get; set; }

    public ICollection<Address> Addresses { get; set; }
}