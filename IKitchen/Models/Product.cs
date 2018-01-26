using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IKitchen.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime DateTimeBought { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string MeasureType { get; set; }

    }
}