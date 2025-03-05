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
                string query = "SELECT 1 FROM usuarios";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void CriarUsuario(string nome, string email, string senhaHash, string tipoUsuario)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO usuarios (nome, email, senha, tipo_usuario, data_criacao) " +
                               "VALUES (@nome, @email, @senha, @tipoUsuario, @dataCriacao)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senhaHash);
                    cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                    cmd.Parameters.AddWithValue("@dataCriacao", DateTime.UtcNow); // Usa UTC para padronização

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
