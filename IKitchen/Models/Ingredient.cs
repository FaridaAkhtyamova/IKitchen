using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IKitchen.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            Recipes = new HashSet<Recipe>();
        }
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public string IngredientCategory { get; set; }
        public ICollection<Recipe> Recipes { get; private set; }
        public Category Categories { get; private set; }
        public Fridge Fridge { get; set; }

    }
}