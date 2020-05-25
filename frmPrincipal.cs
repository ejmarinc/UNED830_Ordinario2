using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRegistroNotas.Servidor;

namespace Proyecto_Segundo_Ordinario_ErickMarin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void servidorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalServidor frmServidor = new frmPrincipalServidor();
            frmServidor.MdiParent = this;
            frmServidor.Show();
        }
    }
}
