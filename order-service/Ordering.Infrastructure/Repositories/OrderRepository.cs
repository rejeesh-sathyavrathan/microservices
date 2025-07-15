using Ordering.Infrastructure.Interface.Repositories;
using Ordering.Infrastructure.Persistence;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrdersDbContext _context;

        public async Task<int> AddOrderAsync(Order order, CancellationToken cancellationToken = default)
        {
            //_context.Orders.Add(order);
            //await _context.SaveChangesAsync(cancellationToken);
            return order.Id;
        }
    }
}
