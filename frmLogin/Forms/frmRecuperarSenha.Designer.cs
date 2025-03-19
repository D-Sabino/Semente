namespace Semente.Forms
{
    partial class frmRecuperarSenha
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
            pbCloseApplication = new PictureBox();
            txtEmail = new TextBox();
            lblRecuperacaoDeSenha = new Label();
            lblInforme = new Label();
            lblInforme2 = new Label();
            lblEmail = new Label();
            btnEnviarCodigo = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCloseApplication).BeginInit();
            SuspendLayout();
            // 
            // pbCloseApplication
            // 
            pbCloseApplication.Image = Properties.Resources.CloseButtonCadastro;
            pbCloseApplication.Location = new Point(536, 12);
            pbCloseApplication.Name = "pbCloseApplication";
            pbCloseApplication.Size = new Size(34, 38);
            pbCloseApplication.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseApplication.TabIndex = 12;
            pbCloseApplication.TabStop = false;
            pbCloseApplication.Click += pbCloseApplication_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtEmail.Location = new Point(75, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 26);
            txtEmail.TabIndex = 13;
            // 
            // lblRecuperacaoDeSenha
            // 
            lblRecuperacaoDeSenha.AutoSize = true;
            lblRecuperacaoDeSenha.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Bold);
            lblRecuperacaoDeSenha.ForeColor = Color.FromArgb(74, 106, 72);
            lblRecuperacaoDeSenha.Location = new Point(35, 27);
            lblRecuperacaoDeSenha.Name = "lblRecuperacaoDeSenha";
            lblRecuperacaoDeSenha.Size = new Size(326, 41);
            lblRecuperacaoDeSenha.TabIndex = 14;
            lblRecuperacaoDeSenha.Text = "Recuperar de Senha";
            lblRecuperacaoDeSenha.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInforme
            // 
            lblInforme.AutoSize = true;
            lblInforme.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInforme.ForeColor = Color.FromArgb(74, 106, 72);
            lblInforme.Location = new Point(35, 81);
            lblInforme.Name = "lblInforme";
            lblInforme.Size = new Size(484, 28);
            lblInforme.TabIndex = 15;
            lblInforme.Text = "Informe o e-mail cadastrado para receber um";
            // 
            // lblInforme2
            // 
            lblInforme2.AutoSize = true;
            lblInforme2.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInforme2.ForeColor = Color.FromArgb(74, 106, 72);
            lblInforme2.Location = new Point(35, 109);
            lblInforme2.Name = "lblInforme2";
            lblInforme2.Size = new Size(234, 28);
            lblInforme2.TabIndex = 16;
            lblInforme2.Text = "código de redefinição.";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(74, 106, 72);
            lblEmail.Location = new Point(69, 189);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 24);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "E-mail:";
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.BackColor = Color.FromArgb(74, 106, 72);
            btnEnviarCodigo.FlatAppearance.BorderSize = 0;
            btnEnviarCodigo.FlatStyle = FlatStyle.Flat;
            btnEnviarCodigo.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            btnEnviarCodigo.ForeColor = Color.FromArgb(155, 192, 151);
            btnEnviarCodigo.Location = new Point(75, 257);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(152, 43);
            btnEnviarCodigo.TabIndex = 18;
            btnEnviarCodigo.Text = "Enviar Código";
            btnEnviarCodigo.UseVisualStyleBackColor = false;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // frmRecuperarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 207, 177);
            ClientSize = new Size(582, 353);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(lblEmail);
            Controls.Add(lblInforme2);
            Controls.Add(lblInforme);
            Controls.Add(lblRecuperacaoDeSenha);
            Controls.Add(txtEmail);
            Controls.Add(pbCloseApplication);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRecuperarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRecuperarSenha";
            ((System.ComponentModel.ISupportInitialize)pbCloseApplication).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCloseApplication;
        private TextBox txtEmail;
        private Label lblRecuperacaoDeSenha;
        private Label lblInforme;
        private Label lblInforme2;
        private Label lblEmail;
        private Button btnEnviarCodigo;
    }
}