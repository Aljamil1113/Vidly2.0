using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly2_0.Models;

namespace Vidly2_0.Controllers
{
    public class CustomersController : Controller
    {     
        private readonly ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var listCustomers = _context.Customers.Include(m => m.MembershipType).ToList(); ;
            return View(listCustomers);
        }

        public ActionResult Detail(int? id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if(customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}