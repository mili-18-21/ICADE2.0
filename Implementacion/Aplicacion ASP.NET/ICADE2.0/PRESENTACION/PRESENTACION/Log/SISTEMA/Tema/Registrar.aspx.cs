using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.Administracion.DAO;
using ICADE2._0.Administracion.ENTIDADES;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Tema
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeminarioDAO dao = new clsSeminarioDAO();
            DropDownList1.DataValueField = "IdSeminario";
            DropDownList1.DataTextField = "Descripcion";
            DropDownList1.DataSource = dao.LISTAR();
            DropDownList1.DataBind();
        }

        protected void Button1_registrar_Click(object sender, EventArgs e)
        {
            clsTema obj = new clsTema();

            //obj.Profesion = Convert.ToInt32(DropDownList1.SelectedValue);

            clsSeminarioDAO daoPR = new clsSeminarioDAO();
            obj.Seminario = daoPR.OBTENERID("Aspectos Generales");

            obj.Descripcion = TextBox2.Text;

            clsTemaDAO dao = new clsTemaDAO();
            if (dao.REGISTRARTEMA(obj))
            {
                Response.Redirect("/PRESENTACION/Log/SISTEMA/Tema/Registrado.aspx?IdTema=" + obj.IdTema);
            }
        }
    }
}