using Semente.DAL;
using Semente.Properties;
using Semente.Utils;
using Semente.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Text.RegularExpressions;

namespace Semente
{
    public partial class frmCadastro : Form
    {
        private Form telaOrigem;

        public frmCadastro(Form origem)
        {
            InitializeComponent();
            this.telaOrigem = origem;
        }

        public void frmCadastro_Load(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(DadosConexao.StringDeConexao);
            cx.Conectar();
            carregaImagens();
           
            if (telaOrigem.Text == "Login")
            {
                rbAdministrador.Checked = true;
                rbPadrao.Checked = false;
                rbPadrao.Enabled = false;

                btnExcluir.Visible = false;
                btnPesquisar.Enabled = false;
            }
            else
            {
                /*Iniciar o desenvolvimento!*/
            }


        }

        private void carregaImagens()
        {
            pbCloseApplicationCadastro.Image = ImageHelper.ByteArrayToImage(Semente.Properties.Resources.CloseButtonCadastro);
        }

        private void pbCloseApplicationCadastro_Click(object sender, EventArgs e)
        {
            retornaTelaOrigem();
        }

        public void retornaTelaOrigem()
        {
            if (telaOrigem != null)
            {
                telaOrigem.Show();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                String strConexao = DadosConexao.StringDeConexao;
                Conexao conexao = new Conexao(strConexao);
                DALUsuario dal = new DALUsuario(conexao);

                bool bolAdmin = false;
                if (rbAdministrador.Checked)
                    bolAdmin = true;

                /* Validação dos campos */
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("O campo nome é obrigatório!");
                    return;
                }
                else if (!Regex.IsMatch(txtNome.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("O campo nome deve conter apenas letras!");
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("O campo email é obrigatório e deve ser um email válido!");
                    return;
                }

                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Admin = bolAdmin;

                if (telaOrigem.Text == "Login")
                {
                    dal.Incluir(usuario);
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Hide();
                    retornaTelaOrigem();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
        }
    }
}
