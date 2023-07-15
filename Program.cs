﻿using PocoConsoleApp;

   public class MainProgram
  {
    string name = "default_food_item_name";

    static void Main(string[] args)
    {
     MainProgram program= new MainProgram();

     Ingredient sandwichBun = new Ingredient(0.6, "per bun", 0.5);
     Ingredient cheeseSlice = new Ingredient(0.7, "per slice", 0.5);
     Ingredient beefPatty = new Ingredient(0.8, "per patty", 0.5);
     Ingredient tomatoSlice = new Ingredient(0.25, "per pound", 0.5);

     Recipe hamburger = new Recipe(sandwichBun, cheeseSlice, beefPatty, tomatoSlice);
     
      //Console.WriteLine(sandwichBun.conversion_type);
      Console.WriteLine("Today's hamburger cost is: $ " +  hamburger.recipe_cost);
      
    }
  }


  

  

