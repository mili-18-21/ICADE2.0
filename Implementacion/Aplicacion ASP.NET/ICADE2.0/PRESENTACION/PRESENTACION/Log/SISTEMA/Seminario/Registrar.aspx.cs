using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using ICADE2._0.Administracion.DAO;
using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Seminario
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsDiplomadoDAO dao = new clsDiplomadoDAO();
            DropDownList1.DataValueField = "IdDiplomado";
            DropDownList1.DataTextField = "Descripcion";
            DropDownList1.DataSource = dao.LISTAR();
            DropDownList1.DataBind();
        }

        protected void Button1_registrar_Click(object sender, EventArgs e)
        {
            clsSeminarioGESTOR g = new clsSeminarioGESTOR();
            clsSeminario pr = g.RegistrarNuevoSeminario(Convert.ToInt32(DropDownList1.SelectedValue), TextBox2.Text);
            MessageBox.Show("El SEMINARIO " + pr.Descripcion + " ha sido registrada corecctamente.");
            Response.Redirect("/PRESENTACION/Log/SISTEMA/Seminario/Buscar.aspx");
        }
    }
}