using System.Collections.Generic;
using System.Threading.Tasks;
using Voleibol.Models.Data;

namespace Voleibol.Models.Services
{
    public interface IPartidoSetService
    {
        Task<IEnumerable<PartidoSet>> GetPartidoAsync();
        Task ActualizarPartidoSet(PartidoSet partidoSet);
    }
}
