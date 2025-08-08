using CandyShop.Models;

namespace CandyShop.Data
{
    public class CandyRepository
    {
        private List<Candy> _inventory = new List<Candy>();
        // Add candy
        public void AddCandy(Candy candy) {
            _inventory.Add(candy);
        }

        public List<Candy> GetAllCandy()
        {
            return _inventory;
        }

        public void SeedData()
        {
            _inventory.Add(new Chocolate {
                Price = 10.00M,
                Name = "Chocolate Surprise",
                SweetnessLevel = 8,
                Description = "It is surprisingly sweet",
                CacaoPercentage = 68,
                Type = "Milk"
            });

        }
    }
}