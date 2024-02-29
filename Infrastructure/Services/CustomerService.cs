using Domain.Models;
using Npgsql;
using Dapper;
namespace Infrastructure.Services;

public class CustomerService
{
    private string _connectionString = "Host=localhost;Port=5432;Database=.NetHw3;User id=postgres;Password=20080820";
    public List<Customers> GetCustomers()
    {
        using var connect = new NpgsqlConnection(_connectionString);
        return connect.Query<Customers>("select * from Customers").ToList();
    }
    public void AddCustomer(Customers customer)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("insert into Customers(FullName,Age)values(@fullname,@age)",customer);
    }
    public void UpdateCustomer(Customers customer)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("update Customers set FullName = @fullname,Age = @age where Id = @id",customer); 
    }
    public void DeleteCustomers(int id)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("delete from Customers where Id = @id", new {Id = id});
    }
}
