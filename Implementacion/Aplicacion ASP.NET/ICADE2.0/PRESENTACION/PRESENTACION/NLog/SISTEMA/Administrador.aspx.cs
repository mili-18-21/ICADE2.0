using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Windows.Forms;

using ICADE2._0.SeguridadyAutenticacion.NEGOCIO;
using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;

namespace PRESENTACION.PRESENTACION.NLog.SISTEMA
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            clsUsuario u = new clsUsuario();
            clsAdministradorGESTOR GESTP = new clsAdministradorGESTOR();
            u = GESTP.RegistrarNuevoAdministrador(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            if(u.IdUsuario!=0)
            {
                MessageBox.Show("Te has registrado como administrador, ahora espera a que tu cuenta sea dada de alta");
                Response.Redirect("/PRESENTACION/NLog/SISTEMA/Login.aspx");
            }
        }
    }
}