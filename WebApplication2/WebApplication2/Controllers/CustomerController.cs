using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()

        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer{ Id = "1", Name = "Amar", Address = "QADSIYA" },
                new Customer{ Id = "2", Name = "Yara", Address = "ADAN" },
                new Customer{ Id = "3", Name = "OODA", Address = "KAIFAN" }
                };

            return View(customers);
        }
    }
}
