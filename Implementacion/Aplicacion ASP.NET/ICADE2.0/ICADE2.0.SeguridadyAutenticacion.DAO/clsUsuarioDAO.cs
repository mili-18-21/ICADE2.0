using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;

namespace ICADE2._0.SeguridadyAutenticacion.DAO
{
    public class clsUsuarioDAO
    {
        public Boolean REGISTRARUSUARIO(clsUsuario entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsUsuario_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdUsuario", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Nombre", entidad.Nombre);
            cmd.Parameters.AddWithValue("Apellidos", entidad.Apellidos);
            cmd.Parameters.AddWithValue("Email", entidad.Email);
            cmd.Parameters.AddWithValue("Contraseña", entidad.Contraseña);
            cmd.Parameters.AddWithValue("TipoUsuario", entidad.TipoUsuario);
            cmd.Parameters.AddWithValue("Estado", entidad.Estado);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdUsuario = (Int32)paramCODIGO.Value;
            return true;
        }

        public Boolean ACTUALIZARNOMBRE(clsUsuario entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsUsuario_ActualizarNombre_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdUsuario", entidad.IdUsuario);
            cmd.Parameters.AddWithValue("Nombre", entidad.Nombre);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARAPELLIDOS(clsUsuario entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsUsuario_ActualizarApellidos_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdUsuario", entidad.IdUsuario);
            cmd.Parameters.AddWithValue("Apellidos", entidad.Apellidos);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZAREMAIL(clsUsuario entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsUsuario_ActualizarEmail_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdUsuario", entidad.IdUsuario);
            cmd.Parameters.AddWithValue("Email", entidad.Email);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARCONTRASEÑA(clsUsuario entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsUsuario_ActualizarContraseña_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdUsuario", entidad.IdUsuario);
            cmd.Parameters.AddWithValue("Contraseña", entidad.Contraseña);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public clsUsuario BUSCARPOREMAIL(String Email, String Contraseña)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsUsuario_BuscarPorEmail_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Contraseña", Contraseña);
            con.Open();
            clsUsuario obj = new clsUsuario();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdUsuario = (Int32)dr["IdUsuario"];
                obj.Nombre = dr["Nombre"].ToString();
                obj.Apellidos = dr["Apellidos"].ToString();
                obj.Email = dr["Email"].ToString();
                obj.Contraseña = dr["Contraseña"].ToString();
                obj.TipoUsuario = (Int32)dr["TipoUsuario"];
                obj.Estado=(Boolean)dr["Estado"];
            }
            con.Close();
            return obj;
        }
    }
}
