using FootballMarket.Core.Models;
using FootballMarket.DataAccess;

namespace FootballMarket.Scenario.SearchPlayerScreen
{
    public class ViewPlayer : IViewPlayer
    {
        private readonly IPlayerRepository _playerRepository;

        public ViewPlayer(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public Player ViewPlayers(int id)
        {
            return _playerRepository.GetPlayer(id);
        }
    }
}
