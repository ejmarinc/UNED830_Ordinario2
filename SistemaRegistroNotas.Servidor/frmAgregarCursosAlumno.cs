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
    public partial class frmAgregarCursosAlumno : Form
    {
        Datos datos = new Datos();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos requeridos sean completados por el usuario
            if (!(txtAlumno.Text.Equals(string.Empty) || txtCurso.Text.Equals(string.Empty)
    || txtOrdinarioI.Text.Equals(string.Empty) || txtOrdinario2.Text.Equals(string.Empty) || txtProyecto.Text.Equals(string.Empty)))
            {
                try
                {
                    //Se crea una nueva instancia del objeto Conductor
                    CursoAlumno nuevoCursoAlumno = new CursoAlumno();

                    //Se realiza la asignacion de los valores en las propiedades correspondientes
                    nuevoCursoAlumno.IdCurso = txtCurso.Text;
                    nuevoCursoAlumno.IdAlumno = txtAlumno.Text;
                    nuevoCursoAlumno.Ordinario1 = txtOrdinarioI.Text;
                    nuevoCursoAlumno.Ordinario2 = txtOrdinario2.Text;
                    nuevoCursoAlumno.Ordinario2 = txtProyecto.Text;

                    //Se agrega el nuevo Autor mediante el acceso a datos con el método correspondiente
                    datos.AgregarCursoAlumno(nuevoCursoAlumno);

                    //Se limpian los TextBox para un nuevo ingreso de información
                    txtCurso.Clear();
                    txtAlumno.Clear();
                    txtOrdinarioI.Clear();
                    txtOrdinario2.Clear();
                    txtProyecto.Clear();

                    MessageBox.Show("Notas agregadas correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
