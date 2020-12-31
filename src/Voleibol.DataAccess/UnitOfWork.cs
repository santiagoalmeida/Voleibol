using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voleibol.DataAccess.Repositories;
using Voleibol.Models;
using Voleibol.Models.Repositorios;

namespace Voleibol.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VoleibolContext _context;
        private EquipoRepository _equipoRepository;
        private PartidoSetRepository _PartidoSetRepository;

        public UnitOfWork(VoleibolContext context)
        {
            this._context = context;
        }

        public IEquipoRepository Equipo => _equipoRepository = _equipoRepository ?? new EquipoRepository(_context);
        public IPartidoSetRepository PartidoSet => _PartidoSetRepository = _PartidoSetRepository ?? new PartidoSetRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
