namespace eShopOrders.Domain.ValueObjects;

public record DeliveryAddress(string Street, string Number, string City, string State, string ZipCode)
{
}
