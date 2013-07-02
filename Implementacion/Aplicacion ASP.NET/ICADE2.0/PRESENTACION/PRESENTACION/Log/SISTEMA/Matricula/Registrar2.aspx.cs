using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Matricula
{
    public partial class Registrar2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                SqlDataSource s = (SqlDataSource)e.Row.FindControl("SqlDataSource2");
                s.SelectParameters[0].DefaultValue = e.Row.Cells[0].Text;
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Ver")
            {
                Int32 index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                String i = Server.HtmlDecode(row.Cells[0].Text);

                Response.Redirect("Ver.aspx?IdDiplomado=" + i);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}