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
    public class clsProfesionDAO
    {
        public Boolean REGISTRARPROFESION(clsProfesion entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdProfesion", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            cmd.Parameters.AddWithValue("Estado", entidad.Estado);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdProfesion = (Int32)paramCODIGO.Value;
            return true;
        }

        public Boolean ACTUALIZARDESCRIPCION(clsProfesion entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_ActualizarDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdProfesion", entidad.IdProfesion);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARESTADO(clsProfesion entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_ActualizarEstado_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdProfesion", entidad.IdProfesion);
            cmd.Parameters.AddWithValue("Estado", entidad.Estado);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public List<clsProfesion> LISTAR()
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            List<clsProfesion> coleccion = new List<clsProfesion>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsProfesion obj = new clsProfesion();
                obj.IdProfesion = (Int32)dr["IdProfesion"];
                obj.Descripcion = dr["Descripcion"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public List<clsProfesion> LISTARACTIVOS()
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_ListarActivos_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            List<clsProfesion> coleccion = new List<clsProfesion>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsProfesion obj = new clsProfesion();
                obj.IdProfesion = (Int32)dr["IdProfesion"];
                obj.Descripcion = dr["Descripcion"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public Int32 OBTENERID(String Descripcion)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_ObtenerId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            con.Open();
            clsProfesion obj = new clsProfesion();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdProfesion = (Int32)dr["IdProfesion"];
            }
            con.Close();
            return obj.IdProfesion;
        }

        public List<clsProfesion> OBTENERPORDESCRIPCION(String Descripcion,Int32 Estado)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_ObtenerPorDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("Estado", Estado);
            con.Open();
            List<clsProfesion> coleccion = new List<clsProfesion>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsProfesion obj = new clsProfesion();
                obj.IdProfesion = (Int32)dr["IdProfesion"];
                obj.Descripcion = dr["Descripcion"].ToString();
                obj.Estado = (Boolean)dr["Estado"];
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public clsProfesion OBTENERPORID(Int32 IdProfesion)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_ObtenerPorId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdProfesion", IdProfesion);
            con.Open();
            clsProfesion obj = new clsProfesion();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdProfesion = (Int32)dr["IdProfesion"];
                obj.Descripcion = dr["Descripcion"].ToString();
                obj.Estado = (Boolean)dr["Estado"];
            }
            con.Close();
            return obj;
        }

        public Boolean ELIMINARPROFESION(clsProfesion entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsProfesion_Eliminar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdProfesion", entidad.IdProfesion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
