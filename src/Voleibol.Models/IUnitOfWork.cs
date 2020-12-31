using System;
using System.Threading.Tasks;
using Voleibol.Models.Repositorios;

namespace Voleibol.Models
{
    public interface IUnitOfWork : IDisposable
    {
        IPartidoSetRepository PartidoSet { get; }
        IEquipoRepository Equipo { get; }
        Task<int> CommitAsync();
    }
}
