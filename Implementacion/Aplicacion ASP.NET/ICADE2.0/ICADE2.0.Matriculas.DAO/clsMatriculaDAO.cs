using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using ICADE2._0.Matriculas.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;

namespace ICADE2._0.Matriculas.DAO
{
    public class clsMatriculaDAO
    {
        public Boolean REGISTRARMATRICULA(clsMatricula entidad)
        {
            SqlConnection con = new SqlConnection();
            clsConexionDAO Conexion = new clsConexionDAO();
            String cadena = Conexion.OBTENERCADENA();
            con.ConnectionString = cadena;
            SqlCommand cmd = new SqlCommand("clsMatricula_Registrar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramCODIGO = new SqlParameter("IdMatricula", SqlDbType.Int, 8);
            paramCODIGO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramCODIGO);
            cmd.Parameters.AddWithValue("Usuario", entidad.Usuario);
            cmd.Parameters.AddWithValue("Diplomado", entidad.Diplomado);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            entidad.IdMatricula = (Int32)paramCODIGO.Value;
            return true;
        }
    }
}
