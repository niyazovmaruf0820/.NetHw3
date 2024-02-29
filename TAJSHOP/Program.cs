using Domain.Models;
using Infrastructure.Services;

ProductService productService = new ProductService();

System.Console.WriteLine(productService.GetQuantityOfProducts());

// Products product = new Products();
// product.Name = "IPhone SE+";
// product.Price = 2000;
// productService.AddProduct(product);

// Products product = new Products();
// product.Id = 13;
// product.Name = "IPhone SE";
// product.Price = 2000;
// productService.AddProduct(product);

// try
// {
//     productService.DeleteProducts(15);
// }
// catch 
// {
//     System.Console.WriteLine("!!!Id of this Product is used in an Order, that's why you can't delete this Product!!!");
// }

// foreach (var item in productService.GetProducts())
// {
//     System.Console.WriteLine("Id: " + item.Id);
//     System.Console.WriteLine("Name: " + item.Name);
//     System.Console.WriteLine("Price: " + item.Price);
//     System.Console.WriteLine("--------------------------------");
// }





// CustomerService customerService = new CustomerService();

// Customers customer = new Customers();
// customer.FullName = "Mumtoz Sharipov";
// customer.Age = 17;
// customerService.AddCustomer(customer);

// Customers customer = new Customers();
// customer.Id = 19;
// customer.FullName = "Mumtoz Sharipzoda";
// customer.Age = 17;
// customerService.UpdateCustomer(customer);

// try
// {
//     customerService.DeleteCustomers(1);
// }
// catch 
// {
//     System.Console.WriteLine("!!!Id of this Product is used in an Order, that's why you can't delete this Product!!!");
// }

// foreach (var item in customerService.GetCustomers())
// {
//     System.Console.WriteLine("Id: " + item.Id);
//     System.Console.WriteLine("FullName: " + item.FullName);
//     System.Console.WriteLine("Age: " + item.Age);
//     System.Console.WriteLine("-----------------------------------------");
// }





// OrderService orderService = new OrderService();

// Orders order = new Orders();
// order.ProductId = 16;
// order.CustomerId = 21;
// order.OrderDate = DateTime.Now;
// orderService.AddOrder(order);

// Orders order = new Orders();
// order.Id = 49;
// order.ProductId = 5;
// order.CustomerId = 21;
// order.OrderDate = DateTime.Now;
// orderService.AddOrder(order);

// try
// {
//     orderService.DeleteOrder(50);
// }
// catch
// {
//     System.Console.WriteLine("!!!database doesn't contains this order!!!");
// }

// foreach (var item in orderService.GetOrders())
// {
//     System.Console.WriteLine("Id : " + item.Id);
//     System.Console.WriteLine("Customer's fullname: " + item.CustomerName);
//     System.Console.WriteLine("Product's name: " + item.ProductName);
//     System.Console.WriteLine("Product's price: " + item.ProductPrice);
//     System.Console.WriteLine("---------------------------------------------------");
// }




