using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using ICADE2._0.SeguridadyAutenticacion.DAO;
using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;
using ICADE2._0.Administracion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Categoria
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsProfesionDAO dao = new clsProfesionDAO();
            DropDownList1.DataValueField = "IdProfesion";
            DropDownList1.DataTextField = "Descripcion";
            DropDownList1.DataSource = dao.LISTARACTIVOS();
            DropDownList1.DataBind();
        }

        protected void Button1_registrar_Click(object sender, EventArgs e)
        {
            clsCategoriaGESTOR g = new clsCategoriaGESTOR();
            clsCategoria pr = g.RegistrarNuevaCategoria(Convert.ToInt32(DropDownList1.SelectedValue), TextBox2.Text);
            MessageBox.Show("La CATEGORIA " + pr.Descripcion + " ha sido registrada corecctamente.");
            Response.Redirect("/PRESENTACION/Log/SISTEMA/Categoria/Buscar.aspx");
        }
    }
}