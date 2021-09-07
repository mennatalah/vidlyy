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

        public ActionResult New(int? id)
        {
            if (id != null)
            {

            }
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
        public ActionResult Create(CreatCustomerModelView creatCustomerModelView)
        {
            if (creatCustomerModelView.Customer == null)
                return View("New", creatCustomerModelView);
            
            _context.Customers.Add(creatCustomerModelView.Customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}