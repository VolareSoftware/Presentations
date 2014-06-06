using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Order
    {
        public int Id { get; set; }
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
    }
}