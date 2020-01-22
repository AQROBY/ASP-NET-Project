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
    public class DeleteModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DeleteModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Player
                .Include(p => p.Club).FirstOrDefaultAsync(m => m.ID == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Player.FindAsync(id);

            if (Player != null)
            {
                _context.Player.Remove(Player);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
