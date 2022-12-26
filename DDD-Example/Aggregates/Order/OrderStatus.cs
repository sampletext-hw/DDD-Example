namespace DDD_Example.Aggregates.Order;

public class OrderStatus
{
    public bool IsPayed { get; set; }

    public DeliveryStatus DeliveryStatus { get; set; }
}

public enum DeliveryStatus
{
    Assembly = 1,
    Delivery = 2,
    Delivered = 3
}