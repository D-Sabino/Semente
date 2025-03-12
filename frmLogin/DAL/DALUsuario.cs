using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Semente.Models;
using BCrypt.Net;

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

            string senhaHash = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            cmd.CommandText =   "INSERT INTO USUARIO(" +
                                "nome, email, senha," +
                                "datacriacao, usuarioadmin)" +
                                "VALUES (" +
                                "@nome, @email, @senha," +
                                "CURRENT_TIMESTAMP, @admin) " +
                                "RETURNING id";

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", senhaHash);
            cmd.Parameters.AddWithValue("@admin", usuario.Admin);

            objConexao.Conectar();
            usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Alterar(Usuario usuario)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = objConexao.connection;

            string senhaHash = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            cmd.CommandText =   "UPDATE USUARIO SET " +
                                "nome = @nome, email = @email, senha = @senha, " +
                                "usuarioadmin = @admin " +
                                "WHERE id = @id";
            
            cmd.Parameters.AddWithValue("@id", usuario.Id);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", senhaHash);
            cmd.Parameters.AddWithValue("@admin", usuario.Admin);
            
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }
    }
}
