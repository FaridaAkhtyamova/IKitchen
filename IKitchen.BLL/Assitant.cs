using IKitchen.BLL;
using IKitchen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKitchen.BLL
{
    public class AssitantService

    {
        //private IKitchenContext repo;

        //public AssitantService()
        //{
        //    repo = new IKitchenContext();
        //}

        //public List<Recipes> SuggestDinner(Fridge fridge)
        //{
        //    var recipes = new List<Recipes>(); 
        //    if (fridge.ContainsProduct("Meat"))
        //    {
        //        /// Get all type of meats sorted by used by date
        //        var meats = fridge.Where(i => i.ProductType == "Meat").OrderByDescending(d => d.UseByDate);
        //        foreach (var meat in meats)
        //        {
        //            recipes.Add(db.Where(Recipe.Ingredient.Contains(meat)));
        //        }

        //    }
        //    else
        //    {
        //        var recipes = db.Meals.Where(m => m.LastCookedDate <= 5days && m.MealType == "Dinner")
        //    }

        public void GetPopularMeals()
        {

        }
    }
    
}