using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;

namespace ICADE2._0.Administracion.NEGOCIO
{
    public class clsDiplomadoGESTOR
    {
        public clsDiplomado RegistrarNuevoDiplomado(Int32 Categoria, String Descripcion, Decimal Matricula, Decimal Mensualidad, Int32 NumeroCuotas, Int32 HorasAcademicas, String Imagen)
        {
            clsDiplomado obj = new clsDiplomado();
            clsDiplomadoDAO d = new clsDiplomadoDAO();
            obj.Categoria = Categoria;
            obj.Descripcion = Descripcion;
            obj.Matricula = Matricula;
            obj.Mensualidad = Mensualidad;
            obj.NumeroCuotas = NumeroCuotas;
            obj.HorasAcademicas = HorasAcademicas;
            obj.Imagen = Imagen;
            if (d.REGISTRARDIPLOMADO(obj))
            {
                return obj;
            }
            return obj;
        }
        
        public List<clsDiplomado> ListarPorDescripcion(String Descripcion)
        {
            clsDiplomadoDAO dao = new clsDiplomadoDAO();
            List<clsDiplomado> coleccion = new List<clsDiplomado>();
            coleccion = dao.OBTENERPORDESCRIPCION(Descripcion);
            return coleccion;
        }

        public Boolean EliminarDiplomado(Int32 IdDiplomado)
        {
            clsDiplomado obj = new clsDiplomado();
            clsDiplomadoDAO DAO = new clsDiplomadoDAO();
            obj = DAO.OBTENERPORID(IdDiplomado);
            if (DAO.ELIMINARDIPLOMADO(obj))
            {
                return true;
            }
            return false;
        }

        public clsDiplomado RetornarPorId(Int32 IdDiplomado)
        {
            clsDiplomado obj = new clsDiplomado();
            clsDiplomadoDAO DAO = new clsDiplomadoDAO();
            obj = DAO.OBTENERPORID(IdDiplomado);
            return obj;
        }

        public Boolean ActualizarCategoria(clsDiplomado Diplomado)
        {
            clsDiplomadoDAO d = new clsDiplomadoDAO();
            if (d.ACTUALIZARCATEGORIA(Diplomado))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarDescripcion(clsDiplomado Diplomado)
        {
            clsDiplomadoDAO d = new clsDiplomadoDAO();
            if (d.ACTUALIZARDESCRIPCION(Diplomado))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarMatricula(clsDiplomado Diplomado)
        {
            clsDiplomadoDAO d = new clsDiplomadoDAO();
            if (d.ACTUALIZARMATRICULA(Diplomado))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarMensualidad(clsDiplomado Diplomado)
        {
            clsDiplomadoDAO d = new clsDiplomadoDAO();
            if (d.ACTUALIZARMENSUALIDAD(Diplomado))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarNumeroCuotas(clsDiplomado Diplomado)
        {
            clsDiplomadoDAO d = new clsDiplomadoDAO();
            if (d.ACTUALIZARNUMEROCUOTAS(Diplomado))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarHorasAcademicas(clsDiplomado Diplomado)
        {
            clsDiplomadoDAO d = new clsDiplomadoDAO();
            if (d.ACTUALIZARHORASACADEMICAS(Diplomado))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarImagen(clsDiplomado Diplomado)
        {
            clsDiplomadoDAO d = new clsDiplomadoDAO();
            if (d.ACTUALIZARIMAGEN(Diplomado))
            {
                return true;
            }
            return false;
        }
    }
}
