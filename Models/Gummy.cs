using System;
using CandyShop.Models;

public class Gummy : Candy {
    public string Flavor { get; set; }
    public int Chewiness { get; set; }
    public bool isSour { get; set; }
    public string Shape { get; set; }
}