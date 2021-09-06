using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidlyy.Models;

namespace vidlyy.ViewModels
{
    public class Customers
    {
        public List<Customer> customers { get; set; }

        public Customers()
        {
            customers = new List<Customer> {
                new Customer { Id=1,Name="johan"},
                new Customer{Id=2,Name="Mosh"}
            };
        }
    }
}