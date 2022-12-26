namespace DDD_Example.Aggregates.Buyer;

public class BuyerRoot
{
    public Buyer Buyer { get; set; }

    public ICollection<CardType> CardTypes { get; set; }

    public ICollection<PaymentMethod> PaymentMethods { get; set; }
}