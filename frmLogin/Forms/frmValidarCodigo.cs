using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semente.Forms
{
    public partial class frmValidarCodigo : Form
    {
        private string emailUsuario;
        private DateTime dataExpiracao;

        public frmValidarCodigo(string email)
        {
            InitializeComponent();
            emailUsuario = email;
            CarregarDadosCodigo();
        }

        private void CarregarDadosCodigo()
        {
            using (var conn = new NpgsqlConnection(DadosConexao.StringDeConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT Codigo_Recuperacao, data_expiracao_codigo " +
                    "FROM usuario " +
                    "WHERE email = @Email"
                    , conn))
                {
                    cmd.Parameters.AddWithValue("Email", emailUsuario);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Properties.Settings.Default.CodigoRecuperacao = reader["Codigo_Recuperacao"].ToString();
                            dataExpiracao = Convert.ToDateTime(reader["data_expiracao_codigo"]);
                            AtualizarLabelExpiracao();
                        }
                    }
                }
            }
        }

        private void AtualizarLabelExpiracao()
        {
            lblExpiracao.Text = $"Seu código expira em: {dataExpiracao.ToString("HH:mm")}";

            if (DateTime.UtcNow > dataExpiracao)
            {
                MessageBox.Show("Seu código expirou. Por favor, solicite um novo código.", "Código expirado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblExpiracao.ForeColor = Color.FromArgb(121, 116, 186);
                btnReenviar.Visible = true;
                btnValidar.Enabled = false;

            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

        }

        private void btnReenviar_Click(object sender, EventArgs e)
        {

        }

        private void pbCloseApplication_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
