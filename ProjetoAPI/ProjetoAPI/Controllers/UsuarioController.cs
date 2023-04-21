using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Model;
using ProjetoAPI.Repositorio;

namespace ProjetoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        [HttpPost]
        [Route("api/usuario/{dc_email}")]
        public ActionResult<IEnumerable<Usuario>> Usuario(string dc_email)
        {
            _usuarioRepositorio.dc_Email = dc_email;
            return _usuarioRepositorio.GetUsuarios;
        }
    }
}