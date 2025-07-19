using tak_point_of_sale;
using tak_point_of_sale.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
    void AddProduct(Product product);
    void DeleteProduct(Guid productId);

}