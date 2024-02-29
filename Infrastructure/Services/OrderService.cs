using Domain.Models;
using Npgsql;
using Dapper;

namespace Infrastructure.Services;

public class OrderService
{
    private string _connectionString = "Host=localhost;Port=5432;Database=.NetHw3;User id=postgres;Password=20080820";
    public List<Orders> GetOrders()
    {
        using var connect = new NpgsqlConnection(_connectionString);
        return connect.Query<Orders>("select o.Id,c.FullName as CustomerName,p.Name as ProductName,p.Price as ProductPrice from Orders as o join Products as p on o.ProductId = p.Id join Customers as c on o.CustomerId = c.Id").ToList();
    }
    public void AddOrder(Orders order)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("insert into Orders(CustomerId,ProductId,OrderDate)values(@customerId,@productId,@orderdate)",order);
    }
    public void UpdateOrder(Orders order)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("update Orders set CustomerId = @customerId,productId = @productId,OrderDate = @orderdate where Id = @id",order); 
    }
    public void DeleteOrder(int id)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("delete from Orders where Id = @id", new {Id = id});
    }
}
