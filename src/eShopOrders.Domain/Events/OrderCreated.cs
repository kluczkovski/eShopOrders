using eShopOrders.Domain.ValueObjects;

namespace eShopOrders.Domain.Events;

public class OrderCreated : IDomainEvent 
{
    public OrderCreated(Guid id, decimal totalPrice, PaymentInfo paymentInfo, string fullName, string email)
    {
        Id = id;
        TotalPrice = totalPrice;
        PaymentInfo = paymentInfo;
        FullName = fullName;
        Email = email;
    }

    public Guid Id { get; set;}
    public decimal TotalPrice { get; set; }
    public PaymentInfo PaymentInfo { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
}
