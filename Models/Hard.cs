using System;
using CandyShop.Models;

public class HardCandy : Candy {
    public string Flavor { get; set; }
    public int Hardness { get; set; }
    public bool hasCore { get; set; }
}