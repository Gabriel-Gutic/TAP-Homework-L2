using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Ingredient
    {
        // An example of encapsulation
        // The id, name and price can be read from the outside, but their values can not be changed
        private Guid m_ID;
        private string m_Name; 
        private float m_Price;

        public Guid ID 
        { 
            get { return m_ID; } 
        }

        public string Name
        { 
            get { return m_Name; } 
        }

        public float Price
        {
            get { return m_Price; }
        }

        public Ingredient(string name, float price) 
        {
            m_ID = Guid.NewGuid();
            m_Name = name;

            if (price <= 0)
            {
                Console.WriteLine("Invalid price!");
                Debugger.Break();
            }
            m_Price = price;
        }

        public override string ToString()
        {
            return m_Name + " | " + m_Price + "$"; 
        }
    }
}
