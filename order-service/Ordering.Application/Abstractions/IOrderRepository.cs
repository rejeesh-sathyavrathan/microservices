using Ordering.Domain.Entities;

namespace Ordering.Application.Abstractions
{
    public interface IOrderRepository
    {
        Task<int> AddOrderAsync(Order order, CancellationToken cancellationToken = default);
        // Add more methods as needed (Get, Update, Delete, etc.)
    }
}
