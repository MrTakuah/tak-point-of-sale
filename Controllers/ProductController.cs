using Microsoft.AspNetCore.Mvc;
using tak_point_of_sale.Models;

namespace tak_point_of_sale.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    [HttpGet("GetProducts")]
    public IEnumerable<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }
    [HttpPost("AddProduct")]
    public IActionResult AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
        return Ok();
    }
    [HttpDelete("DeleteProduct")]
    public IActionResult DeleteProduct(Guid productId)
    {
        _productRepository.DeleteProduct(productId);
        return Ok();
    }
}