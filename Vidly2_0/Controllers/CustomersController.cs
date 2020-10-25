using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2_0.Models;

namespace Vidly2_0.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        List<Customer> customers = new List<Customer>()
        {
           new Customer {Id = 1, Name = "John"},
           new Customer {Id = 2, Name = "Mary"}
        };
        public ActionResult Index()
        {
            var listCustomers = customers.ToList();
            return View(listCustomers);
        }

        public ActionResult Detail(int? id)
        {
            var customer = customers.Where(i => i.Id == id).FirstOrDefault();

            if(customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}