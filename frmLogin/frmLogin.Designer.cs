namespace frmLogin
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            chkLembrar = new CheckBox();
            btnEntrar = new Button();
            btnEsqueci = new Button();
            lblLogin = new Label();
            pbBackground = new PictureBox();
            pbIlustracao = new PictureBox();
            pbCloseApplication = new PictureBox();
            pbVisibilidadeSenha = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIlustracao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseApplication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVisibilidadeSenha).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(74, 106, 72);
            lblEmail.Location = new Point(417, 179);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 24);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(417, 207);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 32);
            txtEmail.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.ForeColor = Color.FromArgb(74, 106, 72);
            lblSenha.Location = new Point(417, 243);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(51, 24);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(417, 271);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(313, 32);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // chkLembrar
            // 
            chkLembrar.AutoSize = true;
            chkLembrar.ForeColor = Color.FromArgb(74, 106, 72);
            chkLembrar.Location = new Point(417, 311);
            chkLembrar.Margin = new Padding(3, 4, 3, 4);
            chkLembrar.Name = "chkLembrar";
            chkLembrar.Size = new Size(115, 28);
            chkLembrar.TabIndex = 4;
            chkLembrar.Text = "Lembrar-me";
            chkLembrar.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(155, 192, 151);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(417, 380);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(93, 35);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnEsqueci
            // 
            btnEsqueci.BackColor = Color.FromArgb(155, 192, 151);
            btnEsqueci.FlatStyle = FlatStyle.Flat;
            btnEsqueci.ForeColor = SystemColors.ButtonHighlight;
            btnEsqueci.Location = new Point(537, 380);
            btnEsqueci.Margin = new Padding(0);
            btnEsqueci.Name = "btnEsqueci";
            btnEsqueci.Size = new Size(193, 35);
            btnEsqueci.TabIndex = 6;
            btnEsqueci.Text = "Esqueci a senha";
            btnEsqueci.UseVisualStyleBackColor = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = SystemColors.ButtonHighlight;
            lblLogin.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(155, 192, 151);
            lblLogin.Location = new Point(417, 103);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(313, 41);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Acesse a sua conta";
            // 
            // pbBackground
            // 
            pbBackground.Location = new Point(-26, 0);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(413, 512);
            pbBackground.TabIndex = 9;
            pbBackground.TabStop = false;
            // 
            // pbIlustracao
            // 
            pbIlustracao.BackColor = Color.FromArgb(155, 192, 151);
            pbIlustracao.Location = new Point(33, 103);
            pbIlustracao.Name = "pbIlustracao";
            pbIlustracao.Size = new Size(316, 312);
            pbIlustracao.SizeMode = PictureBoxSizeMode.Zoom;
            pbIlustracao.TabIndex = 10;
            pbIlustracao.TabStop = false;
            // 
            // pbCloseApplication
            // 
            pbCloseApplication.Location = new Point(714, 5);
            pbCloseApplication.Name = "pbCloseApplication";
            pbCloseApplication.Size = new Size(34, 38);
            pbCloseApplication.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseApplication.TabIndex = 11;
            pbCloseApplication.TabStop = false;
            pbCloseApplication.Click += pbCloseApplication_Click;
            // 
            // pbVisibilidadeSenha
            // 
            pbVisibilidadeSenha.Location = new Point(690, 278);
            pbVisibilidadeSenha.Name = "pbVisibilidadeSenha";
            pbVisibilidadeSenha.Size = new Size(32, 19);
            pbVisibilidadeSenha.SizeMode = PictureBoxSizeMode.Zoom;
            pbVisibilidadeSenha.TabIndex = 12;
            pbVisibilidadeSenha.TabStop = false;
            pbVisibilidadeSenha.Click += pbVisibilidadeSenha_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(753, 511);
            Controls.Add(pbVisibilidadeSenha);
            Controls.Add(pbCloseApplication);
            Controls.Add(pbIlustracao);
            Controls.Add(lblLogin);
            Controls.Add(btnEsqueci);
            Controls.Add(btnEntrar);
            Controls.Add(chkLembrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(pbBackground);
            Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIlustracao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseApplication).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVisibilidadeSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private CheckBox chkLembrar;
        private Button btnEntrar;
        private Button btnEsqueci;
        private Label lblLogin;
        private PictureBox pbBackground;
        private PictureBox pbIlustracao;
        private PictureBox pbCloseApplication;
        private PictureBox pbVisibilidadeSenha;
    }
}
