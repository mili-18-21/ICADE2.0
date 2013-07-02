using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.SeguridadyAutenticacion.DAO;
using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.NLog.SISTEMA
{
    public partial class Registrate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsProfesionDAO dao = new clsProfesionDAO();
            DropDownList1.DataValueField = "IdProfesion";
            DropDownList1.DataTextField = "Descripcion";
            DropDownList1.DataSource = dao.LISTARACTIVOS();
            DropDownList1.DataBind();
        }

        protected void Button1_registrate_Click(object sender, EventArgs e)
        {
            clsParticipanteGESTOR GESTP = new clsParticipanteGESTOR();
            Session["Usuario"] = GESTP.RegistrarNuevoParticipante(TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text,Convert.ToInt32(DropDownList1.SelectedValue),TextBox5.Text,TextBox6.Text);
            clsUsuario Usuario = (clsUsuario)Session["Usuario"];
            Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
        }
    }
}