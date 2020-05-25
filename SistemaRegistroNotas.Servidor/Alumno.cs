using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroNotas.Servidor
{
    public class Alumno
    {
        public string Identificacion { set; get; }

        public string Nombre { set; get; }

        public string PrimerApellido { set; get; }

        public string SegundoApellido { set; get; }

        public string Usuario { set; get; }
        public string Contrasena { set; get; }
        public string Rol { set; get; }

    }
}
