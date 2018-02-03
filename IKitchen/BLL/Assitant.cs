public class Assitant
{
    public List<Recipes> SuggestDinner(Fridge fridge)
    {
        var recipes;
        if (fridge.Contains("Meat"))
{
    /// Get all type of meats sorted by used by date
var meats = fridge.Where(i => i.ProductType == "Meat").OrderByDescending(d => d.UseByDate);
foreach (var meat in meats)
{
    recipes.Add(db.Where(Recipe.Ingredient.Contains(meat)));
}

} else
{
    var recipes = db.Meals.Where(m => m.LastCookedDate <= 5days && m.MealType == "Dinner")
}

    }
    public void Popular()
    {

    }

    public bool Contains(string productType, Fridge fridge)
    {
        foreach (var products in fridge)
        {
            if (products.ProductType == productType)
                return true;
                break;
        }
        return false;
    }
}