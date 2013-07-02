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

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Diplomado
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsCategoriaDAO dao = new clsCategoriaDAO();
            DropDownList1.DataValueField = "IdCategoria";
            DropDownList1.DataTextField = "Descripcion";
            DropDownList1.DataSource = dao.LISTAR();
            DropDownList1.DataBind();
        }

        protected void Button1_registrar_Click(object sender, EventArgs e)
        {
            clsDiplomadoGESTOR g = new clsDiplomadoGESTOR();
            clsDiplomado pr = g.RegistrarNuevoDiplomado(Convert.ToInt32(DropDownList1.SelectedValue), TextBox2.Text, Convert.ToDecimal(TextBox3.Text), Convert.ToDecimal(TextBox4.Text), Convert.ToInt32(TextBox5.Text), Convert.ToInt32(TextBox6.Text), "~/Imagenes/Diplomado/" + FileUpload1.FileName);
            MessageBox.Show("El DIPLOMADO " + pr.Descripcion + " ha sido registrada corecctamente.");
            Response.Redirect("/PRESENTACION/Log/SISTEMA/Diplomado/Buscar.aspx");
        }
    }
}