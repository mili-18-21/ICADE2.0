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
    public class clsCategoriaDAO
    {
        public List<clsCategoria> LISTAR()
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsCategoria_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            List<clsCategoria> coleccion = new List<clsCategoria>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsCategoria obj = new clsCategoria();
                obj.IdCategoria = (Int32)dr["IdCategoria"];
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
            SqlCommand cmd = new SqlCommand("clsCategoria_ObtenerId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            con.Open();
            clsCategoria obj = new clsCategoria();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdCategoria = (Int32)dr["IdCategoria"];
            }
            con.Close();
            return obj.IdCategoria;
        }

        public Boolean REGISTRARCATEGORIA(clsCategoria entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsCategoria_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdCategoria", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Profesion", entidad.Profesion);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdCategoria = (Int32)paramCODIGO.Value;
            return true;
        }

        public clsCategoria OBTENERPORID(Int32 IdCategoria)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsCategoria_ObtenerPorId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdCategoria", IdCategoria);
            con.Open();
            clsCategoria obj = new clsCategoria();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdCategoria = (Int32)dr["IdCategoria"];
                obj.Profesion = (Int32)dr["Profesion"];
                obj.Descripcion = dr["Descripcion"].ToString();
            }
            con.Close();
            return obj;
        }

        public List<clsCategoriaVISTA> OBTENERPORDESCRIPCION(String Descripcion,Int32 Profesion)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsCategoria_ObtenerPorDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("Profesion", Profesion);
            con.Open();
            List<clsCategoriaVISTA> coleccion = new List<clsCategoriaVISTA>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsCategoriaVISTA obj = new clsCategoriaVISTA();
                obj.IdCategoria = (Int32)dr["IdCategoria"];
                obj.Profesion = dr["Profesion"].ToString();
                obj.Descripcion = dr["Descripcion"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public Boolean ACTUALIZARPROFESION(clsCategoria entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsCategoria_ActualizarProfesion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdCategoria", entidad.IdCategoria);
            cmd.Parameters.AddWithValue("Profesion", entidad.Profesion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARDESCRIPCION(clsCategoria entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsCategoria_ActualizarDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdCategoria", entidad.IdCategoria);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ELIMINARCATEGORIA(clsCategoria entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsCategoria_Eliminar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdCategoria", entidad.IdCategoria);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
