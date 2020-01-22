using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Proiect.Models
{
    public class Player
    {
        public int ID { get; set; }
        [Display(Name = "Player's First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Nationality { get; set; }
        [Display(Name = "Market Value")]
        public int MarketValue { get; set; }
        public int Age { get; set; }
        public int ClubID { get; set; }
        public Club Club { get; set; }
        public int PositionID { get; set; }
        public Position Position { get; set; }
    }
}
