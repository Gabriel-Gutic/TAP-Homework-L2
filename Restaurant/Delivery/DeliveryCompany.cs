using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delivery
{
    public static class DeliveryCompany
    {
        // For now, the SendOrder method will only print a confirmation text to the console
        // and will return true. The idea is that the function would return true 
        // if the order was successfully taken by the courier company.
        public static bool SendOrder(int orderId)
        {
            Console.WriteLine("The order with number " + orderId + " was taken over by the courier company.");
            return true;
        }
    }
}
