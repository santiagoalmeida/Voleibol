using System.Collections.Generic;
using System.Threading.Tasks;
using Voleibol.Models.Data;

namespace Voleibol.Models.Repositorios
{
    public interface IPartidoSetRepository: IRepository<PartidoSet>
    {
        Task<IEnumerable<PartidoSet>> GetPartidoSetAsync();
        Task InsertPartidoSetAsync(PartidoSet entity);
        void UpdatePartidoSet(PartidoSet entity);
    }
}
