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
    public class clsDiplomadoDAO
    {
        public Int32 OBTENERID(String Descripcion)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ObtenerId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            con.Open();
            clsDiplomado obj = new clsDiplomado();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdDiplomado = (Int32)dr["IdDiplomado"];
            }
            con.Close();
            return obj.IdDiplomado;
        }

        public List<clsDiplomado> LISTAR()
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            List<clsDiplomado> coleccion = new List<clsDiplomado>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsDiplomado obj = new clsDiplomado();
                obj.IdDiplomado = (Int32)dr["IdDiplomado"];
                obj.Descripcion = dr["Descripcion"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public Boolean ELIMINARDIPLOMADO(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_Eliminar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", entidad.IdDiplomado);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARCATEGORIA(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ActualizarCategoria_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", entidad.IdDiplomado);
            cmd.Parameters.AddWithValue("Categoria", entidad.Categoria);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARDESCRIPCION(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ActualizarDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", entidad.IdDiplomado);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARMATRICULA(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ActualizarMatricula_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", entidad.IdDiplomado);
            cmd.Parameters.AddWithValue("Matricula", entidad.Matricula);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARMENSUALIDAD(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ActualizarMensualidad_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", entidad.IdDiplomado);
            cmd.Parameters.AddWithValue("Mensualidad", entidad.Mensualidad);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARNUMEROCUOTAS(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ActualizarNumeroCuotas_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", entidad.IdDiplomado);
            cmd.Parameters.AddWithValue("NumeroCuotas", entidad.NumeroCuotas);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARHORASACADEMICAS(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ActualizarHorasAcademicas_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", entidad.IdDiplomado);
            cmd.Parameters.AddWithValue("HorasAcademicas", entidad.HorasAcademicas);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean ACTUALIZARIMAGEN(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ActualizarImagen_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", entidad.IdDiplomado);
            cmd.Parameters.AddWithValue("Imagen", entidad.Imagen);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public Boolean REGISTRARDIPLOMADO(clsDiplomado entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdDiplomado", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Categoria", entidad.Categoria);
            cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
            cmd.Parameters.AddWithValue("Matricula", entidad.Matricula);
            cmd.Parameters.AddWithValue("Mensualidad", entidad.Mensualidad);
            cmd.Parameters.AddWithValue("NumeroCuotas", entidad.NumeroCuotas);
            cmd.Parameters.AddWithValue("HorasAcademicas", entidad.HorasAcademicas);
            cmd.Parameters.AddWithValue("Imagen", entidad.Imagen);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdDiplomado = (Int32)paramCODIGO.Value;
            return true;
        }

        public clsDiplomado OBTENERPORID(Int32 IdDiplomado)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ObtenerPorId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdDiplomado", IdDiplomado);
            con.Open();
            clsDiplomado obj = new clsDiplomado();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdDiplomado = (Int32)dr["IdDiplomado"];
                obj.Categoria = (Int32)dr["Categoria"];
                obj.Descripcion = dr["Descripcion"].ToString();
                obj.Matricula = (Decimal)dr["Matricula"];
                obj.Mensualidad = (Decimal)dr["Mensualidad"];
                obj.NumeroCuotas = (Int32)dr["NumeroCuotas"];
                obj.HorasAcademicas = (Int32)dr["HorasAcademicas"];
                obj.Imagen = dr["Imagen"].ToString();
            }
            con.Close();
            return obj;
        }

        public List<clsDiplomado> OBTENERPORDESCRIPCION(String Descripcion)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ObtenerPorDescripcion_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            con.Open();
            List<clsDiplomado> coleccion = new List<clsDiplomado>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsDiplomado obj = new clsDiplomado();
                obj.IdDiplomado = (Int32)dr["IdDiplomado"];
                obj.Categoria = (Int32)dr["Categoria"];
                obj.Descripcion = dr["Descripcion"].ToString();
                obj.Matricula = (Decimal)dr["Matricula"];
                obj.Mensualidad = (Decimal)dr["Mensualidad"];
                obj.NumeroCuotas = (Int32)dr["NumeroCuotas"];
                obj.HorasAcademicas = (Int32)dr["HorasAcademicas"];
                obj.Imagen = dr["Imagen"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }

        public List<clsDiplomado> LISTARPORUSUARIO(Int32 IdUsuario)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsDiplomado_ListarPorUsuario_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Usuario", IdUsuario);
            con.Open();
            List<clsDiplomado> coleccion = new List<clsDiplomado>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsDiplomado obj = new clsDiplomado();
                obj.IdDiplomado = (Int32)dr["IdDiplomado"];
                obj.Categoria = (Int32)dr["Categoria"];
                obj.Descripcion = dr["Descripcion"].ToString();
                obj.Matricula = (Decimal)dr["Matricula"];
                obj.Mensualidad = (Decimal)dr["Mensualidad"];
                obj.NumeroCuotas = (Int32)dr["NumeroCuotas"];
                obj.HorasAcademicas = (Int32)dr["HorasAcademicas"];
                obj.Imagen = dr["Imagen"].ToString();
                coleccion.Add(obj);
            }
            con.Close();
            return coleccion;
        }
    }
}
