using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voleibol.Models;
using Voleibol.Models.Data;
using Voleibol.Models.Services;

namespace Voleibol.BusinessLogic.Services
{
    public class EquipoService : IEquipoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EquipoService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task InsertEquipoAsync(Equipo equipo)
        {
            await _unitOfWork.Equipo.InsertarAsync(equipo);
            await _unitOfWork.CommitAsync();

        }
    }
}
