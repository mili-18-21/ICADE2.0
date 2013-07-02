using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;
using ICADE2._0.Administracion.NEGOCIO;
using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;
using ICADE2._0.SeguridadyAutenticacion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Categoria
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String C = Request.QueryString.Get("IdCategoria");
            Int32 IdCategoria = Convert.ToInt32(C);

            clsCategoria obj = new clsCategoria();
            clsCategoriaGESTOR g = new clsCategoriaGESTOR();
            obj = g.RetornarPorId(IdCategoria);

            clsProfesion objP = new clsProfesion();
            clsProfesionGESTOR GP = new clsProfesionGESTOR();
            objP = GP.RetornarPorId(obj.Profesion);

            Label1.Text = objP.Descripcion;
            Label2.Text = obj.Descripcion;
        }

        protected void Button1_actualizarprofesion_Click(object sender, EventArgs e)
        {
            if (Button1_actualizarprofesion.Text == "Editar profesion")
            {
                DropDownList1.Visible = true;
                Label1.Visible = false;
                Button1_actualizarprofesion.Text = "Guardar cambios";
                Button1_actualizarprofesion.BackColor = System.Drawing.Color.Red;
                Button1_actualizarprofesion.BorderColor = System.Drawing.Color.Red;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                clsProfesionDAO dao = new clsProfesionDAO();
                DropDownList1.DataValueField = "IdProfesion";
                DropDownList1.DataTextField = "Descripcion";
                DropDownList1.DataSource = dao.LISTARACTIVOS();
                DropDownList1.DataBind();
            }
            else
            {
                String C = Request.QueryString.Get("IdCategoria");
                Int32 IdCategoria = Convert.ToInt32(C);

                clsCategoria obj = new clsCategoria();
                clsCategoriaGESTOR G = new clsCategoriaGESTOR();
                obj = G.RetornarPorId(IdCategoria);
                if (G.ActualizarProfesion(obj, Convert.ToInt32(DropDownList1.SelectedValue)))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Categoria/Editar.aspx?IdCategoria=" + obj.IdCategoria);
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

                Button1_actualizarprofesion.Enabled = false;
                Button1_actualizarprofesion.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarprofesion.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdCategoria");
                Int32 IdCategoria = Convert.ToInt32(C);

                clsCategoria obj = new clsCategoria();
                clsCategoriaGESTOR G = new clsCategoriaGESTOR();
                obj = G.RetornarPorId(IdCategoria);
                if (G.ActualizarDescripcion(obj, TextBox2.Text))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Categoria/Editar.aspx?IdCategoria=" + obj.IdCategoria);
                }
            }
        }
    }
}