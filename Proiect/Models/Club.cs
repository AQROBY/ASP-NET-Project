using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Club
    {
        public int ID { get; set; }
        public string ClubName { get; set; }
        public string Country { get; set; }
        public Player Player { get; set; } //navigation property
    }
}
