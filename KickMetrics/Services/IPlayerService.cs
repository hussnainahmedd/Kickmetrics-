using KickMetrics.Models;

namespace KickMetrics.Services;

public interface IPlayerService
{
    List<Player> GetPlayers();
}