using DDD_Example.Aggregates.Buyer;

namespace DDD_Example.Repositories.Buyer;

public class CardTypeRepository
{
    public ICollection<CardType> GetCardTypesByBuyerId(Guid buyerId)
    {
        // simulate DB call
        return new List<CardType>()
        {
            new()
            {
                Condition = Condition.Plastic,
                Vendor = Vendor.Visa
            }
        };
    }
}