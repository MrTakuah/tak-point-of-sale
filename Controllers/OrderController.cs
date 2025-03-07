using Microsoft.AspNetCore.Mvc;

namespace tak_point_of_sale.Controllers;

[ApiController]
[Route("[controller]")]

public class OrderController : ControllerBase
{
    DataContextDapper _dapper;

    public OrderController(IConfiguration config)
    {
        _dapper = new DataContextDapper(config);
    }
    [HttpGet("GetOrders")]
    public IEnumerable<Order> GetOrders()
    {
        string sql = @"
        SELECT 
            [OrderId],
            [BusinessDate],
            [CreatedAt],
            [Status] 
            FROM [takpos].[dbo].[Orders]";
        IEnumerable<Order> orders = _dapper.LoadData<Order>(sql);
        return orders;
    }
    [HttpPost("CreateOrder")]
    public IActionResult CreateOrder(Order order)
    {
        string status = "In-Progress";
        string sql = @"
            INSERT INTO [takpos].[dbo].[Orders]
            ([OrderId],
            [BusinessDate],
            [CreatedAt],
            [Status])
            VALUES (@OrderId,@BusinessDate,@CreatedAt,@Status)";
        order.OrderId = Guid.NewGuid();
        order.BusinessDate = DateTime.Today.Date;
        order.CreatedAt = DateTime.UtcNow;
        order.Status = status;

        _dapper.SaveData(sql, order);
        return Ok();
    }
}