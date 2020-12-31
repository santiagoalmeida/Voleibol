using Microsoft.EntityFrameworkCore;
using Voleibol.DataAccess.Configurations;
using Voleibol.Models.Data;

namespace Voleibol.DataAccess
{
    public class VoleibolContext : DbContext
    {
        public VoleibolContext(DbContextOptions<VoleibolContext> options)
            : base(options)
        { }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<PartidoSet> PartidoSets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EquipoConfiguration());
            modelBuilder.ApplyConfiguration(new PartidoSetConfiguration());
        }
    }
}
