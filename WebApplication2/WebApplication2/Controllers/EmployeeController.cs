using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, FirstName = "AMAR", LastName = "J", Email = "e@example.com", Department = "IT" },
                new Employee { EmployeeId = 2, FirstName = "MAHA", LastName = "A", Email = "je@example.com", Department = "HR" },
                new Employee { EmployeeId = 3, FirstName = "HAYA", LastName = "Q", Email = "mln@example.com", Department = "Finance" }
            };

            return View(employees);
        }
    }
}