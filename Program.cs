/*
    1. Create a Candy, Chocolate, Gummy, HardCandy, DisplayCase, PartyBasket model
    2. Create a CandyRepository, PartyBasketRepository, DisplayCaseRepository repositories in the data directory
    3. Create CandyMenu output UI in the UI directory
    4. Create a UI output for display cases
    5. Create a UI output for party baskets
 */


using CandyShop.Data;
using CandyShop.Models;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Candy Shop!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            // Display current inventory
            CandyRepository inventory = new CandyRepository();
            inventory.SeedData();
            List<Candy> allTheCandies = inventory.GetAllCandy();

            foreach (Candy candy in allTheCandies)
            {
                Console.WriteLine($"{candy.Name} costs {candy.Price}");
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}