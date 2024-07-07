using eShopOrders.Domain.Events;
using eShopOrders.Domain.ValueObjects;

namespace eShopOrders.Domain.Entities;

public class Order : AggregateRoot
{
    public Order(Customer customer, DeliveryAddress deliveryAddress, PaymentAddress paymentAddress, PaymentInfo paymentInfo, List<OrderItem> items)
    {
        Id  = Guid.NewGuid();
        TotalPrice = items.Sum(x => x.Price * x.Quantity);
        Customer = customer;
        DeliveryAddress = deliveryAddress;
        PaymentAddress = paymentAddress;
        PaymentInfo = paymentInfo;
        Items = items;
        CreatedAt = DateTime.UtcNow;
        OrderStatus = OrderStatus.Started;

        AddEvent(new OrderCreated(Id, TotalPrice, PaymentInfo, Customer.FullName, Customer.Email));
    }

    public decimal TotalPrice { get; set; }
    public Customer Customer { get; set; }
    public DeliveryAddress DeliveryAddress { get; set; }
    public PaymentAddress PaymentAddress { get; set; }
    public PaymentInfo PaymentInfo { get; set; }
    public List<OrderItem> Items { get; set; }
    public DateTime CreatedAt { get; set; }
    public OrderStatus OrderStatus { get; set; }

    public void SetAsCompleted(){
        OrderStatus = OrderStatus.Completed;
    }

    public void SetAsRejected() {
        OrderStatus = OrderStatus.Rejected;
    }
}
