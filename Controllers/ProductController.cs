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
}



