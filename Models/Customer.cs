using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace vidlyy.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }

        [Display(Name="Membership type")]
        public int MemberShipTypeId { get; set; }

        [Display(Name="Date of Bith")]
        public DateTime? Bithdate { get; set; }
    }
}