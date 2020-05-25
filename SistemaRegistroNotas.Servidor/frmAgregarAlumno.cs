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
    public partial class frmAgregarAlumno : Form
    {
        Datos datos = new Datos();
        public frmAgregarAlumno()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos requeridos sean completados por el usuario
            if (!(txtIdentificacion.Text.Equals(string.Empty) || txtNombre.Text.Equals(string.Empty)
    || txtPrimerApellido.Text.Equals(string.Empty) || txtSegundoApellido.Text.Equals(string.Empty) || txtUsuario.Text.Equals(string.Empty)
    || txtUsuario.Text.Equals(string.Empty)))
            {
                try
                {
                    //Se crea una nueva instancia del objeto Conductor
                    Alumno nuevoAlumno = new Alumno();

                    //Se realiza la asignacion de los valores en las propiedades correspondientes
                    nuevoAlumno.Identificacion = txtIdentificacion.Text;
                    nuevoAlumno.Nombre = txtNombre.Text;
                    nuevoAlumno.PrimerApellido = txtPrimerApellido.Text;
                    nuevoAlumno.SegundoApellido = txtSegundoApellido.Text;
                    nuevoAlumno.Usuario = txtUsuario.Text;
                    nuevoAlumno.Contrasena = txtContrasena.Text;
                    nuevoAlumno.Rol = txtRol.Text;

                    //Se agrega el nuevo Autor mediante el acceso a datos con el método correspondiente
                    datos.AgregarAlumno(nuevoAlumno);

                    //Se limpian los TextBox para un nuevo ingreso de información
                    txtIdentificacion.Clear();
                    txtNombre.Clear();
                    txtPrimerApellido.Clear();
                    txtSegundoApellido.Clear();
                    txtUsuario.Clear();
                    txtContrasena.Clear();

                    MessageBox.Show("Alumno agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error al crear el Alumno " + ex.Message, "A", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
