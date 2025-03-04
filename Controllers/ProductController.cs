using Microsoft.AspNetCore.Mvc;

namespace takpos.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{
    DataContextDapper _dapper;
    public ProductController(IConfiguration config)
    {
        _dapper = new DataContextDapper(config);
    }
    [HttpGet("GetProducts")]
    public IEnumerable<Product> GetProducts()
    {
        string sql = @"
                SELECT [ProductId],
                [Description],
                [CreatedAt],
                [ProductLabel]
                FROM [takpos].[dbo].[Products]";
        IEnumerable<Product> products = _dapper.LoadData<Product>(sql);
        return products;


    }
    [HttpPost("AddProduct")]
    public IActionResult AddProduct(Product product)
    {
        string sql = @"
                INSERT INTO [takpos].[dbo].[Products]
                ([ProductId], 
                [Description], 
                [Price],
                [ProductLabel], 
                [CreatedAt])
                VALUES (@ProductId, @Description, @Price, @ProductLabel, @CreatedAt)";

        product.ProductId = Guid.NewGuid();
        product.CreatedAt = DateTime.Now;   
        
        _dapper.SaveData(sql, product);
        return Ok();
    }
}