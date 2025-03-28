namespace Semente.Forms
{
    partial class frmRedefinirSenha
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
            lblTitulo = new Label();
            lblNovaSenha = new Label();
            txtNovaSenha = new TextBox();
            lblConfirmSenha = new Label();
            txtConfirmSenha = new TextBox();
            chkMostrarSenha = new CheckBox();
            btnRedefinir = new Button();
            btnCancelar = new Button();
            pbCloseApplication = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCloseApplication).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(50, 50, 50);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(153, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Redefinir Senha";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            lblNovaSenha.ForeColor = Color.FromArgb(80, 80, 80);
            lblNovaSenha.Location = new Point(40, 80);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(91, 18);
            lblNovaSenha.TabIndex = 1;
            lblNovaSenha.Text = "Nova Senha:";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtNovaSenha.Location = new Point(168, 77);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '*';
            txtNovaSenha.Size = new Size(220, 26);
            txtNovaSenha.TabIndex = 2;
            // 
            // lblConfirmSenha
            // 
            lblConfirmSenha.AutoSize = true;
            lblConfirmSenha.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            lblConfirmSenha.ForeColor = Color.FromArgb(80, 80, 80);
            lblConfirmSenha.Location = new Point(40, 130);
            lblConfirmSenha.Name = "lblConfirmSenha";
            lblConfirmSenha.Size = new Size(123, 18);
            lblConfirmSenha.TabIndex = 3;
            lblConfirmSenha.Text = "Confirmar Senha:";
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtConfirmSenha.Location = new Point(168, 125);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.PasswordChar = '*';
            txtConfirmSenha.Size = new Size(220, 26);
            txtConfirmSenha.TabIndex = 4;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            chkMostrarSenha.Location = new Point(170, 165);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(128, 22);
            chkMostrarSenha.TabIndex = 5;
            chkMostrarSenha.Text = "Mostrar Senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            // 
            // btnRedefinir
            // 
            btnRedefinir.BackColor = Color.FromArgb(155, 192, 151);
            btnRedefinir.FlatAppearance.BorderSize = 0;
            btnRedefinir.FlatStyle = FlatStyle.Flat;
            btnRedefinir.Font = new Font("Bahnschrift Condensed", 12F);
            btnRedefinir.ForeColor = SystemColors.ButtonHighlight;
            btnRedefinir.Location = new Point(125, 210);
            btnRedefinir.Name = "btnRedefinir";
            btnRedefinir.Size = new Size(150, 40);
            btnRedefinir.TabIndex = 6;
            btnRedefinir.Text = "Redefinir Senha";
            btnRedefinir.UseVisualStyleBackColor = false;
            btnRedefinir.Click += btnRedefinir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(121, 116, 186);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Bahnschrift Condensed", 12F);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(285, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pbCloseApplication
            // 
            pbCloseApplication.Image = Properties.Resources.CloseButtonCadastro;
            pbCloseApplication.Location = new Point(354, 12);
            pbCloseApplication.Name = "pbCloseApplication";
            pbCloseApplication.Size = new Size(34, 38);
            pbCloseApplication.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseApplication.TabIndex = 14;
            pbCloseApplication.TabStop = false;
            // 
            // frmRedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 214, 187);
            ClientSize = new Size(400, 271);
            Controls.Add(pbCloseApplication);
            Controls.Add(btnCancelar);
            Controls.Add(btnRedefinir);
            Controls.Add(chkMostrarSenha);
            Controls.Add(txtConfirmSenha);
            Controls.Add(lblConfirmSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(lblNovaSenha);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRedefinirSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRedefinirSenha";
            Load += frmRedefinirSenha_Load;
            ((System.ComponentModel.ISupportInitialize)pbCloseApplication).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNovaSenha;
        private TextBox txtNovaSenha;
        private Label lblConfirmSenha;
        private TextBox txtConfirmSenha;
        private CheckBox chkMostrarSenha;
        private Button btnRedefinir;
        private Button btnCancelar;
        private PictureBox pbCloseApplication;
    }
}