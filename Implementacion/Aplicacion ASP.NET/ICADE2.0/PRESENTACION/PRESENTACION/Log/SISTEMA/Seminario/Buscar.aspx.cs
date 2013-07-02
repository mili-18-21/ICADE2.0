using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;
using ICADE2._0.Administracion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Seminario
{
    public partial class Buscar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeminarioGESTOR dao = new clsSeminarioGESTOR();
            gvCustomres.DataSource = dao.ListarPorDescripcion(TextBox1.Text);
            DataBind();
        }

        protected void gvCustomres_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            clsSeminarioGESTOR dao = new clsSeminarioGESTOR();
            gvCustomres.PageIndex = e.NewPageIndex;
            gvCustomres.DataSource = dao.ListarPorDescripcion(TextBox1.Text);
            DataBind();
        }

        protected void gvCustomres_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Int32 index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCustomres.Rows[index];
                String i = Server.HtmlDecode(row.Cells[0].Text);

                Response.Redirect("Editar.aspx?IdSeminario=" + i);
            }
            if (e.CommandName == "Eliminar")
            {
                Int32 index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCustomres.Rows[index];
                String i = Server.HtmlDecode(row.Cells[0].Text);

                if (MessageBox.Show("Realmente deseas eliminar este seminario?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Int32 IdSeminario = Convert.ToInt32(i);

                    clsSeminario obj = new clsSeminario();
                    clsSeminarioGESTOR g = new clsSeminarioGESTOR();
                    if (g.EliminarSeminario(IdSeminario))
                    {
                        Response.Redirect("Buscar.aspx");
                    }
                }
            }
        }

        protected void Button1_registrar_Click(object sender, EventArgs e)
        {
            clsSeminarioGESTOR dao = new clsSeminarioGESTOR();
            gvCustomres.DataSource = dao.ListarPorDescripcion(TextBox1.Text);
            DataBind();
        }
    }
}