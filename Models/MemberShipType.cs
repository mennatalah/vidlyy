using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidlyy.Models
{
    public class MemberShipType
    {
        
        public int id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte Discount { get; set; }
        public string MemberTypeName { get; set; }
    }
}