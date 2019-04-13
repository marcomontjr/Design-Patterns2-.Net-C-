using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2.Cap1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection
            {
                ConnectionString = "User id=root;Password=;Server=localhost;Database=meuBanco"
            };

            conexao.Open();

            return conexao;
        }
    }
}