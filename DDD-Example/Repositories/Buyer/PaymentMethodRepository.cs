using DDD_Example.Aggregates.Buyer;

namespace DDD_Example.Repositories.Buyer;

public class PaymentMethodRepository
{
    public ICollection<PaymentMethod> GetPaymentMethodsByBuyerId(Guid buyerId)
    {
        // simulate DB call

        return new List<PaymentMethod>()
        {
            new()
            {
                Type = PaymentType.Online,
                Method = Method.Card
            }
        };
    }
}