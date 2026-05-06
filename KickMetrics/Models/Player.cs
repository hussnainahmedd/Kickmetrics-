using KickMetrics.Components.Pages;

namespace KickMetrics.Models;

public class Player
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public string Nationality { get; set; }

    public Stats Stats { get; set; }
}