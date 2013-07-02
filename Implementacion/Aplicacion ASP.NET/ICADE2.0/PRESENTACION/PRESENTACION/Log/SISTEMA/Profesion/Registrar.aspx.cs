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
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_registrar_Click(object sender, EventArgs e)
        {
            clsProfesionGESTOR g = new clsProfesionGESTOR();
            clsProfesion pr = g.RegistrarNuevaProfesion(TextBox1.Text, CheckBox1.Checked);
            MessageBox.Show("La PROFESION "+pr.Descripcion+" ha sido registrada corecctamente.");
            Response.Redirect("/PRESENTACION/Log/SISTEMA/Profesion/Buscar.aspx");
        }
    }
}