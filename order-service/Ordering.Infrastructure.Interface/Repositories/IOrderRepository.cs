using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Interface.Repositories
{
    public interface IOrderRepository
    {
        Task<int> AddOrderAsync(Order order, CancellationToken cancellationToken = default);
        // Add more methods as needed (Get, Update, Delete, etc.)
    }
}
