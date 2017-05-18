using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext(); 
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //[Route("customers")]
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        //[Route("customers/details/{id}")]
        public ActionResult Details(int  id)
        {

            var customers = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customers == null)
            {
                return HttpNotFound();
            }
            
            return View(customers);
        }
    }
}