using ProjetoAPI.DAO;
using ProjetoAPI.Model;

namespace ProjetoAPI.Repositorio
{
    public class UsuarioRepositorio
    {
        private readonly DaoUsuario _daoUsuario;
        public string dc_Email { get; set; }

        public UsuarioRepositorio()
        {
            _daoUsuario = new DaoUsuario();
            dc_Email = string.Empty;
        }

        public List<Usuario> GetUsuarios
        {
            get
            {
                return _daoUsuario.GetUsuario(dc_Email);
            }
        }
    }
}
