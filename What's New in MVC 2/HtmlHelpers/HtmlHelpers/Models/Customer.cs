using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HtmlHelpers.Models
{
    public class Customer
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }

        [DisplayName("Customer first name")]
        public string FirstName { get; set; }

        [DisplayName("Customer last name")]
        public string LastName { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}