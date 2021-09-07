using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidlyy.Models;

namespace vidlyy.ViewModels
{
    public class CreatCustomerModelView
    {
        public Customer Customer { get; set; }
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
    }
}