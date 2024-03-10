using Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    // This is an example of inheritance.
    // The TakeoutOrder class inherit the base class Order
    internal class TakeoutOrder : Order
    {
        private string m_Address;

        public string Address
        {
            get { return m_Address; }
            set { m_Address = value; }
        }

        public TakeoutOrder()
        {
            m_Address = "";
            Console.WriteLine("A takeout order was initiated!");
        }

        // This is an example of polymorphism.
        // The Dispatch method is overridden in this sub-class of the base-class Order
        public override void Dispatch()
        {
            Console.WriteLine("Takeout order with number " + ID + " will be send to the courier company soon.");
            
            // This is an example of abstraction. 
            // We can use the functions from Delivery Company without knowing what is 
            // behind them.
            DeliveryCompany.SendOrder(ID);
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += "Address: " + m_Address + "\n";

            return result;
        }
    }
}
