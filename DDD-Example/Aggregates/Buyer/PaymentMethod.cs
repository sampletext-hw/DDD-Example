namespace DDD_Example.Aggregates.Buyer;

public class PaymentMethod
{
    public PaymentType Type { get; set; }

    public Method Method { get; set; }
}

public enum PaymentType
{
    Online = 1,
    Offline = 2
}

public enum Method
{
    Card = 1,
    Cash = 2
}