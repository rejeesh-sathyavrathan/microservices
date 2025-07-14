
using MediatR;
using Ordering.Application.Orders.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public IActionResult GetOrders()
        {
            // Placeholder for getting all orders
            return Ok(new[] { "Order1", "Order2" });
        }

        [HttpPost]
        public async Task<IActionResult> SubmitOrder([FromBody] AddOrderCommand command)
        {
            var orderId = await _mediator.Send(command);
            return Created($"/api/orders/{orderId}", new { Id = orderId });
        }

        [HttpPut("{id}")]
        public IActionResult ModifyOrder(int id, [FromBody] object order)
        {
            // Placeholder for modifying an order
            return Ok(order);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            // Placeholder for deleting an order
            return NoContent();
        }

        [HttpPost("{id}/cancel")]
        public IActionResult CancelOrder(int id)
        {
            // Placeholder for canceling an order
            return Ok();
        }
    }
}
