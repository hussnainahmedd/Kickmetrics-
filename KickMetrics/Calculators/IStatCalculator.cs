using KickMetrics.Models;

namespace KickMetrics;

public interface IStatCalculator
{
    string Calculate(Player player);
}