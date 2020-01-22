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
        public string Category { get; set; }
        public Player Player { get; set; } //navigation property
    }
}
