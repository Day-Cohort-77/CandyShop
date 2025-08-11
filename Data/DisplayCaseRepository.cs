using CandyShop.Models;

namespace CandyShop.Data {
    public class DisplayCaseRepository {
        private List<DisplayCase> _displayCaseEquipment = new List<DisplayCase> ();

        public void AddCandyToDisplayCase (Candy candy, int quantity, DisplayCase displayCase) {
            for (int i = 0; i < quantity; i++) {
                displayCase.CurrentStock.Add (candy);
            }
        }

        public List<DisplayCase> GetAllDisplayCases () {
            return _displayCaseEquipment;
        }

        public DisplayCase PurchaseDisplayCase (string candyType, int capacity) {
            DisplayCase newDisplayCase = new DisplayCase {
                CandyType = candyType,
                Capacity = capacity,
                CurrentStock=new List<Candy>()
            };
            _displayCaseEquipment.Add (newDisplayCase);
            return newDisplayCase;
        }
    }
}