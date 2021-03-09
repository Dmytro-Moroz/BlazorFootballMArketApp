using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballMarket.Core.Models;

namespace FootballMarket.DataAccess
{
    public interface IViewPlayer
    {
        Player ViewPlayers(int id);
    }
}
