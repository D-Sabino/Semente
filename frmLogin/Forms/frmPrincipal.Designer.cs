namespace Semente.Forms
{
    partial class frmPrincipal
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
            pnlSidebar = new Panel();
            timerSidebar = new System.Windows.Forms.Timer(components);
            pbCloseApplicationPrincipal = new PictureBox();
            btnToggleSidebar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCloseApplicationPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnToggleSidebar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(135, 175, 130);
            pnlSidebar.Controls.Add(pictureBox2);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(350, 853);
            pnlSidebar.TabIndex = 0;
            // 
            // pbCloseApplicationPrincipal
            // 
            pbCloseApplicationPrincipal.Image = Properties.Resources.CloseButtonCadastro;
            pbCloseApplicationPrincipal.Location = new Point(1536, 12);
            pbCloseApplicationPrincipal.Name = "pbCloseApplicationPrincipal";
            pbCloseApplicationPrincipal.Size = new Size(34, 38);
            pbCloseApplicationPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            pbCloseApplicationPrincipal.TabIndex = 14;
            pbCloseApplicationPrincipal.TabStop = false;
            // 
            // btnToggleSidebar
            // 
            btnToggleSidebar.Image = Properties.Resources.button_fecha;
            btnToggleSidebar.Location = new Point(442, 387);
            btnToggleSidebar.Name = "btnToggleSidebar";
            btnToggleSidebar.Size = new Size(34, 38);
            btnToggleSidebar.SizeMode = PictureBoxSizeMode.Zoom;
            btnToggleSidebar.TabIndex = 15;
            btnToggleSidebar.TabStop = false;
            btnToggleSidebar.Click += btnToggleSidebar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SementeLogoPng;
            pictureBox1.Location = new Point(22, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.SementeLogoTextoPng;
            pictureBox2.Location = new Point(89, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 222, 191);
            ClientSize = new Size(1582, 853);
            Controls.Add(btnToggleSidebar);
            Controls.Add(pbCloseApplicationPrincipal);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCloseApplicationPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnToggleSidebar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private System.Windows.Forms.Timer timerSidebar;
        private PictureBox pbCloseApplicationPrincipal;
        private PictureBox btnToggleSidebar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}