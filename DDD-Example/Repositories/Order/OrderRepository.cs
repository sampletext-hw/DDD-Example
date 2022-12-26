namespace DDD_Example.Repositories.Order;

public class OrderRepository
{
    public Aggregates.Order.Order GetOrderById(Guid orderId)
    {
        return new Aggregates.Order.Order()
        {
            Id = Guid.NewGuid()
        };
    }
}