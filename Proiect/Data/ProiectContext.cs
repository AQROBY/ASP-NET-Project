using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext (DbContextOptions<ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect.Models.Player> Player { get; set; }

        public DbSet<Proiect.Models.Club> Club { get; set; }

        public DbSet<Proiect.Models.Position> Position { get; set; }

    }
}
