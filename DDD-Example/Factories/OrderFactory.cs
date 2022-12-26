using DDD_Example.Aggregates.Order;
using DDD_Example.Repositories.Order;

namespace DDD_Example.Factories;

public class OrderFactory
{
    private readonly AddressRepository _addressRepository;
    private readonly OrderItemRepository _itemRepository;
    private readonly OrderRepository _orderRepository;
    private readonly OrderStatusRepository _orderStatusRepository;

    public OrderFactory(AddressRepository addressRepository, OrderItemRepository itemRepository,
        OrderRepository orderRepository, OrderStatusRepository orderStatusRepository)
    {
        _addressRepository = addressRepository;
        _itemRepository = itemRepository;
        _orderRepository = orderRepository;
        _orderStatusRepository = orderStatusRepository;
    }

    public OrderRoot CreateOrder(Guid orderId)
    {
        var order = _orderRepository.GetOrderById(orderId);
        var items = _itemRepository.GetItemsByOrderId(orderId);
        var orderStatuses = _orderStatusRepository.GetOrderStatusByOrderId(orderId);
        var addresses = _addressRepository.GetAddressesByOrderId(orderId);
        return new OrderRoot
        {
            Order = order,
            Items = items,
            Statuses = orderStatuses,
            Addresses = addresses
        };
    }
}