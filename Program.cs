using PocoConsoleApp;

   public class MainProgram
  {
    string name = "default_food_item_name";

    static void Main(string[] args)
    {
     MainProgram program= new MainProgram();

     Ingredient sandwichBun = new Ingredient("Sandwich Bun", 0.6, "$ per bun", 0.5);
     Ingredient cheeseSlice = new Ingredient("Cheese Slice", 0.7, "$ per slice", 0.5);
     Ingredient beefPatty = new Ingredient("BeefPatty", 0.8, "$ per patty", 0.5);
     Ingredient tomatoSlice = new Ingredient("Tomato Slice", 0.25, "$ per pound", 0.5);
     Ingredient blank = new Ingredient("Nothing", 0, "N/A", 0);

     
     Recipe hamburger = new Recipe(sandwichBun, cheeseSlice, beefPatty, tomatoSlice);
     Recipe grilledCheese= new Recipe(sandwichBun, cheeseSlice, blank, blank);
      
     Console.WriteLine("Today's hamburger cost is: $ " +  hamburger.recipe_cost);
     Console.WriteLine("Today's grilled cheese cost is: $ " +  grilledCheese.recipe_cost);
      
    }
  }


  

  

