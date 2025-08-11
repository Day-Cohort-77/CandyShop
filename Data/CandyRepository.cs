using CandyShop.Models;

namespace CandyShop.Data
{
    public class CandyRepository
    {
        private List<Candy> _inventory = new List<Candy>();

        public void AddCandy(Candy candy)
        {
            _inventory.Add(candy);
        }

        public List<Candy> GetAllCandy()
        {
            return _inventory;
        }

        public void SeedData()
        {
            // Existing chocolate
            _inventory.Add(new Chocolate
            {
                Price = 10.00M,
                Name = "Chocolate Surprise",
                SweetnessLevel = 8,
                Description = "It is surprisingly sweet",
                CacaoPercentage = 68,
                Type = "Milk"
            });

            // Additional Chocolates
            _inventory.Add(new Chocolate
            {
                Price = 15.50M,
                Name = "Dark Velvet Truffle",
                SweetnessLevel = 6,
                Description = "Rich and luxurious dark chocolate truffle with a smooth ganache center",
                CacaoPercentage = 85,
                Type = "Dark"
            });

            _inventory.Add(new Chocolate
            {
                Price = 8.75M,
                Name = "White Dream Bar",
                SweetnessLevel = 9,
                Description = "Creamy white chocolate bar with vanilla bean specks",
                CacaoPercentage = 0,
                Type = "White"
            });

            _inventory.Add(new Chocolate
            {
                Price = 12.25M,
                Name = "Hazelnut Crunch",
                SweetnessLevel = 7,
                Description = "Milk chocolate bar filled with roasted hazelnut pieces",
                CacaoPercentage = 45,
                Type = "Milk"
            });

            _inventory.Add(new Chocolate
            {
                Price = 18.00M,
                Name = "Belgian Mocha Supreme",
                SweetnessLevel = 5,
                Description = "Premium Belgian dark chocolate infused with espresso",
                CacaoPercentage = 90,
                Type = "Dark"
            });

            // Gummy Candies
            _inventory.Add(new Gummy
            {
                Price = 4.50M,
                Name = "Rainbow Bears",
                SweetnessLevel = 8,
                Flavor = "Mixed Fruit",
                Chewiness = 7,
                isSour = false,
                Shape = "Bear"
            });

            _inventory.Add(new Gummy
            {
                Price = 5.25M,
                Name = "Sour Worm Attack",
                SweetnessLevel = 6,
                Flavor = "Cherry-Lime",
                Chewiness = 8,
                isSour = true,
                Shape = "Worm"
            });

            _inventory.Add(new Gummy
            {
                Price = 6.00M,
                Name = "Tropical Fish",
                SweetnessLevel = 7,
                Flavor = "Tropical Punch",
                Chewiness = 6,
                isSour = false,
                Shape = "Fish"
            });

            _inventory.Add(new Gummy
            {
                Price = 4.75M,
                Name = "Cola Bottles",
                SweetnessLevel = 9,
                Flavor = "Cola",
                Chewiness = 5,
                isSour = false,
                Shape = "Bottle"
            });

            // Hard Candies
            _inventory.Add(new HardCandy
            {
                Price = 3.25M,
                Name = "Peppermint Swirl",
                SweetnessLevel = 4,
                Flavor = "Peppermint",
                Hardness = 9,
                hasCore = false
            });

            _inventory.Add(new HardCandy
            {
                Price = 3.75M,
                Name = "Butterscotch Blast",
                SweetnessLevel = 8,
                Flavor = "Butterscotch",
                Hardness = 8,
                hasCore = false
            });

            _inventory.Add(new HardCandy
            {
                Price = 4.25M,
                Name = "Cherry Bomb",
                SweetnessLevel = 7,
                Flavor = "Cherry",
                Hardness = 7,
                hasCore = true
            });

            _inventory.Add(new HardCandy
            {
                Price = 3.50M,
                Name = "Lemon Drop Classic",
                SweetnessLevel = 5,
                Flavor = "Lemon",
                Hardness = 9,
                hasCore = false
            });
        }
    }
}