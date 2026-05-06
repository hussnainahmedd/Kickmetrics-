using KickMetrics.Models;

namespace KickMetrics;

public class FitnessCalculator : IStatCalculator
{
    public string Calculate(Player p)
    {
        return $"Distance:{p.Stats.DistanceRun}km, Sprints:{p.Stats.SprintCount}";
    }
}