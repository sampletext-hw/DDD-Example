using DDD_Example.Aggregates.Order;

namespace DDD_Example.Repositories.Order;

public class AddressRepository
{
    public ICollection<Address> GetAddressesByOrderId(Guid orderId)
    {
        // simulate DB call

        return new List<Address>()
        {
            new()
            {
                City = "Moscow",
                Recipient = "Egop",
                Street = "Arbat"
            }
        };
    }
}