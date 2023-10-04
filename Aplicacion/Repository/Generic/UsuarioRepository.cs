using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repository;
public class UsuarioRepository : GenericRepository<Usuario>, IUsuario
{

    private readonly DbAppContext _Context;
    public UsuarioRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }

    public async Task<Usuario?> GetByIdAsync(long id) 
    {
        return await _Context.FindAsync<Usuario>(id); // retorna un objeto 
    }


}
