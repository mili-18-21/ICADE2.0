using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.Administracion.DAO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.MisCursos
{
    public partial class MisCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUsuario objU = new clsUsuario();
            objU = (clsUsuario)(Session["Usuario"]);

            clsDiplomadoDAO dao = new clsDiplomadoDAO();
            GridView1.DataSource = dao.LISTARPORUSUARIO(objU.IdUsuario);
            DataBind();
        }

        protected void gvCustomres_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvCustomres_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}