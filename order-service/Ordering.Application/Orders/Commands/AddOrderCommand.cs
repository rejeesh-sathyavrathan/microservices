using MediatR;

namespace Ordering.Application.Orders.Commands
{
    public class AddOrderCommand : IRequest<int>
    {
        public string CustomerName { get; set; }
        public List<AddOrderItemDto> Items { get; set; } = new();
    }

    public class AddOrderItemDto
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
