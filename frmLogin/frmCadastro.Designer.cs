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
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(273, 192);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(249, 283);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(273, 358);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 15;
            lblSenha.Text = "Senha";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(476, 73);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 16;
            lblTipo.Text = "Tipo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(273, 215);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(252, 27);
            txtNome.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(249, 306);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(249, 381);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(252, 27);
            txtSenha.TabIndex = 19;
            // 
            // rbPadrao
            // 
            rbPadrao.AutoSize = true;
            rbPadrao.Checked = true;
            rbPadrao.Location = new Point(381, 96);
            rbPadrao.Name = "rbPadrao";
            rbPadrao.Size = new Size(76, 24);
            rbPadrao.TabIndex = 20;
            rbPadrao.TabStop = true;
            rbPadrao.Text = "Padrão";
            rbPadrao.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            rbAdministrador.AutoSize = true;
            rbAdministrador.Location = new Point(463, 96);
            rbAdministrador.Name = "rbAdministrador";
            rbAdministrador.Size = new Size(125, 24);
            rbAdministrador.TabIndex = 21;
            rbAdministrador.Text = "Administrador";
            rbAdministrador.UseVisualStyleBackColor = true;
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
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 192, 151);
            ClientSize = new Size(753, 511);
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
    }
}