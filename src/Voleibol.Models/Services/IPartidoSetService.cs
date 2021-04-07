using System.Collections.Generic;
using System.Threading.Tasks;
using Voleibol.Models.Data;

namespace Voleibol.Models.Services
{
    public interface IPartidoSetService
    {
        Match AddPoint(Match match);
        Match CheckSet(Match match);
    }
}
