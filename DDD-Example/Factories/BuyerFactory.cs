using DDD_Example.Aggregates.Buyer;
using DDD_Example.Repositories.Buyer;

namespace DDD_Example.Factories;

public class BuyerFactory
{
    private readonly BuyerRepository _buyerRepository;
    private readonly CardTypeRepository _cardTypeRepository;
    private readonly PaymentMethodRepository _paymentMethodRepository;

    public BuyerFactory(BuyerRepository buyerRepository, CardTypeRepository cardTypeRepository,
        PaymentMethodRepository paymentMethodRepository)
    {
        _buyerRepository = buyerRepository;
        _cardTypeRepository = cardTypeRepository;
        _paymentMethodRepository = paymentMethodRepository;
    }

    public BuyerRoot CreateBuyer(Guid buyerId)
    {
        var buyer = _buyerRepository.GetById(buyerId);
        var cardTypes = _cardTypeRepository.GetCardTypesByBuyerId(buyerId);
        var paymentMethods = _paymentMethodRepository.GetPaymentMethodsByBuyerId(buyerId);
        return new BuyerRoot()
        {
            Buyer = buyer,
            CardTypes = cardTypes,
            PaymentMethods = paymentMethods
        };
    }
}