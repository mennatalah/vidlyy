using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyy.ViewModels;

namespace vidlyy.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customers customers = new Customers();
            return View(customers);
        }


        public ActionResult Info(int id)
        {
            Customers customers = new Customers();

            if (!customers.customers.Exists(i => i.Id == id))
                return HttpNotFound();


            return View(customers.customers.First(c => c.Id == id));
        }
    }
}