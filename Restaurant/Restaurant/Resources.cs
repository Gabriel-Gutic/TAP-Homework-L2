using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal static class Resources
    {
        // An example of encapsulation.
        // The vector of ingredients should be modified only by the function LoadIngredients
        private static Dictionary<Guid, Ingredient> s_Ingredients = new Dictionary<Guid, Ingredient>();

        public static Dictionary<Guid, Ingredient> Ingredients
        {
            get { return s_Ingredients; }
        }

        public static void LoadIngredients(string filename)
        {
            s_Ingredients = new Dictionary<Guid, Ingredient>();

            try
            {
                StreamReader streamReader = new StreamReader(filename);

                string? line = "";
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    float price = float.Parse(parts[1]);
                    Ingredient ingredient = new Ingredient(parts[0], price);
                    s_Ingredients[ingredient.ID] = ingredient;    
                }
            }
            catch (Exception e)
            { 
                Console.WriteLine("Ingredients loading failed!");
                Console.WriteLine("Exception: " + e.Message);
                Debugger.Break();
            }

            Console.WriteLine("Ingredients successfully loaded!");
            PrintIngredients();
        }

        // Print a table with all the ingredients
        public static void PrintIngredients()
        {
            Console.WriteLine("Ingredients: ");


            // Find the max length of the names for the ingredients, to make the 
            // table more beautifull
            int maxLength = 0;
            foreach (var (id, ingredient) in s_Ingredients)
            {
                if (maxLength < ingredient.Name.Length)
                {
                    maxLength = ingredient.Name.Length;
                }
            }

            foreach (var (id, ingredient) in s_Ingredients)
            {
                Console.WriteLine(ingredient.Name + new string(' ', maxLength - ingredient.Name.Length) + " | " + ingredient.Price + "$");
            }
        }
    }
}
