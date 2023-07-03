using CardUsersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CardUsersAPI.Data;

public class UsuarioContext : DbContext
{
    public UsuarioContext(DbContextOptions<UsuarioContext> opts) : base(opts)
    {

    }
    public DbSet<Usuario> Usuarios { get; set; }
}
