using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICADE2._0.Administracion.ENTIDADES
{
    public class clsDiplomado
    {
        public Int32 IdDiplomado { get; set; }
        public Int32 Categoria { get; set; }
        public String Descripcion { get; set; }
        public Decimal Matricula { get; set; }
        public Decimal Mensualidad { get; set; }
        public Int32 NumeroCuotas { get; set; }
        public Int32 HorasAcademicas { get; set; }
        public String Imagen { get; set; }
    }
}
