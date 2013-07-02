using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;

namespace ICADE2._0.SeguridadyAutenticacion.NEGOCIO
{
    public class clsParticipanteGESTOR
    {
        public clsUsuario IniciarSesion(String Email, String Contraseña)
        {
            clsUsuario obj = new clsUsuario();
            clsUsuarioDAO dao = new clsUsuarioDAO();
            obj = dao.BUSCARPOREMAIL(Email, Contraseña);
            if (obj.IdUsuario.ToString() != "0")
            {
                if (obj.TipoUsuario.ToString() == "1")
                {
                    if (obj.Estado == true)
                    {
                        obj.Contraseña = "1";
                        return obj;
                    }
                    else
                    {
                        obj.Contraseña = "0";
                        return obj;
                    }
                }
                if (obj.TipoUsuario.ToString() == "2")
                {
                    if (obj.Estado == true)
                    {
                        obj.Contraseña = "2";
                        return obj;
                    }
                    else
                    {
                        obj.Contraseña = "0";
                        return obj;
                    }
                }
            }
            else obj.Contraseña = "0";
            return obj;
        }

        public clsUsuario RegistrarNuevoParticipante(String Nombre, String Apellidos, String Email, String Contraseña, Int32 Profesion, String Direccion, String Telefono)
        {
            clsUsuario obj = new clsUsuario();
            obj.Nombre = Nombre;
            obj.Apellidos = Apellidos;
            obj.Email = Email;
            obj.Contraseña = Contraseña;
            clsTipoUsuarioDAO dao = new clsTipoUsuarioDAO();
            obj.TipoUsuario = dao.OBTENERID("Participante");
            obj.Estado = true;

            clsUsuarioDAO daou = new clsUsuarioDAO();
            if (daou.REGISTRARUSUARIO(obj))
            {
                clsParticipante objP = new clsParticipante();
                objP.Usuario = obj.IdUsuario;
                objP.Profesion = Profesion;
                objP.Direccion = Direccion;
                objP.Telefono = Telefono;
                clsParticipanteDAO daoP = new clsParticipanteDAO();
                if (daoP.REGISTRARPARTICIPANTE(objP))
                {
                    return obj;
                }
            }
            return null;
        }

        public Boolean ActualizarNombre(clsUsuario Usuario)
        {
            clsUsuarioDAO d=new clsUsuarioDAO();
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

        public Boolean ActualizarProfesion(clsUsuario Usuario,Int32 Profesion)
        {
            clsParticipanteDAO D = new clsParticipanteDAO();
            clsParticipante P = new clsParticipante();
            P = D.OBTENERPORUSUARIO(Usuario.IdUsuario);
            P.Profesion = Profesion;
            if (D.ACTUALIZARPROFESION(P))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarDireccion(clsUsuario Usuario, String Direccion)
        {
            clsParticipanteDAO D = new clsParticipanteDAO();
            clsParticipante P = new clsParticipante();
            P = D.OBTENERPORUSUARIO(Usuario.IdUsuario);
            P.Direccion = Direccion;
            if (D.ACTUALIZARDIRECCION(P))
            {
                return true;
            }
            return false;
        }

        public Boolean ActualizarTelefono(clsUsuario Usuario, String Telefono)
        {
            clsParticipanteDAO D = new clsParticipanteDAO();
            clsParticipante P = new clsParticipante();
            P = D.OBTENERPORUSUARIO(Usuario.IdUsuario);
            P.Telefono = Telefono;
            if (D.ACTUALIZARTELEFONO(P))
            {
                return true;
            }
            return false;
        }

        public clsParticipante RecuperarParticipante(Int32 IdUsuario)
        {
            clsParticipante P = new clsParticipante();
            clsParticipanteDAO daoA = new clsParticipanteDAO();
            P = daoA.OBTENERPORUSUARIO(IdUsuario);
            return P;
        }
    }
}