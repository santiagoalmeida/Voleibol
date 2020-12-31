using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voleibol.Models.Data;

namespace Voleibol.Models.Services
{
    public interface IEquipoService
    {
        Task InsertEquipoAsync(Equipo equipo);
    }
}
