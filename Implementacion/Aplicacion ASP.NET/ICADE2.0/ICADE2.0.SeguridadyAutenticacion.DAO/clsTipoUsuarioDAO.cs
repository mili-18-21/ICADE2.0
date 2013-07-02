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
    public class clsTipoUsuarioDAO
    {
        public List<clsTipoUsuario> LISTAR()
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsTipoUsuario_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            List<clsTipoUsuario> coleccion = new List<clsTipoUsuario>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsTipoUsuario obj = new clsTipoUsuario();
                obj.IdTipoUsuario = (Int32)dr["IdTipoUsuario"];
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
            SqlCommand cmd = new SqlCommand("clsTipoUsuario_ObtenerId_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Descripcion", Descripcion);
            con.Open();
            clsTipoUsuario obj = new clsTipoUsuario();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.IdTipoUsuario = (Int32)dr["IdTipoUsuario"];
            }
            con.Close();
            return obj.IdTipoUsuario;
        }
    }
}
