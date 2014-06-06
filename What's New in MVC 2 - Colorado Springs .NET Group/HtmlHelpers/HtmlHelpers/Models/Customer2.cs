using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HtmlHelpers.Models
{
    public class Customer2
    {
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(50, ErrorMessage = "Please enter a first name less than 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [StringLength(15, ErrorMessage = "Please enter a phone number less than 15 characters.")]
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Please enter a valid phone number format (###-###-####).")]
        public string Phone { get; set; }
    }
}