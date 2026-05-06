using KickMetrics.Models;

namespace KickMetrics.Data;

public static class FakeData
{
    public static List<Player> GetPlayers()
    {
        return new List<Player>
        {
            new Player
            {
                Name = "Ali",
                Age = 22,
                Position = "Forward",
                Nationality = "Pakistan",
                Stats = new Stats
                {
                    Goals = 10,
                    Assists = 5,
                    Passes = 120,
                    DistanceRun = 8,
                    SprintCount = 20,
                    GamesMissed = 2,
                    InjuryType = "Hamstring"
                }
            },
            new Player
            {
                Name = "Ahmed",
                Age = 25,
                Position = "Midfielder",
                Nationality = "Pakistan",
                Stats = new Stats
                {
                    Goals = 3,
                    Assists = 10,
                    Passes = 300,
                    DistanceRun = 12,
                    SprintCount = 15,
                    GamesMissed = 0,
                    InjuryType = "None"
                }
            }
        };
    }
}