using System;
using CandyShop.Models;

public class Chocolate : Candy {
    public int CacaoPercentage { get; set; }
    public required string Type { get; set; }
    public required string Description { get; set; }

}