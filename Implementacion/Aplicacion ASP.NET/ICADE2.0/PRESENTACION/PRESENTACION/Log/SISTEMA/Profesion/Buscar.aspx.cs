using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;
using ICADE2._0.SeguridadyAutenticacion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Profesion
{
    public partial class Buscar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsProfesionGESTOR g = new clsProfesionGESTOR();
            gvCustomres.DataSource = g.ListarPorDescripcion(TextBox1.Text,Convert.ToInt32(DropDownList1.SelectedValue));
            DataBind();
        }

        protected void gvCustomres_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            clsProfesionGESTOR g = new clsProfesionGESTOR();
            gvCustomres.PageIndex = e.NewPageIndex;
            gvCustomres.DataSource = g.ListarPorDescripcion(TextBox1.Text,0);
            DataBind();
        }

        protected void gvCustomres_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Int32 index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCustomres.Rows[index];
                String i = Server.HtmlDecode(row.Cells[0].Text);

                Response.Redirect("Editar.aspx?IdProfesion=" + i);
            }
            
            if (e.CommandName == "Eliminar")
            {
                Int32 index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCustomres.Rows[index];
                String i = Server.HtmlDecode(row.Cells[0].Text);

                if (MessageBox.Show("Realmente deseas eliminar esta profesion?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Int32 IdProfesion = Convert.ToInt32(i);

                    clsProfesion obj = new clsProfesion();
                    clsProfesionGESTOR g = new clsProfesionGESTOR();
                    if (g.EliminarProfesion(IdProfesion))
                    {
                        Response.Redirect("Buscar.aspx");
                    }
                }
            }
        }

        protected void Button1_registrar_Click(object sender, EventArgs e)
        {
            clsProfesionGESTOR g = new clsProfesionGESTOR();
            gvCustomres.DataSource = g.ListarPorDescripcion(TextBox1.Text,Convert.ToInt32(DropDownList1.SelectedValue));
            DataBind();
        }
    }
}