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
    public partial class frmAgregarCurso : Form
    {
        Datos datos = new Datos();
        public frmAgregarCurso()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos requeridos sean completados por el usuario
            if (!(txtNumeroCurso.Text.Equals(string.Empty) || txtNombreCurso.Text.Equals(string.Empty)
    || txtNivel.Text.Equals(string.Empty) || txtCantidadHoras.Text.Equals(string.Empty) ))
            {
                try
                {
                    //Se crea una nueva instancia del objeto Conductor
                    Curso nuevoCurso = new Curso();

                    //Se realiza la asignacion de los valores en las propiedades correspondientes
                    nuevoCurso.CursoIdentificacion = txtNumeroCurso.Text;
                    nuevoCurso.NombreCurso = txtNombreCurso.Text;
                    nuevoCurso.Nivel = txtNivel.Text;
                    nuevoCurso.Horas = txtCantidadHoras.Text;

                    //Se agrega el nuevo Autor mediante el acceso a datos con el método correspondiente
                    datos.AgregarCurso(nuevoCurso);

                    //Se limpian los TextBox para un nuevo ingreso de información
                    txtNumeroCurso.Clear();
                    txtNombreCurso.Clear();
                    txtNivel.Clear();
                    txtCantidadHoras.Clear();

                    MessageBox.Show("Curso agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Error al Ingresar Curso a la base de datos " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error al crear el Curso " + ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                //En caso de que los datos no estén completos se muestra un mensaje de advertencia
                //Se debe tener cuidado que no parezca un mensaje de error, dado que no es un error
                MessageBox.Show("Debe completar todos los campos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
