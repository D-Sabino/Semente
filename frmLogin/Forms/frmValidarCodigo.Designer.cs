namespace Semente.Forms
{
    partial class frmValidarCodigo
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
            components = new System.ComponentModel.Container();
            lblDigiteoCodigoDeRecuperacao = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblExpiracao = new Label();
            btnValidar = new Button();
            btnReenviar = new Button();
            pbCloseApplication = new PictureBox();
            timerExpiracao = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbCloseApplication).BeginInit();
            SuspendLayout();
            // 
            // lblDigiteoCodigoDeRecuperacao
            // 
            lblDigiteoCodigoDeRecuperacao.AutoSize = true;
            lblDigiteoCodigoDeRecuperacao.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblDigiteoCodigoDeRecuperacao.ForeColor = Color.FromArgb(74, 106, 72);
            lblDigiteoCodigoDeRecuperacao.Location = new Point(50, 62);
            lblDigiteoCodigoDeRecuperacao.Name = "lblDigiteoCodigoDeRecuperacao";
            lblDigiteoCodigoDeRecuperacao.Size = new Size(289, 24);
            lblDigiteoCodigoDeRecuperacao.TabIndex = 0;
            lblDigiteoCodigoDeRecuperacao.Text = "Digite o código de recuperação";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(74, 106, 72);
            lblCodigo.Location = new Point(50, 103);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(56, 18);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(140, 98);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 27);
            txtCodigo.TabIndex = 2;
            // 
            // lblExpiracao
            // 
            lblExpiracao.AutoSize = true;
            lblExpiracao.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            lblExpiracao.ForeColor = Color.FromArgb(74, 106, 72);
            lblExpiracao.Location = new Point(50, 133);
            lblExpiracao.Name = "lblExpiracao";
            lblExpiracao.Size = new Size(229, 18);
            lblExpiracao.TabIndex = 3;
            lblExpiracao.Text = "Seu código é válido até às: XX:XX";
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.FromArgb(155, 192, 151);
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Bahnschrift Condensed", 12F);
            btnValidar.ForeColor = SystemColors.ButtonHighlight;
            btnValidar.Location = new Point(50, 183);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(120, 35);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar Código";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnReenviar
            // 
            btnReenviar.BackColor = Color.FromArgb(121, 116, 186);
            btnReenviar.FlatAppearance.BorderSize = 0;
            btnReenviar.FlatStyle = FlatStyle.Flat;
            btnReenviar.Font = new Font("Bahnschrift Condensed", 12F);
            btnReenviar.ForeColor = SystemColors.ButtonHighlight;
            btnReenviar.Location = new Point(197, 183);
            btnReenviar.Name = "btnReenviar";
            btnReenviar.Size = new Size(120, 35);
            btnReenviar.TabIndex = 5;
            btnReenviar.Text = "Reenviar Código";
            btnReenviar.UseVisualStyleBackColor = false;
            btnReenviar.Visible = false;
            btnReenviar.Click += btnReenviar_Click;
            // 
            // pbCloseApplication
            // 
            pbCloseApplication.Image = Properties.Resources.CloseButtonCadastro;
            pbCloseApplication.Location = new Point(336, 12);
            pbCloseApplication.Name = "pbCloseApplication";
            pbCloseApplication.Size = new Size(34, 38);
            pbCloseApplication.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseApplication.TabIndex = 13;
            pbCloseApplication.TabStop = false;
            pbCloseApplication.Click += pbCloseApplication_Click;
            // 
            // frmValidarCodigo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 214, 187);
            ClientSize = new Size(382, 253);
            Controls.Add(pbCloseApplication);
            Controls.Add(btnReenviar);
            Controls.Add(btnValidar);
            Controls.Add(lblExpiracao);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblDigiteoCodigoDeRecuperacao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmValidarCodigo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmValidarCodigo";
            ((System.ComponentModel.ISupportInitialize)pbCloseApplication).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDigiteoCodigoDeRecuperacao;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblExpiracao;
        private Button btnValidar;
        private Button btnReenviar;
        private PictureBox pbCloseApplication;
        private System.Windows.Forms.Timer timerExpiracao;
    }
}