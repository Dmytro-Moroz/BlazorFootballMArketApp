using System.Collections.Generic;
using FootballMarket.Core.Models;

namespace FootballMarket.DataAccess
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayers(string query);
        Player GetPlayer(int id);
    }
}
