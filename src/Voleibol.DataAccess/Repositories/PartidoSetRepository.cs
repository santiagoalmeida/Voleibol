using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voleibol.DataAccess.Repositorios;
using Voleibol.Models.Data;
using Voleibol.Models.Repositorios;

namespace Voleibol.DataAccess.Repositories
{
    public class PartidoSetRepository : Repository<PartidoSet>, IPartidoSetRepository
    {
        public PartidoSetRepository(VoleibolContext context)
            : base(context)
        { }

        public async Task<IEnumerable<PartidoSet>> GetPartidoSetAsync() 
        {
            return await VoleibolContext.PartidoSets.ToListAsync();
        }

        public async Task InsertPartidoSetAsync(PartidoSet entity)
        {
            await VoleibolContext.AddAsync(entity);
        }

        public void UpdatePartidoSet(PartidoSet entity)
        {
            VoleibolContext.Update(entity);
        }

        private VoleibolContext VoleibolContext
        {
            get { return Context as VoleibolContext; }
        }
    }
}
