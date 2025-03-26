using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Semente.Services
{
    internal class EmailService
    {
        private string _emailRemetente = ConfigurationManager.AppSettings["emailSistema"];
        private string _senha = ConfigurationManager.AppSettings["senhaEmail"];

        public bool EnviarEmail(string destinatario, string assunto, string mensagem)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(_emailRemetente);
                mail.To.Add(destinatario);
                mail.Subject = assunto;
                mail.Body = mensagem;
                mail.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new System.Net.NetworkCredential(_emailRemetente, _senha),
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

    }
}
