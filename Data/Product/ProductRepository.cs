using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using tak_point_of_sale.Models;

namespace tak_point_of_sale.Data
{
    public class ProductRepository
    {
        private readonly DataContextDapper _dapper;

        public ProductRepository(IConfiguration config)
        {
            _dapper = new DataContextDapper(config);
        }

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
        public void AddProduct(Product product)
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

        }
        public void DeleteProduct(Guid productId)
        {
            string sql = @"
                DELETE FROM [takpos].[dbo].[Products]
                WHERE [ProductId] = @ProductId";
            _dapper.SaveData(sql, new { Productid = productId });
        }
    }
}