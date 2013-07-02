using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;

namespace ICADE2._0.SeguridadyAutenticacion.NEGOCIO
{
    public class clsAdministradorGESTOR
    {
        public clsUsuario RegistrarNuevoAdministrador(String Nombre, String Apellidos, String Email, String Contraseña)
        {
            clsUsuario obj = new clsUsuario();
            obj.Nombre = Nombre;
            obj.Apellidos = Apellidos;
            obj.Email = Email;
            obj.Contraseña = Contraseña;
            clsTipoUsuarioDAO dao = new clsTipoUsuarioDAO();
            obj.TipoUsuario = dao.OBTENERID("Administrador");
            obj.Estado = false;

            clsUsuarioDAO daou = new clsUsuarioDAO();
            if (daou.REGISTRARUSUARIO(obj))
            {
                clsAdministrador objP = new clsAdministrador();
                objP.Usuario = obj.IdUsuario;
                objP.Sueldo = 2400;
                clsAdministradorDAO daoP = new clsAdministradorDAO();
                if (daoP.REGISTRARADMINISTRADOR(objP))
                {
                    return obj;
                }
            }
            return null;
        }

        public clsAdministrador RecuperarAdministrador(Int32 IdUsuario)
        {
            clsAdministrador P = new clsAdministrador();
            clsAdministradorDAO daoA = new clsAdministradorDAO();
            P = daoA.OBTENERPORUSUARIO(IdUsuario);
            return P;
        }

        public Boolean ActualizarNombre(clsUsuario Usuario)
        {
            clsUsuarioDAO d = new clsUsuarioDAO();
            if (d.ACTUALIZARNOMBRE(Usuario))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarApellidos(clsUsuario Usuario)
        {
            clsUsuarioDAO d = new clsUsuarioDAO();
            if (d.ACTUALIZARAPELLIDOS(Usuario))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarEmail(clsUsuario Usuario)
        {
            clsUsuarioDAO d = new clsUsuarioDAO();
            if (d.ACTUALIZAREMAIL(Usuario))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarContraseña(clsUsuario Usuario)
        {
            clsUsuarioDAO d = new clsUsuarioDAO();
            if (d.ACTUALIZARCONTRASEÑA(Usuario))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarSueldo(clsUsuario Usuario, Decimal Sueldo)
        {
            clsAdministradorDAO D = new clsAdministradorDAO();
            clsAdministrador P = new clsAdministrador();
            P = D.OBTENERPORUSUARIO(Usuario.IdUsuario);
            P.Sueldo = Sueldo;
            if (D.ACTUALIZARSUELDO(P))
            {
                return true;
            }
            return false;
        }
    }
}