using eShopOrders.Domain.Entities;

namespace eShopOrders.Domain.Repositories;

public class IOrderRepository
{
    Task<Order> GetByAsync(Guid id)

    Task AddAsync(Order order)

    Task UpdateAsync(Order order)
}
