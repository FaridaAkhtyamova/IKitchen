using IKitchen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IKitchen.Models
{
    public class Meal
    {
        public Meal()
        {
            Products = new HashSet<Product>();
        }

        [Display(AutoGenerateField = false)]
        public int ID { get; set; }
        [Display(Name = "Meal Name")]
        public string MealName { get; set; }
        [Display(Name = "Meal Type")]
        public MealTypes MealType { get; set; }
        public ICollection<Product> Products { get; set; }
    }

    public enum MealTypes { Breakfast, Lunch, Dinner, Snack, Dessert }
}