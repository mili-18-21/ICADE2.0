using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Tema
{
    public partial class Registrado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String C = Request.QueryString.Get("IdTema");
            Int32 IdTema = Convert.ToInt32(C);

            clsTema obj = new clsTema();
            clsTemaDAO DAO = new clsTemaDAO();
            obj = DAO.OBTENERPORID(IdTema);
            Label2.Text = obj.Descripcion;
        }
    }
}