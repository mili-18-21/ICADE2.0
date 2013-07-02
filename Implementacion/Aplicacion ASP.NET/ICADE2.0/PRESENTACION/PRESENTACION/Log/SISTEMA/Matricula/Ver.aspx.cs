using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;

using ICADE2._0.Matriculas.ENTIDADES;
using ICADE2._0.Matriculas.DAO;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;


namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Matricula
{
    public partial class Ver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String C = Request.QueryString.Get("IdDiplomado");
            Int32 IdDiplomado = Convert.ToInt32(C);

            clsDiplomado obj = new clsDiplomado();
            clsDiplomadoDAO DAO = new clsDiplomadoDAO();
            obj = DAO.OBTENERPORID(IdDiplomado);

            Label5.Text = obj.Descripcion;
            Label8.Text = Convert.ToString(obj.Matricula);
            Label13.Text = Convert.ToString(obj.Mensualidad);
            Label16.Text = Convert.ToString(obj.NumeroCuotas);
            Label20.Text = Convert.ToString(obj.HorasAcademicas);

            clsSeminarioDAO dao = new clsSeminarioDAO();
            GridView1.DataSource = dao.LISTARPORDIPLOMADO(obj.IdDiplomado);
            DataBind();
        }

        protected void Button1_Comprar_Click(object sender, EventArgs e)
        {
            clsMatricula obj = new clsMatricula();
            clsMatriculaDAO daoPR = new clsMatriculaDAO();

            clsUsuario objU = new clsUsuario();
            objU = (clsUsuario)(Session["Usuario"]);

            obj.Usuario = objU.IdUsuario;

            String C = Request.QueryString.Get("IdDiplomado");
            Int32 IdDiplomado = Convert.ToInt32(C);

            obj.Diplomado = IdDiplomado;

            clsMatriculaDAO dao = new clsMatriculaDAO();
            if (dao.REGISTRARMATRICULA(obj))
            {
                MessageBox.Show("Se ha registrado exitosamente en este DIPLOMADO");
                Response.Redirect("/PRESENTACION/Log/SISTEMA/Matricula/Registrar2.aspx");
            }
        }

        protected void gvCustomres_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvCustomres_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}