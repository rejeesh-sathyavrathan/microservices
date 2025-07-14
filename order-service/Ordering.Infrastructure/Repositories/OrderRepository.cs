using Ordering.Application.Abstractions;
using Ordering.Domain.Entities;
using Ordering.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrdersDbContext _context;
        public OrderRepository(OrdersDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddOrderAsync(Order order, CancellationToken cancellationToken = default)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);
            return order.Id;
        }
    }
}
