using Microsoft.EntityFrameworkCore;
using Rezultati.Models;

namespace Rezultati.Data
{
    public class RezultatiContext : DbContext
    {
        // Konstruktor za RezultatiContext
        public RezultatiContext(DbContextOptions<RezultatiContext> options) : base(options)
        {
        }

        // DbSet-ovi za tvoje modele (entitete)
        public DbSet<Liga> Lige { get; set; }
     

    

    }
}
