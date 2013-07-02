using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICADE2._0.Administracion.DAO;
using ICADE2._0.Administracion.ENTIDADES;

namespace ICADE2._0.Administracion.NEGOCIO
{
    public class clsSeminarioGESTOR
    {
        public clsSeminario RegistrarNuevoSeminario(Int32 Diplomado, String Descripcion)
        {
            clsSeminario obj = new clsSeminario();
            clsSeminarioDAO d = new clsSeminarioDAO();
            obj.Diplomado = Diplomado;
            obj.Descripcion = Descripcion;
            if (d.REGISTRARSEMINARIO(obj))
            {
                return obj;
            }
            return obj;
        }
        
        public List<clsSeminario> ListarPorDescripcion(String Descripcion)
        {
            clsSeminarioDAO dao = new clsSeminarioDAO();
            List<clsSeminario> coleccion = new List<clsSeminario>();
            coleccion = dao.OBTENERPORDESCRIPCION(Descripcion);
            return coleccion;
        }

        public Boolean EliminarSeminario(Int32 IdSeminario)
        {
            clsSeminario obj = new clsSeminario();
            clsSeminarioDAO DAO = new clsSeminarioDAO();
            obj = DAO.OBTENERPORID(IdSeminario);
            if (DAO.ELIMINARSEMINARIO(obj))
            {
                return true;
            }
            return false;
        }

        public clsSeminario RetornarPorId(Int32 IdSeminario)
        {
            clsSeminario obj = new clsSeminario();
            clsSeminarioDAO DAO = new clsSeminarioDAO();
            obj = DAO.OBTENERPORID(IdSeminario);
            return obj;
        }

        public Boolean ActualizarDiplomado(clsSeminario Seminario)
        {
            clsSeminarioDAO d = new clsSeminarioDAO();
            if (d.ACTUALIZARDIPLOMADO(Seminario))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarDescripcion(clsSeminario Seminario)
        {
            clsSeminarioDAO d = new clsSeminarioDAO();
            if (d.ACTUALIZARDESCRIPCION(Seminario))
            {
                return true;
            }
            return false;
        }
    }
}
