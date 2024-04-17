using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>() {
            new Customer{ Id = "1", Name = "Amar", Address = "QADSIYA" },
            new Customer{ Id = "2", Name = "Yara", Address = "ADAN" },
            new Customer{ Id = "3", Name = "OODA", Address = "KAIFAN" }
        };

        public IActionResult Index()
        {
            ViewData["data"] = customers;
            return View();
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(AddCustomerForm form)
        {
            if (!ModelState.IsValid)
            {
                
                return View(form);
            }

            var name = form.Name;
            var address = form.Address;
            customers.Add(new Customer { Name = name, Address = address });

            return RedirectToAction("Index");
        }
    }
}
