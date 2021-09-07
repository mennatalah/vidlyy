using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyy.ViewModels;
using System.Data.Entity;
using vidlyy.Models;

namespace vidlyy.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(m=>m.MemberShipType).ToList();
            return View(customers);
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null) return HttpNotFound();
            var createCustomerViewModel = new CreatCustomerModelView() { 
                Customer = customer,
                MemberShipTypes = _context.MemberShipTypes.ToList()
            };

            return View("New", createCustomerViewModel);
        }
        public ActionResult New()
        {
            var memberships = _context.MemberShipTypes.ToList();
            var CustomerViewModel = new CreatCustomerModelView() { MemberShipTypes=memberships };

            return View(CustomerViewModel);
        }
        public ActionResult Info(int id)
        {
            var customers = _context.Customers.Include(m => m.MemberShipType).FirstOrDefault(i => i.Id == id);

            if (customers==null)
                return HttpNotFound();


            return View(customers);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);

            }
            else
            {
                var c = _context.Customers.Find(customer.Id);
                c.Name = customer.Name;
                c.MemberShipTypeId = customer.MemberShipTypeId;
                c.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                c.Bithdate = customer.Bithdate;
            }          
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}