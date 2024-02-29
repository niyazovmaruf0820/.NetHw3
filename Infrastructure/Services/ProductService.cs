using Dapper;
using Domain.Models;
using Npgsql;

namespace Infrastructure.Services;

public class ProductService
{
    private string _connectionString = "Host=localhost;Port=5432;Database=.NetHw3;User id=postgres;Password=20080820";
    public List<Products> GetProducts()
    {
        using var connect = new NpgsqlConnection(_connectionString);
        var sql = "select * from Products";
        var products = connect.Query<Products>(sql).ToList();
        return products;
        
    }
    public void AddProduct(Products product)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("insert into Products(Name,Price)values(@name,@price)",product);
    }
    public void UpdateProduct(Products product)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("update Products set Name = @name,Price = @price where Id = @id",product); 
    }
    public void DeleteProducts(int id)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        connect.Execute("delete from Products where Id = @id", new {Id = id});
    }
    public int GetQuantityOfProducts()
    {
        using var connect = new NpgsqlConnection(_connectionString);
        var sql = "select Count(*) from Products";
        var count = connect.ExecuteScalar(sql);
        return Convert.ToInt32(count);
    }
    // public int GetQuantityOfProductsg()
    // {
    //     using var connect = new NpgsqlConnection(_connectionString);
    //     var sql = "select Count(*) from Products";
    //     var count = connect.ExecuteScalar<int>(sql);
    //     return count;
    // }
    public Products GetProductById1(int id)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        var sql = "select * from Products where Id = @id";
        var product = connect.QuerySingle<Products>(sql, new {Id = id});
        return product;
    }
    public Products GetProductById2(int id)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        var sql = "select * from Products where Id = @id";
        var product = connect.QuerySingleOrDefault<Products>(sql, new {Id = id});
        return product;
    }
    public Products GetProductById3(int id)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        var sql = "select * from Products where Id >= @id";
        var product = connect.QueryFirst<Products>(sql, new {Id = id});
        return product;
    }
    public Products GetProductById4(int id)
    {
        using var connect = new NpgsqlConnection(_connectionString);
        var sql = "select * from Products where Id = @id";
        var product = connect.QueryFirstOrDefault<Products>(sql, new {Id = id});
        return product;
    }
}
