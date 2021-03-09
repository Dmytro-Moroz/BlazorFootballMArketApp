using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballMarket.Core.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public int MarketPrice { get; set; }
        public string Image { get; set; }
        public string PlayerBio { get; set; }
    }
}
