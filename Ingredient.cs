namespace PocoConsoleApp
{
    public class Ingredient
    {
        public double unit_price;
        public string conversion_type;
        public double conversion_factor;
        
        public Ingredient(double Unit_price, string Conversion_type, double Conversion_factor)
        {
          unit_price = Unit_price;
          conversion_type = Conversion_type;
          conversion_factor = Conversion_factor;
        }

    }
}