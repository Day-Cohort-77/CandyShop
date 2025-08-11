using CandyShop.Models;

public class DisplayCase {
    public string CandyType { get; set; }
    public int Capacity { get; set; }
    public List<Candy> CurrentStock { get; set; }
}