using Npgsql;
using Semente;
using Semente.DAL;
using Semente.Utils;
using System.Configuration;

namespace frmLogin
{
    public partial class frmLogin : Form
    {
        public string operacao = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbVisibilidadeSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                pbVisibilidadeSenha.Image = ImageHelper.ByteArrayToImage(Semente.Properties.Resources.visivel);
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                pbVisibilidadeSenha.Image = ImageHelper.ByteArrayToImage(Semente.Properties.Resources.invisivel);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            carregaImagens();
            Conexao cx = new Conexao(DadosConexao.StringDeConexao);
            cx.Conectar();
        }

        private void carregaImagens()
        {
            pbBackground.Image = ImageHelper.ByteArrayToImage(Semente.Properties.Resources.background);
            pbIlustracao.Image = ImageHelper.ByteArrayToImage(Semente.Properties.Resources.ilustracao);
            pbCloseApplication.Image = ImageHelper.ByteArrayToImage(Semente.Properties.Resources.close);
            pbVisibilidadeSenha.Image = ImageHelper.ByteArrayToImage(Semente.Properties.Resources.invisivel);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();

            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if(usuarioRepository.ExisteUsuarioCadastrado() == false)
            {
                MessageBox.Show("Nenhum usuário cadastrado!");
                this.operacao = "login";
                this.Hide();

                frmCadastro frmCadastro = new frmCadastro(this);
                frmCadastro.ShowDialog();

            }
            else if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (AutenticarUsuario(email, senha))
            {
                MessageBox.Show("Usuário autenticado com sucesso!");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário não autenticado!");
            }
        }

        private bool AutenticarUsuario(string email, string senha)
        {
            using (var conn = new NpgsqlConnection(DadosConexao.StringDeConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT Senha FROM Usuarios WHERE Email = @email", conn))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    var hashedSenha = cmd.ExecuteScalar()?.ToString();

                    if (hashedSenha != null && BCrypt.Net.BCrypt.Verify(senha, hashedSenha))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
