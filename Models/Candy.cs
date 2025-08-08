namespace CandyShop.Models;

public class Candy {
    private int _sweetness = 1;

    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required int SweetnessLevel {
        get => _sweetness;
        set {
            if ((value > 0) && (value < 11)) {
                _sweetness = value;
            }
            else {
                throw new Exception("That is an invalid value for sweetness level. Valid values are 1-10.");
            }
        }
    }
}
