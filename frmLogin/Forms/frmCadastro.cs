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
            MessageBox.Show("Foi para a tela de cadastro!");
            /*Iniciar o desenvolvimento!*/

        }

        private void carregaImagens()
        {
            pbCloseApplicationCadastro.Image = ImageHelper.ByteArrayToImage(Semente.Properties.Resources.CloseButtonCadastro);
        }

        private void pbCloseApplicationCadastro_Click(object sender, EventArgs e)
        {
            if (telaOrigem != null)
            {
                telaOrigem.Show();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool bolAdmin = false;

            if (rbAdministrador.Checked)
                bolAdmin = true;

            /*
             
                CRIAR A VALIDAÇÃO DE CAMPOS AQUI!
            
            */

            Usuario usuario = new Usuario();



        }
    }
}
