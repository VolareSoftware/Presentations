using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Models
{
    public class Customer
    {
        [HiddenInput(DisplayValue = true)]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [DisplayName("Customer full name")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool AllowOneClickCheckout { get; set; }
        [UIHint("OrderList")]
        public IEnumerable<Order> Orders { get; set; }

        public Customer()
        {
            this.Id = 123;
            this.Name = "Test customer";
            this.Email = "test@test.test";
            this.AllowOneClickCheckout = true;
            this.Orders = new List<Order>
                {
                    new Order { Id = 1, Amount = 123.45m },
                    new Order { Id = 2, Amount = 456.45m },
                    new Order { Id = 3, Amount = 789.45m }
                };
        }
    }
}