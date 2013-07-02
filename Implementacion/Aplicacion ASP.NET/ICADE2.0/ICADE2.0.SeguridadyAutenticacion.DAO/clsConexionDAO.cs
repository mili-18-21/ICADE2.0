using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICADE2._0.SeguridadyAutenticacion.DAO
{
    public class clsConexionDAO
    {
        public String OBTENERCADENA()
        {
            String CADENA = "Data Source=idea-PC;Initial Catalog=ICADEVIRTUAL2013;Integrated Security=True";
            return CADENA;
        }
    }
}
