using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Voleibol.Models.Data;

namespace Voleibol.DataAccess.Configurations
{
    class PartidoSetConfiguration : IEntityTypeConfiguration<PartidoSet>
    {
        public void Configure(EntityTypeBuilder<PartidoSet> builder)
        {
            builder
                .HasKey(m => m.IdPartidoSet);

            builder
                .Property(m => m.IdPartidoSet)
                .UseIdentityColumn();

            builder
                .ToTable("tab_partido_set");

            builder.HasOne(one => one.Equipo1)
                .WithMany(many => many.Equipos1)
                .HasForeignKey(fk => fk.IdEquipo1)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(one => one.Equipo2)
                .WithMany(many => many.Equipos2)
                .HasForeignKey(fk => fk.IdEquipo2)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}