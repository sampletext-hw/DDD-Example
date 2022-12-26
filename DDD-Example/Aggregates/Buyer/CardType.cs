namespace DDD_Example.Aggregates.Buyer;

public class CardType
{
    public Condition Condition { get; set; }

    public Vendor Vendor { get; set; }
}

public enum Condition
{
    Plastic = 1,
    Virtual = 2
}

public enum Vendor
{
    Visa = 1,
    Mastercard = 2,
    UnionPay = 3,
    Mir = 4
}