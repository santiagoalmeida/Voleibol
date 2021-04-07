using System.Collections.Generic;
using System.Threading.Tasks;
using Voleibol.Models.Data;

namespace Voleibol.Models.Repositorios
{
    public interface IPartidoSetRepository: IRepository<Times>
    {
        Task<IEnumerable<Times>> GetPartidoSetAsync();
        Task InsertPartidoSetAsync(Times entity);
        void UpdatePartidoSet(Times entity);
    }
}
