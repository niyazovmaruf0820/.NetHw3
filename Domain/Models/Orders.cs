namespace Domain.Models;

public class Orders
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public DateTime OrderDate { get; set; }
    public string? CustomerName { get; set; }
    public string? ProductName { get; set; }
    public decimal ProductPrice { get; set; }
}
