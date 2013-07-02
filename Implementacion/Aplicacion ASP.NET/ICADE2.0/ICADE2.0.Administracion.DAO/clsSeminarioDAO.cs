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
    public class clsSeminarioDAO
    {
        public Boolean ELIMINARSEMINARIO(clsSeminario entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_Eliminar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdSeminario", entidad.IdSeminario);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Int32 OBTENERID(String Descripcion)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_ObtenerId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            con.Open();
            clsSeminario obj = new clsSeminario();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdSeminario = (Int32)dr["IdSeminario"];
            }
            con.Close();
            return obj.IdSeminario;
        }

        public List<clsSeminario> OBTENERPORDESCRIPCION(String Descripcion)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_ObtenerPorDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            con.Open();
            List<clsSeminario> coleccion = new List<clsSeminario>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsSeminario obj = new clsSeminario();
                obj.IdSeminario = (Int32)dr["IdSeminario"];
                obj.Diplomado = (Int32)dr["Diplomado"];
                obj.Descripcion = dr["Descripcion"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public Boolean REGISTRARSEMINARIO(clsSeminario entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdSeminario", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Diplomado", entidad.Diplomado);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdSeminario = (Int32)paramCODIGO.Value;
            return true;
        }

        public clsSeminario OBTENERPORID(Int32 IdSeminario)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_ObtenerPorId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdSeminario", IdSeminario);
            con.Open();
            clsSeminario obj = new clsSeminario();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdSeminario = (Int32)dr["IdSeminario"];
                obj.Diplomado = (Int32)dr["Diplomado"];
                obj.Descripcion = dr["Descripcion"].ToString();
            }
            con.Close();
            return obj;
        }

        public Boolean ACTUALIZARDIPLOMADO(clsSeminario entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_ActualizarDiplomado_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdSeminario", entidad.IdSeminario);
            cmd.Parameters.AddWithValue("Diplomado", entidad.Diplomado);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARDESCRIPCION(clsSeminario entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_ActualizarDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdSeminario", entidad.IdSeminario);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public List<clsSeminario> LISTAR()
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            List<clsSeminario> coleccion = new List<clsSeminario>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsSeminario obj = new clsSeminario();
                obj.IdSeminario = (Int32)dr["IdSeminario"];
                obj.Descripcion = dr["Descripcion"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public List<clsSeminario> LISTARPORDIPLOMADO(Int32 IdDiplomado)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsSeminario_ListarPorDiplomado_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Diplomado", IdDiplomado);
            con.Open();
            List<clsSeminario> coleccion = new List<clsSeminario>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsSeminario obj = new clsSeminario();
                obj.IdSeminario = (Int32)dr["IdSeminario"];
                obj.Diplomado = (Int32)dr["Diplomado"];
                obj.Descripcion = dr["Descripcion"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }
    }
}
