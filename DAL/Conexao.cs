using MySql.Data.MySqlClient;

namespace SistemaComercialETEC.DAL
{
    public class Conexao
    {
        private string conexaoString =
            "server=localhost;database=sistema_etec;uid=root;pwd=;";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(conexaoString);
        }
    }
}