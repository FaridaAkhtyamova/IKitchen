using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IKitchen.Models
{
    public class Recipe

    {
        public Recipe()
        {
            Ingredients = new HashSet<Ingredient>();
        }
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public RecipeCategories RecipeCategory { get; set; }
        public string SubType { get; set; }
        public ICollection<Ingredient> Ingredients { get; private set; }
    }

    public enum RecipeCategories
    {
        Soup, Side, Main, Pastry, Salad
    }
}