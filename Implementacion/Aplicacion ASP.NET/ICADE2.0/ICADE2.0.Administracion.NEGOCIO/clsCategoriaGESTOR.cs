using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;

namespace ICADE2._0.Administracion.NEGOCIO
{
    public class clsCategoriaGESTOR
    {
        public clsCategoria RegistrarNuevaCategoria(Int32 Profesion, String Descripcion)
        {
            clsCategoria obj = new clsCategoria();
            clsCategoriaDAO d = new clsCategoriaDAO();
            obj.Profesion = Profesion;
            obj.Descripcion = Descripcion;
            if (d.REGISTRARCATEGORIA(obj))
            {
                return obj;
            }
            return obj;
        }
        
        public List<clsCategoriaVISTA> ListarPorDescripcion(String Descripcion, Int32 Profesion)
        {
            clsCategoriaDAO dao = new clsCategoriaDAO();
            List<clsCategoriaVISTA> coleccion = new List<clsCategoriaVISTA>();
            coleccion = dao.OBTENERPORDESCRIPCION(Descripcion, Profesion);
            return coleccion;
        }

        public Boolean EliminarCategoria(Int32 IdCategoria)
        {
            clsCategoria obj = new clsCategoria();
            clsCategoriaDAO DAO = new clsCategoriaDAO();
            obj = DAO.OBTENERPORID(IdCategoria);
            if (DAO.ELIMINARCATEGORIA(obj))
            {
                return true;
            }
            return false;
        }

        public clsCategoria RetornarPorId(Int32 IdCategoria)
        {
            clsCategoria obj = new clsCategoria();
            clsCategoriaDAO DAO = new clsCategoriaDAO();
            obj = DAO.OBTENERPORID(IdCategoria);
            return obj;
        }

        public Boolean ActualizarProfesion(clsCategoria Categoria,Int32 Profesion)
        {
            clsCategoriaDAO d = new clsCategoriaDAO();
            Categoria.Profesion = Profesion;
            if (d.ACTUALIZARPROFESION(Categoria))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarDescripcion(clsCategoria Categoria, String Descripcion)
        {
            clsCategoriaDAO d = new clsCategoriaDAO();
            Categoria.Descripcion = Descripcion;
            if (d.ACTUALIZARDESCRIPCION(Categoria))
            {
                return true;
            }
            return false;
        }
    }
}
