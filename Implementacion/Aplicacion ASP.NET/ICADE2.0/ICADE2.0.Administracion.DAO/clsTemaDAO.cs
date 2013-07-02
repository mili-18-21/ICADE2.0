using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;

namespace ICADE2._0.Administracion.DAO
{
    public class clsTemaDAO
    {
        public Boolean REGISTRARTEMA(clsTema entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsTema_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdTema", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Seminario", entidad.Seminario);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdTema = (Int32)paramCODIGO.Value;
            return true;
        }

        public clsTema OBTENERPORID(Int32 IdTema)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsTema_ObtenerPorId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdTema", IdTema);
            con.Open();
            clsTema obj = new clsTema();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdTema = (Int32)dr["IdTema"];
                obj.Seminario = (Int32)dr["Seminario"];
                obj.Descripcion = dr["Descripcion"].ToString();
            }
            con.Close();
            return obj;
        }

        public List<clsTema> OBTENERPORDESCRIPCION(String Descripcion)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsTema_ObtenerPorDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            con.Open();
            List<clsTema> coleccion = new List<clsTema>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsTema obj = new clsTema();
                obj.IdTema = (Int32)dr["IdTema"];
                obj.Seminario = (Int32)dr["Seminario"];
                obj.Descripcion = dr["Descripcion"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public Boolean ACTUALIZARSEMINARIO(clsTema entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsTema_ActualizarSeminario_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdTema", entidad.IdTema);
            cmd.Parameters.AddWithValue("Seminario", entidad.Seminario);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARDESCRIPCION(clsTema entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsTema_ActualizarDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdTema", entidad.IdTema);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
