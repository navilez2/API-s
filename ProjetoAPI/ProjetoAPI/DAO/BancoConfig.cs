using System.Data.SqlClient;

namespace ProjetoAPI.DAO
{
    public class BancoConfig
    {
        private readonly IConfiguration Configuration;
        public SqlCommand? ComandoSQL { get; set; }
        public BancoConfig()
        {
            Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build(); ;
        }

        public string getConection(string database)
        {
            return Configuration.GetConnectionString(database).ToString();
        }
    }
}
