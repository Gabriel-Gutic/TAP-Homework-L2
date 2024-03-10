using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal static class Randomizer
    {
        private static Random s_Random = new Random();

        public static Order RandomOrder()
        {
            Order? order = null;
            string name = "dine-in";

            if (s_Random.Next(0, 2) == 0)
            {
                DineinOrder dineinOrder = new DineinOrder();
                dineinOrder.Table = s_Random.Next(1, 31);
                order = dineinOrder;
            }
            else
            {
                TakeoutOrder takeoutOrder = new TakeoutOrder();
                takeoutOrder.Address = "Str. " + new string((char)s_Random.Next('A', 'Z' + 1), 5) + " Nr. " + s_Random.Next(1, 11);
                order = takeoutOrder;
                name = "takeout";

            }

            int ingredientCount = s_Random.Next(1, 11);

            for (int i = 0; i < ingredientCount; i++)
            {
                order.AddIngredient(Resources.Ingredients.ElementAt(s_Random.Next(0, Resources.Ingredients.Count)).Value);
            }

            Console.WriteLine("Random " + name + " order was generated!");

            return order;
        }
    }
}
