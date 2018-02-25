using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyVidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display( Name = "Date of Birth")]
        public DateTime? Birthday { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        [Min18YearsIfAMember]
        public byte MembershipTypeId { get; set; }
    }
}