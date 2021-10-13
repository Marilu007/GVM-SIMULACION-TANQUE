using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVM_SIMULACION_DE_TANQUE
{
    public partial class Simulacion : Form
    {
        public Simulacion()
        {
            InitializeComponent();
        }

        private void Llenar_Click(object sender, EventArgs e)
        {
            tmrllenar.Enabled = true;
            tmrvaciar.Enabled = false;

        }

        private void Vaciar_Click(object sender, EventArgs e)
        {
            tmrvaciar.Enabled = true;
            tmrllenar.Enabled = false;
        }

        private void tmrvaciar_Tick(object sender, EventArgs e)
        {
            if (PanelAgua.Height >=5)
            {
                PanelAgua.Height = PanelAgua.Height - 5;
                PanelAgua.Top=PanelAgua.Top + 5;

            }
            else
            {
                tmrvaciar.Enabled = false;
            }
        }

        private void tmrllenar_Tick(object sender, EventArgs e)
        {
            if (PanelAgua.Height <= 300)
            {
                PanelAgua.Height = PanelAgua.Height + 5;
                PanelAgua.Top = PanelAgua.Top - 5;

            }
            else
            {
                tmrllenar.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
