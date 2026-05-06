namespace KickMetrics.Models;

public class Stats
{
    public int Goals { get; set; }
    public int Assists { get; set; }
    public int Passes { get; set; }

    public int DistanceRun { get; set; }
    public int SprintCount { get; set; }

    public int GamesMissed { get; set; }
    public string InjuryType { get; set; }
}