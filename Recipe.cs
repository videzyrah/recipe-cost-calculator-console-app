namespace PocoConsoleApp
{
    public class Recipe
    {
        public string recipe_name;
        
        public double recipe_cost;
        
        //Using four Ingredients
        public Recipe(Ingredient var_one, Ingredient var_two, Ingredient var_three, Ingredient var_four)
        {
        //lacking conversion multiplication
         recipe_cost = var_one.unit_price + var_two.unit_price + var_three.unit_price + var_four.unit_price;
        }
    }
}