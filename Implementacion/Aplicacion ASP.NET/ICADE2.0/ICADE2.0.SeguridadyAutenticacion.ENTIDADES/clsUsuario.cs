using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICADE2._0.SeguridadyAutenticacion.ENTIDADES
{
    public class clsUsuario
    {
        public Int32 IdUsuario { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Email { get; set; }
        public String Contraseña { get; set; }
        public Int32 TipoUsuario { get; set; }
        public Boolean Estado { get; set; }
    }
}
