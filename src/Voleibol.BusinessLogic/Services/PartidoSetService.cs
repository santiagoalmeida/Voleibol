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
    public class PartidoSetService : IPartidoSetService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartidoSetService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Task ActualizarPartidoSet(PartidoSet partidoSet)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PartidoSet>> GetPartidoAsync()
        {
            throw new NotImplementedException();
        }
    }
}
