using Npgsql;
using Semente.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private EmailService _emailService = new EmailService();
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
            DateTime agora = DateTime.UtcNow.ToLocalTime();
            lblExpiracao.Text = $"Seu código expira em: {dataExpiracao.ToString("HH:mm")}";

            if (agora > dataExpiracao)
            {
                MessageBox.Show("Seu código expirou. Por favor, solicite um novo código.", "Código expirado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblExpiracao.ForeColor = Color.FromArgb(121, 116, 186);
                btnReenviar.Visible = true;
                btnValidar.Enabled = false;

            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            DateTime agora = DateTime.UtcNow.ToLocalTime();
            string codigoInserido = txtCodigo.Text.Trim();
            string codigoArmazenado = Properties.Settings.Default.CodigoRecuperacao;

            if (codigoInserido == codigoArmazenado && agora <= dataExpiracao)
            {
                MessageBox.Show("Código validado com sucesso! Insira sua nova senha.", "Código válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmRedefinirSenha frmRedefinirSenha = new frmRedefinirSenha(emailUsuario);
                frmRedefinirSenha.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Código inválido. Por favor, tente novamente.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReenviar_Click(object sender, EventArgs e)
        {
            string novoCodigo = GerarCodigo();
            SalvarNovoCodigo(novoCodigo);

            if(EnviarEmail(emailUsuario, novoCodigo))
            {
                MessageBox.Show("Código reenviado com sucesso! Verifique seu e-mail.", "Código reenviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarDadosCodigo();
            }
        }

        private string GerarCodigo()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SalvarNovoCodigo(string novoCodigo)
        {
            using (var conn = new NpgsqlConnection(DadosConexao.StringDeConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "UPDATE usuario " +
                    "SET codigo_recuperacao = @Codigo, data_expiracao_codigo = @Expiracao " +
                    "WHERE email = @Email"
                    , conn))
                {
                    cmd.Parameters.AddWithValue("Codigo", novoCodigo);
                    cmd.Parameters.AddWithValue("Expiracao", DateTime.UtcNow.AddMinutes(10));
                    cmd.Parameters.AddWithValue("Email", emailUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool EnviarEmail(string emailDestino, string codigo)
        {
            try
            {
                string assunto = "Recuperação de senha";
                string mensagem = $"Olá,\n\nSeu código de recuperação de senha é: {codigo}\n\nUse este código para redefinir sua senha.";

                if (_emailService.EnviarEmail(emailDestino, assunto, mensagem))
                {
                    return true;
                }
                else
                {
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
                return false;
            }
        }

        private void pbCloseApplication_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
