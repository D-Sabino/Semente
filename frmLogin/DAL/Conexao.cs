using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semente.DAL
{
    class Conexao
    {
        private string _coonectionString;
        private NpgsqlConnection _connection;

        public string connectionString
        {
            get { return _coonectionString; }
            set { _coonectionString = value; }
        }

        public NpgsqlConnection connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        public Conexao(string dadosConexao)
        {
            _connection = new NpgsqlConnection();
            _coonectionString = dadosConexao;
            _connection.ConnectionString = _coonectionString;
        }

        public void Conectar()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                    MessageBox.Show("Conectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        public void Desconectar()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    MessageBox.Show("Desconectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desconectar: " + ex.Message);
            }
        }

        public NpgsqlConnection getConnection()
        {
            return _connection;
        }


    }
}
