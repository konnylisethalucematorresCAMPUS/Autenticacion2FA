using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IUsuario : IGenericRepository<Usuario>
    {

        Task<Usuario?> GetByIdAsync(long id);
        
    }
