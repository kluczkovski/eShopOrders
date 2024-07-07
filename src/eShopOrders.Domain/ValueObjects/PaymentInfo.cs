namespace eShopOrders.Domain.ValueObjects;

public record PaymentInfo(string CardNumber, string FullName, string ExpirationDate, string Cvv)
{
}
