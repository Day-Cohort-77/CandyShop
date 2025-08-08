using CandyShop.Models;

public class PartyBasket {
    public decimal TotalPrice { get; set; }
    public List<Candy> Contents { get; set; } = new List<Candy>();
    public bool isGift { get; set; }
}