using KickMetrics.Models;

namespace KickMetrics;

public class PerformanceCalculator : IStatCalculator
{
    public string Calculate(Player p)
    {
        return $"Goals:{p.Stats.Goals}, Assists:{p.Stats.Assists}, Passes:{p.Stats.Passes}";
    }
}