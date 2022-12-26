using DDD_Example.Factories;
using DDD_Example.Repositories.Buyer;
using DDD_Example.Repositories.Order;

var buyerRepository = new BuyerRepository();
var cardTypeRepository = new CardTypeRepository();
var paymentMethodRepository = new PaymentMethodRepository();

var addressRepository = new AddressRepository();
var itemRepository = new OrderItemRepository();
var orderRepository = new OrderRepository();
var orderStatusRepository = new OrderStatusRepository();

var buyerFactory = new BuyerFactory(buyerRepository, cardTypeRepository, paymentMethodRepository);
var orderFactory = new OrderFactory(addressRepository, itemRepository, orderRepository, orderStatusRepository);

var buyer = buyerFactory.CreateBuyer(Guid.NewGuid());
var order = orderFactory.CreateOrder(Guid.NewGuid());