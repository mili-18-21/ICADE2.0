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
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String C = Request.QueryString.Get("IdTema");
            Int32 IdTema = Convert.ToInt32(C);

            clsTema obj = new clsTema();
            clsTemaDAO DAO = new clsTemaDAO();
            obj = DAO.OBTENERPORID(IdTema);

            clsSeminario objP = new clsSeminario();
            clsSeminarioDAO daoP = new clsSeminarioDAO();
            objP = daoP.OBTENERPORID(obj.Seminario);

            Label1.Text = objP.Descripcion;
            Label2.Text = obj.Descripcion;
        }

        protected void Button1_actualizarsemiario_Click(object sender, EventArgs e)
        {
            if (Button1_actualizarsemiario.Text == "Editar seminario")
            {
                DropDownList1.Visible = true;
                Label1.Visible = false;
                Button1_actualizarsemiario.Text = "Guardar cambios";
                Button1_actualizarsemiario.BackColor = System.Drawing.Color.Red;
                Button1_actualizarsemiario.BorderColor = System.Drawing.Color.Red;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                clsSeminarioDAO dao = new clsSeminarioDAO();
                DropDownList1.DataValueField = "IdSeminario";
                DropDownList1.DataTextField = "Descripcion";
                DropDownList1.DataSource = dao.LISTAR();
                DropDownList1.DataBind();
            }
            else
            {
                String C = Request.QueryString.Get("IdTema");
                Int32 IdTema = Convert.ToInt32(C);

                clsTema obj = new clsTema();
                clsTemaDAO DAO = new clsTemaDAO();
                obj = DAO.OBTENERPORID(IdTema);

                obj.Seminario = Convert.ToInt32(DropDownList1.SelectedValue);
                if (DAO.ACTUALIZARSEMINARIO(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Tema/Editar.aspx?IdTema=" + obj.IdTema);
                }
            }
        }

        protected void Button2_actualizardescripcion_Click(object sender, EventArgs e)
        {
            if (Button2_actualizardescripcion.Text == "Editar descripcion")
            {
                TextBox2.Visible = true;
                Label2.Visible = false;
                Button2_actualizardescripcion.Text = "Guardar cambios";
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.Red;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarsemiario.Enabled = false;
                Button1_actualizarsemiario.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarsemiario.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdTema");
                Int32 IdTema = Convert.ToInt32(C);

                clsTema obj = new clsTema();
                clsTemaDAO dao = new clsTemaDAO();
                obj = dao.OBTENERPORID(IdTema);
                obj.Descripcion = TextBox2.Text;
                if (dao.ACTUALIZARDESCRIPCION(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Tema/Editar.aspx?IdTema=" + obj.IdTema);
                }
            }
        }
    }
}