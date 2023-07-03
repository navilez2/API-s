using CardUsersAPI.Data;
using CardUsersAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CardUsersAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioContext _context;

    public UsuarioController(UsuarioContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AdicionaUsuario([FromBody] Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaUsuarioPorId), new { id = usuario.Id },usuario);
    }

    [HttpGet]
    public IEnumerable<Usuario> RecuperaUsuario([FromQuery] int skip = 0, int take = 100)
    {
        return _context.Usuarios.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaUsuarioPorId(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
        if (usuario == null) return NotFound();
        return Ok(usuario);
    }

}
