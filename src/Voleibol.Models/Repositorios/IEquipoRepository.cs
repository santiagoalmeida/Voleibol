using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voleibol.Models.Data;

namespace Voleibol.Models.Repositorios
{
    public interface IEquipoRepository: IRepository<Match>
    {
        Task InsertarEquipoAsync(Match entidad);
    }
}
