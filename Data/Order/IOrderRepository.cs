using tak_point_of_sale;
using tak_point_of_sale.Models;

public interface IOrderRepository
{
    IEnumerable<Order> GetOrders();
    void CreateOrder(Order order, string status);
}