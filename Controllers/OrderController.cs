using Microsoft.AspNetCore.Mvc;

namespace tak_point_of_sale.Controllers;

[ApiController]
[Route("[controller]")]

public class OrderController : ControllerBase
{
    private readonly IOrderRepository _orderRepository;
    public OrderController(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    [HttpGet("GetOrders")]
    public IEnumerable<Order> GetOrders()
    {
        return _orderRepository.GetOrders();  
    }

    [HttpPost("CreateOrder")]
    public IActionResult CreateOrder(Order order, string status)
    {
        _orderRepository.CreateOrder(order, status);
        return Ok();
    }
}