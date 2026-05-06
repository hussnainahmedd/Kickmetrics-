using KickMetrics.Models;

namespace KickMetrics;

public class InjuryCalculator : IStatCalculator
{
    public string Calculate(Player p)
    {
        return $"Missed:{p.Stats.GamesMissed}, Injury:{p.Stats.InjuryType}";
    }
}