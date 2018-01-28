using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IKitchen.Models
{
    public class Product
    {
        public Product()
        {
            Meals = new HashSet<Meal>();
        }
        [Display(AutoGenerateField = false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime DateTimeBought { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string MeasureType { get; set; }
        public ICollection<Meal> Meals { get; private set; }
    }
}