namespace DDD_Example.Repositories.Buyer;

public class BuyerRepository
{
    public Aggregates.Buyer.Buyer GetById(Guid id)
    {
        // simulate DB call

        return new Aggregates.Buyer.Buyer()
        {
            Id = id,
            Age = 505,
            Name = "Egop"
        };
    }
}