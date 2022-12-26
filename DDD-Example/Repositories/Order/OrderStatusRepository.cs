using DDD_Example.Aggregates.Order;

namespace DDD_Example.Repositories.Order;

public class OrderStatusRepository
{
    public ICollection<OrderStatus> GetOrderStatusByOrderId(Guid orderId)
    {
        return new List<OrderStatus>()
        {
            new OrderStatus()
            {
                DeliveryStatus = DeliveryStatus.Delivery,
                IsPayed = true
            }
        };
    }
}