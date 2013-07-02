using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.Administracion.DAO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Tema
{
    public partial class Buscar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvCustomres_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            clsTemaDAO dao = new clsTemaDAO();
            gvCustomres.PageIndex = e.NewPageIndex;
            gvCustomres.DataSource = dao.OBTENERPORDESCRIPCION(TextBox1.Text);
            DataBind();
        }

        protected void gvCustomres_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Int32 index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCustomres.Rows[index];
                String i = Server.HtmlDecode(row.Cells[0].Text);

                Response.Redirect("Editar.aspx?IdTema=" + i);
            }
            if (e.CommandName == "Eliminar")
            {
                Int32 index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCustomres.Rows[index];
                String i = Server.HtmlDecode(row.Cells[0].Text);

                Response.Redirect("Eliminar.aspx?IdTema=" + i);
            }
        }

        protected void Button1_registrar_Click(object sender, EventArgs e)
        {
            clsTemaDAO dao = new clsTemaDAO();
            gvCustomres.DataSource = dao.OBTENERPORDESCRIPCION(TextBox1.Text);
            DataBind();
        }
    }
}