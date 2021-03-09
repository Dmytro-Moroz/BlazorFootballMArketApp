using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballMarket.Core.Models;
using FootballMarket.DataAccess;

namespace FootballMarket.Scenario.SearchPlayerScreen
{
    public class SearchPlayer : ISearchPlayer
    {
        private readonly IPlayerRepository _playerRepository;

        public SearchPlayer(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public IEnumerable<Player> SearchingPlayers(string query = null)
        {
            return _playerRepository.GetPlayers(query);
        }
    }
}
