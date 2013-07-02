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
    public class clsAdministradorDAO
    {
        public Boolean REGISTRARADMINISTRADOR(clsAdministrador entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsAdministrador_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdAdministrador", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Usuario", entidad.Usuario);
            cmd.Parameters.AddWithValue("Sueldo", entidad.Sueldo);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdAdministrador = (Int32)paramCODIGO.Value;
            return true;
        }

        public Boolean ACTUALIZARSUELDO(clsAdministrador entidad)
        {
            SqlConnection con = new SqlConnection(); ;
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsAdministrador_ActualizarSueldo_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdAdministrador", entidad.IdAdministrador);
            cmd.Parameters.AddWithValue("Sueldo", entidad.Sueldo);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public clsAdministrador OBTENERPORUSUARIO(Int32 Usuario)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsAdministrador_ObtenerPorUsuario_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Usuario", Usuario);
            con.Open();
            clsAdministrador obj = new clsAdministrador();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdAdministrador = (Int32)dr["IdAdministrador"];
                obj.Usuario = (Int32)dr["Usuario"];
                obj.Sueldo = (Decimal)dr["Sueldo"];
            }
            con.Close();
            return obj;
        }
    }
}
