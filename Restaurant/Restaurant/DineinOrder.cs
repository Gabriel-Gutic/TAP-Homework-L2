using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    // This is an example of inheritance.
    // The TakeoutOrder class inherit the base class Order
    internal class DineinOrder : Order
    {
        private int m_Table;

        public int Table
        { 
            get { return m_Table; } 
            set { m_Table = value; }
        }

        public DineinOrder() 
        {
            m_Table = -1;

            Console.WriteLine("A dine-in order was initiated!");
        }

        // This is an example of polymorphism.
        // The Dispatch method is overridden in this sub-class of the base-class Order
        public override void Dispatch()
        {
            Console.WriteLine("Dine-in order was successufully served!");
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += "Table: " + m_Table + "\n";

            return result;
        }
    }
}
