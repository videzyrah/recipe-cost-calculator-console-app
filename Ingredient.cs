namespace PocoConsoleApp
{
    public class Ingredient
    {
        public string ingredient_name;
        public double unit_price;
        public string conversion_type;
        public double conversion_factor;
        
        public Ingredient(string name, double Unit_price, string Conversion_type, double Conversion_factor)
        {
          ingredient_name = name;
          unit_price = Unit_price;
          conversion_type = Conversion_type;
          conversion_factor = Conversion_factor;
        }

    }
}