using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voleibol.DataAccess.Repositorios;
using Voleibol.Models.Data;
using Voleibol.Models.Repositorios;

namespace Voleibol.DataAccess.Repositories
{
    public class EquipoRepository : Repository<Equipo>, IEquipoRepository
    {
        public EquipoRepository(VoleibolContext context)
            : base(context)
        { }

        public async Task InsertarEquipoAsync(Equipo entidad)
        {
            await VoleibolContext.AddAsync(entidad);
        }

        private VoleibolContext VoleibolContext
        {
            get { return Context as VoleibolContext; }
        }
    }
}
