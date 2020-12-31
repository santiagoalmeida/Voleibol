using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Voleibol.Models.Data;

namespace Voleibol.DataAccess.Configurations
{
    class EquipoConfiguration : IEntityTypeConfiguration<Equipo>
    {
        public void Configure(EntityTypeBuilder<Equipo> builder)
        {
            builder
                .HasKey(m => m.IdEquipo);

            builder
                .Property(m => m.IdEquipo)
                .UseIdentityColumn();

            builder
                .HasIndex(idx => idx.NombreEquipo);

            builder
                .ToTable("tab_equipo");

        }
    }
}
