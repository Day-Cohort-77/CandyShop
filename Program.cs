/*
    1. Create a Candy, Chocolate, Gummy, HardCandy, DisplayCase, PartyBasket model
    2. Create a CandyRepository, PartyBasketRepository, DisplayCaseRepository repositories in the data directory
    3. Create CandyMenu output UI in the UI directory
    4. Create a UI output for display cases
    5. Create a UI output for party baskets
 */

using CandyShop.Data;
using CandyShop.Models;

namespace CandyShop {
    class Program {
        static void Main (string[] args) {
            // Setup
            CandyRepository inventory = new CandyRepository ();
            inventory.SeedData ();
            List<Candy> allTheCandies = inventory.GetAllCandy ();

            DisplayCaseRepository caseRepo = new DisplayCaseRepository ();
            var chocolateDisplayCase = caseRepo.PurchaseDisplayCase ("chocolate", 120);
            var gummyDisplayCase = caseRepo.PurchaseDisplayCase ("gummy", 235);
            var hardCandyDisplayCase = caseRepo.PurchaseDisplayCase ("hard candy", 92);
            List<DisplayCase> allCases = caseRepo.GetAllDisplayCases ();

            Candy surprises = allTheCandies.Find (c => c.Name == "Chocolate Surprise");
            caseRepo.AddCandyToDisplayCase (surprises, 20, chocolateDisplayCase);

            Candy truffles = allTheCandies.Find (c => c.Name == "Dark Velvet Truffle");
            caseRepo.AddCandyToDisplayCase (truffles, 8, chocolateDisplayCase);

            Console.WriteLine ("Welcome to the Candy Shop!");
            Console.WriteLine ("------------------------------------------------");
            Console.WriteLine ();

            // Display current inventory

            foreach (Candy candy in allTheCandies) {
                Console.WriteLine ($"{candy.Name} costs {candy.Price}");
            }

            foreach (var displayCase in allCases) {
                Console.WriteLine ($"Display case for {displayCase.CandyType} can contain {displayCase.Capacity} items");
                Console.WriteLine ($"It currently contains {displayCase.CurrentStock.Count} items");
            }

            Console.WriteLine ("Press any key to exit...");
            Console.ReadKey ();
        }
    }
}