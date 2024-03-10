using Delivery;


namespace Restaurant
{
    internal class Program
    {
        /*
         I made an app that simulates orders in a fast-food, like KFC.

        There are 2 types of orders:
        -> dine-in order
        -> takeout order

        Takeout orders are send to a Delivery Company, which is reprezented by the 
        DeliveryCompany class from Delivery Project.

        Each order is composed of multiple ingredients. The ingredients are read from 
        a txt file.

        We randomly create an order, with the Randomizer class.
         */

        static void Main(string[] args)
        {
            Resources.LoadIngredients("resources/ingredients.txt");

            string separator = new string('-', 100);

            Console.WriteLine(separator);

            int n = 10;

            for (int i = 0; i < n; i++)
            {
                // Generate a random order
                Order order = Randomizer.RandomOrder();

                // Print the information of the order
                Console.WriteLine(order);

                // Dine-in orders are send to tables.
                // Takeout orders are send to the delivery company.
                order.Dispatch();

                Console.WriteLine(separator);
            }
        }
    }
}
