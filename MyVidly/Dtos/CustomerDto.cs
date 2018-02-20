using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyVidly.Models;

namespace MyVidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime? Birthday { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Min18YearsIfAMember]
        public byte MembershipTypeId { get; set; }
    }
}