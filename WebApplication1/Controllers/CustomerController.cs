using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers;

        public CustomerController()
        {
          
            customers = new List<Customer>
            {
                new Customer { CivilId = "298060590995", Name = "Ahmad", Email = "87517@gmail.com", Phone = 99840840 },
                new Customer { CivilId = "308060500495", Name = "Osama", Email = "42131@gmail.com", Phone = 99587841 },
                new Customer { CivilId = "300260500495", Name = "Abdulwahab", Email = "24131@gmail.com", Phone = 96466009 }
            };
        }

        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult Details(string civilId)
        {
            var customer = customers.Find(c => c.CivilId == civilId);
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }
}
