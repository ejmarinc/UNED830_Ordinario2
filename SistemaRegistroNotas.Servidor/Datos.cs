using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SistemaRegistroNotas.Servidor
{
    public class Datos
    {

        private string cadenaConexion;
        public Datos()
        {
            //Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionNotas"].ConnectionString;
        }
        public void AgregarAlumno(Alumno pAlumno)
        {

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	Alumno (Id_Alumno, Dsc_nombre, Dsc_apellido1,	Dsc_Apellido2, Dsc_user_name, Dsc_password, Dsc_rol)" +
                        " Values (@Identificacion,	@Nombre, @PrimerApellido,	@SegundoApellido,   @Usuario,   @Contrasena,		@Rol)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Identificacion", pAlumno.Identificacion);
            comando.Parameters.AddWithValue("@Nombre", pAlumno.Nombre);
            comando.Parameters.AddWithValue("@PrimerApellido", pAlumno.PrimerApellido);
            comando.Parameters.AddWithValue("@SegundoApellido", pAlumno.SegundoApellido);
            comando.Parameters.AddWithValue("@Usuario", pAlumno.Usuario);
            comando.Parameters.AddWithValue("@Contrasena", pAlumno.Contrasena);
            comando.Parameters.AddWithValue("@Rol", pAlumno.Rol);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void AgregarCurso(Curso pCurso)
        {

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	Cursos (Id_curso, Dsc_curso, Dsc_Grado,	Can_Horas)" +
                        " Values (@CursoId, @NombreCurso,   @Nivel, @Horas)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@CursoId", pCurso.CursoIdentificacion);
            comando.Parameters.AddWithValue("@NombreCurso", pCurso.NombreCurso);
            comando.Parameters.AddWithValue("@Nivel", pCurso.Nivel);
            comando.Parameters.AddWithValue("@Horas", pCurso.Horas);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public void AgregarCursoAlumno(CursoAlumno pCursoAlumno)
        {

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	CursosAlumnos (Id_curso, Id_alumno, NotaOrdinario1,	NotaOrdinario2, NotaProyecto)" +
                        " Values (@Id_curso, @Id_Alumno,   @NotaOrdinario1, @NotaOrdinario2,    @NotaProyecto)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Id_curso", pCursoAlumno.IdCurso);
            comando.Parameters.AddWithValue("@Id_Alumno", pCursoAlumno.IdAlumno);
            comando.Parameters.AddWithValue("@NotaOrdinario1", pCursoAlumno.Ordinario1);
            comando.Parameters.AddWithValue("@NotaOrdinario2", pCursoAlumno.Ordinario1);
            comando.Parameters.AddWithValue("@NotaProyecto", pCursoAlumno.Proyecto);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }

    }


}
