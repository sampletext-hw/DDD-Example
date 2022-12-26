using DDD_Example.Aggregates.Order;

namespace DDD_Example.Repositories.Order;

public class OrderItemRepository
{
    public ICollection<OrderItem> GetItemsByOrderId(Guid orderId)
    {
        // simulate DB call

        return new List<OrderItem>()
        {
            new()
            {
                Name = "RTX 4090",
                Amount = 1
            },
            new()
            {
                Name = "i9 13900K",
                Amount = 1
            }
        };
    }
}