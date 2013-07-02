using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICADE2._0.Administracion.ENTIDADES
{
    public class clsEventoSeminario
    {
        public Int32 IdEventoSeminario { get; set; }
        public Int32 Seminario { get; set; }
        public String Expositor { get; set; }
        public String Lugar { get; set; }
        public String Hora { get; set; }
        public DateTime Fecha { get; set; }
    }
}
