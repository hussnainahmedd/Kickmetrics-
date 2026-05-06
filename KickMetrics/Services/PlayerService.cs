using KickMetrics.Data;
using KickMetrics.Models;

namespace KickMetrics.Services;

public class PlayerService : IPlayerService
{
    public List<Player> GetPlayers()
    {
        return FakeData.GetPlayers();
    }
}