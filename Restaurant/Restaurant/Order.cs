using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal abstract class Order
    {
        // An example of encapsulation.
        // This static variable is private.
        // It can only be accesed inside this class, because we use its value only when we create
        // a new command.
        private static int s_NextID = 1;

        protected int m_ID;

        public int ID
        { 
            get { return m_ID; } 
        }

        protected List<Ingredient> m_Ingredients;

        public List<Ingredient> Ingredients
        {
            get { return m_Ingredients; }
        }

        public Order() 
        {
            m_ID = s_NextID++;
            m_Ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            m_Ingredients.Add(ingredient);
        }

        // This is an example of abstraction.
        // We can use this Dispatch function without seeing its implementation from
        // the child classes
        public abstract void Dispatch();

        public float TotalPrice()
        {
            float total = 0.0f;
            foreach (Ingredient ingredient in m_Ingredients)
            {
                total += ingredient.Price;
            }
            return total;
        }

        public override string ToString()
        {
            string result = "Order | Number: " + m_ID + "\nIngredients:\n";

            int maxLength = 0;

            for (int i = 0; i < m_Ingredients.Count; i++)
            {
                string component = (i + 1) + ") " + m_Ingredients[i].Name;
                if (component.Length > maxLength)
                    maxLength = component.Length;
            }

            for (int i = 0; i < m_Ingredients.Count; i++)
            {
                string component = (i + 1) + ") " + m_Ingredients[i].Name;
                result += component + new string(' ', maxLength - component.Length) + " | " + m_Ingredients[i].Price + "$\n";
            }

            result += "Total Price: " + string.Format("{0:0.00}", TotalPrice()) + "$\n";

            return result;
        }
    }
}
