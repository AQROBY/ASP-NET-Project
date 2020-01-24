using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Position
    {
        public int ID { get; set; }
        public string PositionName { get; set; }
        //public Player Player { get; set; }
        public ICollection<Player> Players { get; set; }

    }
}
