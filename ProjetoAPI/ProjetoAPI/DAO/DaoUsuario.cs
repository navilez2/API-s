using ProjetoAPI.Model;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoAPI.DAO
{
    public class DaoUsuario
    {
        private BancoConfig config
        {
            get
            {
                return new BancoConfig();
            }
        }
        public List<Usuario> GetUsuario(string DC_EMAIL)
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(config.getConection("PROJETO")))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SPS_USUARIO", conn))
                {
                    cmd.Parameters.AddWithValue("@DC_EMAIL", DC_EMAIL);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader != null)
                        {
                            while (reader.Read())
                            {
                                var usuario = new Usuario();

                                usuario.Nome = reader["NM_USUARIO"].ToString();
                                usuario.Email = reader["DC_EMAIL"].ToString();
                                usuario.Senha = reader["DC_SENHA"].ToString();
                                usuario.Ativo = bool.Parse(reader["ID_ATIVO"].ToString());
                                usuario.Lembrar_Email = bool.Parse(reader["ID_LEMBRAR_EMAIL"].ToString());
                                usuarios.Add(usuario);
                            }
                        }
                    }

                }
                conn.Close();

            }
            return usuarios;
        }



    }
}

