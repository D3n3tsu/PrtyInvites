using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponce
    {
        [Required(ErrorMessage ="Please, enter your neme!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="PLease enter your email address.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="PLease enter a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify weather you'll attend")]
        public bool? WillAttend { get; set; }
    }
}