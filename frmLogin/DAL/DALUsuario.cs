using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Semente.Models;

namespace Semente.DAL
{
    class DALUsuario
    {
        private Conexao objConexao;

        public DALUsuario(Conexao cx)
        {
            objConexao = cx;
        }

        public void Incluir(Usuario usuario)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = objConexao.connection;

            cmd.CommandText =   "INSERT INTO USUARIO(" +
                                "";

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@admin", usuario.Admin);

            objConexao.Conectar();
            usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }
    }
}
