using Npgsql;
using Semente.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semente.Forms
{
    public partial class frmRecuperarSenha : Form
    {
        private EmailService _emailService = new EmailService();
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }



        private string GerarCodigo()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private bool EnviarEmail(string emailDestino, string codigo)
        {
            try
            {
                string remetente = ConfigurationManager.AppSettings["emailSistema"];
                string senha = ConfigurationManager.AppSettings["senhaEmail"];

                string assunto = "Recuperação de senha";
                string mensagem = $"Olá,\n\nSeu código de recuperação de senha é: {codigo}\n\nUse este código para redefinir sua senha.";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(remetente);
                mail.To.Add(emailDestino);
                mail.Subject = assunto;
                mail.Body = mensagem;
                mail.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new System.Net.NetworkCredential(remetente, senha),
                    EnableSsl = true
                };
                
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
                return false;
            }
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if(string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe o e-mail para recuperação de senha.");
                return;
            }

            if (!EmailExisteNoBanco(email))
            {
                MessageBox.Show("E-mail não cadastrado no sistema.");
                return;
            }

            string codigo = GerarCodigo();
            SalvarCodigoNoBanco(email, codigo);

            
            if (EnviarEmail(email, codigo))
            {
                MessageBox.Show("Código enviado com sucesso. Verifique sua caixa de entrada.");

                frmValidarCodigo validarCodigo = new frmValidarCodigo(email);
                validarCodigo.Show();

                this.Close();
            }
            
        }

        private bool EmailExisteNoBanco(string email)
        {
            using (var conn = new NpgsqlConnection(DadosConexao.StringDeConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Usuario WHERE Email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void SalvarCodigoNoBanco(string email, string codigo)
        {
            using (var conn = new NpgsqlConnection(DadosConexao.StringDeConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE Usuario SET Codigo_Recuperacao = @Codigo, Data_Expiracao_Codigo = @Expiracao WHERE Email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("Codigo", codigo);
                    cmd.Parameters.AddWithValue("Expiracao", DateTime.UtcNow.AddMinutes(10));
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void pbCloseApplication_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
