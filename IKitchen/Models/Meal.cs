using IKitchen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IKitchen.Models
{
    /// <summary>
    /// Meals is the history of meals taken
    /// </summary>
    public class Meal
    {
        [Display(AutoGenerateField = false)]
        public int ID { get; set; }
        [Display(Name = "Meal Type")]
        public MealTypes MealType { get; set; }
        public Recipe Recipes { get; set; }
        public DateTime MealDate { get; set; }
    }

    public enum MealTypes { Breakfast, Lunch, Dinner, Snack, Dessert }
}
