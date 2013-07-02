using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;
using ICADE2._0.SeguridadyAutenticacion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.NLog.SISTEMA
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void Button1_login_Click(object sender, EventArgs e)
        {
            clsParticipanteGESTOR GESTP = new clsParticipanteGESTOR();
            Session["Usuario"] = GESTP.IniciarSesion(TextBox1.Text, TextBox2.Text);
            clsUsuario Usuario = (clsUsuario)Session["Usuario"];
            if (Usuario.Contraseña == "0")
            {
                Label4.Text = "Correo y/o contraseña incorrectos";
            }
            if (Usuario.Contraseña == "1")
            {
                Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
            }
            if (Usuario.Contraseña == "2")
            {
                Response.Redirect("/PRESENTACION/Log/SISTEMA/Administrador/Editar.aspx");
            }
        }
    }
}