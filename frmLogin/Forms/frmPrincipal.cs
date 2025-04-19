using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semente.Forms
{
    public partial class frmPrincipal : Form
    {
        private bool sidebarAberta = true;
        private int larguraAberta = 350, larguraFechada = 100, step = 10;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pnlSidebar.Width = 350;
            sidebarAberta = true;
            AjustaPosicaoBotao();
            btnToggleSidebar.Image = Properties.Resources.button_fecha;
        }

        private void AjustaPosicaoBotao()
        {
            int posX = pnlSidebar.Width + 10;
            int posY = (this.Height / 2) - (btnToggleSidebar.Height / 2);
            btnToggleSidebar.Location = new Point(posX, posY);
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();

            if (sidebarAberta)
            {
                btnToggleSidebar.Image = Properties.Resources.button_abre;
                pnlSidebar.Width = larguraFechada;
                sidebarAberta = false;
            }
            else
            {
                btnToggleSidebar.Image = Properties.Resources.button_fecha;
                pnlSidebar.Width = larguraAberta;
                sidebarAberta = true;
            }

            AjustaPosicaoBotao();
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarAberta)
            {
                if (pnlSidebar.Width > larguraFechada)
                    pnlSidebar.Width -= step;
                else
                {
                    sidebarAberta = false;
                    timerSidebar.Stop();
                }
            }
            else
            {
                if (pnlSidebar.Width < larguraAberta)
                    pnlSidebar.Width += step;
                else
                {
                    sidebarAberta = true;
                    timerSidebar.Stop();
                }
            }
        }
    }
}
