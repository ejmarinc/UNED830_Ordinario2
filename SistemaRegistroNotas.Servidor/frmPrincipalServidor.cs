using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroNotas.Servidor
{
    public partial class frmPrincipalServidor : Form
    {
        public frmPrincipalServidor()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            frmAgregarAlumno formularioAlumno = new frmAgregarAlumno();
            formularioAlumno.Show();
        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            frmAgregarCurso formularioCurso = new frmAgregarCurso();
            formularioCurso.Show();
        }

        private void btnRegistrarNotas_Click(object sender, EventArgs e)
        {
            frmAgregarCursosAlumno formularioNotas = new frmAgregarCursosAlumno();
            formularioNotas.Show();
        }
    }
}
