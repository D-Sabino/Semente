using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Semente.DAL;
using Semente.Models;

namespace Semente.Forms
{
    public partial class frmRedefinirSenha : Form
    {
        private string emailUsuario;

        public frmRedefinirSenha(string email)
        {
            InitializeComponent();
            emailUsuario = email;
        }

        private void frmRedefinirSenha_Load(object sender, EventArgs e)
        {
            txtNovaSenha.PasswordChar = '*';
            txtConfirmSenha.PasswordChar = '*';
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = chkMostrarSenha.Checked;
            txtNovaSenha.PasswordChar = mostrar ? '\0' : '*';
            txtConfirmSenha.PasswordChar = mostrar ? '\0' : '*';
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text;
            string confirmSenha = txtConfirmSenha.Text;

            if (novaSenha != confirmSenha)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string senhaHash = Utils.GerarHash.GerarHashSenha(novaSenha);

            if (AtualizarSenha(emailUsuario, senhaHash))
            {
                MessageBox.Show("Senha redefinida com sucesso!", "Senha redefinida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmLogin")
                    {
                        form.WindowState = FormWindowState.Normal;
                        form.Activate();
                        break;
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao redefinir senha. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private bool AtualizarSenha(string email, string novaSenhaHash)
        {
            using (var conn = new NpgsqlConnection(DadosConexao.StringDeConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "UPDATE usuario " +
                    "SET senha = @Senha " +
                    "WHERE email = @Email"
                    , conn))
                {
                    cmd.Parameters.AddWithValue("Senha", novaSenhaHash);
                    cmd.Parameters.AddWithValue("Email", email);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        
    }
}
