

using MediatR;
using Ordering.Domain.Entities;
using Ordering.Application.Abstractions;

namespace Ordering.Application.Orders.Commands
{
    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand, int>
    {
        private readonly IOrderRepository _orderRepository;

        public AddOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<int> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            // Map AddOrderCommand to domain Order entity
            var order = new Order
            {
                CustomerName = request.CustomerName,
                Items = request.Items.Select(i => new OrderItem
                {
                    Name = i.Name,
                    UnitPrice = i.UnitPrice,
                    Category = i.Category,
                    Description = i.Description
                }).ToList()
            };

            // Persist order using repository
            var orderId = await _orderRepository.AddOrderAsync(order, cancellationToken);
            return orderId;
        }
    }
}
