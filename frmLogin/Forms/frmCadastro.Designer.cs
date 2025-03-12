namespace Semente
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbCloseApplicationCadastro = new PictureBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblTipo = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            rbPadrao = new RadioButton();
            rbAdministrador = new RadioButton();
            pictureBox1 = new PictureBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            lblCadastro = new Label();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCloseApplicationCadastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbCloseApplicationCadastro
            // 
            pbCloseApplicationCadastro.Location = new Point(707, 12);
            pbCloseApplicationCadastro.Name = "pbCloseApplicationCadastro";
            pbCloseApplicationCadastro.Size = new Size(34, 38);
            pbCloseApplicationCadastro.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseApplicationCadastro.TabIndex = 12;
            pbCloseApplicationCadastro.TabStop = false;
            pbCloseApplicationCadastro.Click += pbCloseApplicationCadastro_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.ButtonHighlight;
            lblNome.Font = new Font("Bahnschrift Condensed", 12F);
            lblNome.ForeColor = Color.FromArgb(155, 192, 151);
            lblNome.Location = new Point(249, 175);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 24);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.ButtonHighlight;
            lblEmail.Font = new Font("Bahnschrift Condensed", 12F);
            lblEmail.ForeColor = Color.FromArgb(155, 192, 151);
            lblEmail.Location = new Point(249, 232);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 24);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = SystemColors.ButtonHighlight;
            lblSenha.Font = new Font("Bahnschrift Condensed", 12F);
            lblSenha.ForeColor = Color.FromArgb(155, 192, 151);
            lblSenha.Location = new Point(249, 289);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(51, 24);
            lblSenha.TabIndex = 15;
            lblSenha.Text = "Senha";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = SystemColors.ButtonHighlight;
            lblTipo.Font = new Font("Bahnschrift Condensed", 12F);
            lblTipo.ForeColor = Color.FromArgb(155, 192, 151);
            lblTipo.Location = new Point(249, 84);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(37, 24);
            lblTipo.TabIndex = 16;
            lblTipo.Text = "Tipo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(249, 202);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(252, 27);
            txtNome.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(249, 259);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(249, 316);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(252, 27);
            txtSenha.TabIndex = 19;
            // 
            // rbPadrao
            // 
            rbPadrao.AutoSize = true;
            rbPadrao.BackColor = SystemColors.ButtonHighlight;
            rbPadrao.Checked = true;
            rbPadrao.Font = new Font("Bahnschrift Condensed", 12F);
            rbPadrao.ForeColor = Color.FromArgb(155, 192, 151);
            rbPadrao.Location = new Point(249, 116);
            rbPadrao.Name = "rbPadrao";
            rbPadrao.Size = new Size(78, 28);
            rbPadrao.TabIndex = 20;
            rbPadrao.TabStop = true;
            rbPadrao.Text = "Padrão";
            rbPadrao.UseVisualStyleBackColor = false;
            // 
            // rbAdministrador
            // 
            rbAdministrador.AutoSize = true;
            rbAdministrador.BackColor = SystemColors.ButtonHighlight;
            rbAdministrador.Font = new Font("Bahnschrift Condensed", 12F);
            rbAdministrador.ForeColor = Color.FromArgb(155, 192, 151);
            rbAdministrador.Location = new Point(376, 116);
            rbAdministrador.Name = "rbAdministrador";
            rbAdministrador.Size = new Size(125, 28);
            rbAdministrador.TabIndex = 21;
            rbAdministrador.Text = "Administrador";
            rbAdministrador.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BackgroundPlantas;
            pictureBox1.Location = new Point(131, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(492, 430);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(155, 192, 151);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Bahnschrift Condensed", 12F);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(249, 370);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 35);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(155, 192, 151);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Bahnschrift Condensed", 12F);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(408, 370);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 35);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastro.ForeColor = SystemColors.ButtonFace;
            lblCadastro.Location = new Point(326, 9);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(119, 41);
            lblCadastro.TabIndex = 27;
            lblCadastro.Text = "Cadastro";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(155, 192, 151);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Bahnschrift Condensed", 12F);
            btnPesquisar.ForeColor = SystemColors.ButtonHighlight;
            btnPesquisar.Location = new Point(295, 413);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(93, 35);
            btnPesquisar.TabIndex = 28;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 192, 151);
            ClientSize = new Size(753, 511);
            Controls.Add(btnPesquisar);
            Controls.Add(lblCadastro);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(rbAdministrador);
            Controls.Add(rbPadrao);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblTipo);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(pbCloseApplicationCadastro);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCadastro";
            Load += frmCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pbCloseApplicationCadastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCloseApplicationCadastro;
        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblTipo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private RadioButton rbPadrao;
        private RadioButton rbAdministrador;
        private PictureBox pictureBox1;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label lblCadastro;
        private Button btnPesquisar;
    }
}