using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);

        }

        //[Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }

        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers>
            {
                new Customers { Id = 1, Name = "Gizen Mutlu" },
                new Customers { Id = 2, Name = "Yılmaz Korucu" },
                new Customers { Id = 3, Name = "Deneme deneme" },
                new Customers { Id = 4, Name = "DEneme 555" }
            };
        }


    }
}
