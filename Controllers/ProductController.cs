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
        Product t = new Product();
        string sql = @"
            SELECT [ProductId],
                   [Description],
                   [CreatedAt],
                   [ProductLabel]
                       FROM [takpos].[dbo].[Products]";
        IEnumerable<Product> products = _dapper.LoadData<Product>(sql, t);
        return products;
    }
    // [HttpPost("AddProduct")]
    // public IActionResult AddProduct(Product products)
    // {
    //     // string sql = 
    // }
}






