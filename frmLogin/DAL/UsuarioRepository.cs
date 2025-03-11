using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semente.DAL
{
    class UsuarioRepository
    {
        private string connectionString = DadosConexao.StringDeConexao;

        public bool ExisteUsuarioCadastrado()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT 1 FROM usuario";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
