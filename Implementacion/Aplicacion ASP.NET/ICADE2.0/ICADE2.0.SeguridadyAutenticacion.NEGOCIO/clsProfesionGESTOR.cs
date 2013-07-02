using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;

namespace ICADE2._0.SeguridadyAutenticacion.NEGOCIO
{
    public class clsProfesionGESTOR
    {
        public clsProfesion RegistrarNuevaProfesion(String Descripcion, Boolean Estado)
        {
            clsProfesion obj=new clsProfesion();
            clsProfesionDAO d = new clsProfesionDAO();
            obj.Descripcion = Descripcion;
            obj.Estado = Estado;
            if (d.REGISTRARPROFESION(obj))
            {
                return obj;
            }
            return obj;
        }

        public List<clsProfesion> ListarPorDescripcion(String Descripcion,Int32 Estado)
        {
            clsProfesionDAO dao = new clsProfesionDAO();
            List<clsProfesion> coleccion = new List<clsProfesion>();
            coleccion=dao.OBTENERPORDESCRIPCION(Descripcion,Estado);
            return coleccion;
        }

        public Boolean EliminarProfesion(Int32 IdProfesion)
        {
            clsProfesion obj = new clsProfesion();
            clsProfesionDAO DAO = new clsProfesionDAO();
            obj = DAO.OBTENERPORID(IdProfesion);
            if (DAO.ELIMINARPROFESION(obj))
            {
                return true;
            }
            return false;
        }

        public clsProfesion RetornarPorId(Int32 IdProfesion)
        {
            clsProfesion obj = new clsProfesion();
            clsProfesionDAO DAO = new clsProfesionDAO();
            obj = DAO.OBTENERPORID(IdProfesion);
            return obj;
        }

        public Boolean ActualizarDescripcion(clsProfesion Profesion)
        {
            clsProfesionDAO d = new clsProfesionDAO();
            if (d.ACTUALIZARDESCRIPCION(Profesion))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarEstado(clsProfesion Profesion)
        {
            clsProfesionDAO d = new clsProfesionDAO();
            if (d.ACTUALIZARESTADO(Profesion))
            {
                return true;
            }
            return false;
        }
    }
}