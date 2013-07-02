using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;

namespace PRESENTACION.PRESENTACION.PaginasMaestras.Log.MenuHead
{
    public partial class MenuHeadAD : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUsuario objU = new clsUsuario();
            objU = (clsUsuario)(Session["Usuario"]);

            Label1.Text = objU.Nombre;
            Label3.Text = objU.Apellidos;
        }
    }
}