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
    public class clsParticipanteDAO
    {
        public Boolean REGISTRARPARTICIPANTE(clsParticipante entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsParticipante_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdParticipante", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Usuario", entidad.Usuario);
            cmd.Parameters.AddWithValue("Profesion", entidad.Profesion);
            cmd.Parameters.AddWithValue("Direccion", entidad.Direccion);
            cmd.Parameters.AddWithValue("Telefono", entidad.Telefono);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdParticipante = (Int32)paramCODIGO.Value;
            return true;
        }

        public Boolean ACTUALIZARPROFESION(clsParticipante entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsParticipante_ActualizarProfesion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdParticipante", entidad.IdParticipante);
            cmd.Parameters.AddWithValue("Profesion", entidad.Profesion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARDIRECCION(clsParticipante entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsParticipante_ActualizarDireccion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdParticipante", entidad.IdParticipante);
            cmd.Parameters.AddWithValue("Direccion", entidad.Direccion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARTELEFONO(clsParticipante entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsParticipante_ActualizarTelefono_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdParticipante", entidad.IdParticipante);
            cmd.Parameters.AddWithValue("Telefono", entidad.Telefono);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public clsParticipante OBTENERPORUSUARIO(Int32 Usuario)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsParticipante_ObtenerPorUsuario_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Usuario", Usuario);
            con.Open();
            clsParticipante obj = new clsParticipante();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdParticipante = (Int32)dr["IdParticipante"];
                obj.Usuario = (Int32)dr["Usuario"];
                obj.Profesion = (Int32)dr["Profesion"];
                obj.Direccion = dr["Direccion"].ToString();
                obj.Telefono = dr["Telefono"].ToString();
            }
            con.Close();
            return obj;
        }
    }
}
