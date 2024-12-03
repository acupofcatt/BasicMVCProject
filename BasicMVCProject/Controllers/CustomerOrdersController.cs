using BasicMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVCProject.Controllers;

public class CustomerOrdersController : Controller
{
    // GET
    public IActionResult Index()
    {
        var customer = new Customer()
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "johndoe@gmail.com",
        };

        var orders = new List<Order>()
        {
            new Order { Id = 1, ProductName = "coffee", Quantity = 3, Price = 100 },
            new Order { Id = 2, ProductName = "mug", Quantity = 6, Price = 200 }
        };
        
        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };
        
        return View(viewModel);

    }
}