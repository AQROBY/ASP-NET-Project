using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public IndexModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }
        //public IList<PlayerPosition> Positions { get; set; }

        public async Task OnGetAsync()
        {

            //Positions.FirstOrDefault(a => a.Player.Any(s => s.ID == ID));
            //Albums.SelectMany(a => a.Songs).FirstOrDefault(s => s.Id == Id);
            //var position = Positions.Select(s => s.Position).FirstOrDefault(s => s.ID == s.ID);

            Player = await _context.Player
                .Include(p => p.Club).Include(p => p.Position).ToListAsync();




        }
    }
}
