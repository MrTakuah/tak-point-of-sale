using System.Collections.Generic;

namespace tak_point_of_sale.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContextDapper _dapper;

        public OrderRepository(IConfiguration config)
        {
            _dapper = new DataContextDapper(config);
        }

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
        public void CreateOrder(Order order, string status)
        {
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
        }

    }
}

