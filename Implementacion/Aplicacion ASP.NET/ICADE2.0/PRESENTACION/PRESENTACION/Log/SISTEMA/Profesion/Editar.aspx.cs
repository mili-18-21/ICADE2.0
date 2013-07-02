using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;
using ICADE2._0.SeguridadyAutenticacion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Profesion
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String C = Request.QueryString.Get("IdProfesion");
            Int32 IdProfesion = Convert.ToInt32(C);

            clsProfesion obj = new clsProfesion();
            clsProfesionGESTOR G = new clsProfesionGESTOR();
            obj = G.RetornarPorId(IdProfesion);
            Label1.Text = obj.Descripcion;
            if (obj.Estado == true)
            {
                Label2.Text = "Activo";
            }
            else
            {
                Label2.Text = "Inactivo";
            }
        }

        protected void Button1_actualizardescripcion_Click(object sender, EventArgs e)
        {
            if (Button1_actualizardescripcion.Text == "Editar descripcion")
            {
                TextBox1.Visible = true;
                Label1.Visible = false;
                Button1_actualizardescripcion.Text = "Guardar cambios";
                Button1_actualizardescripcion.BackColor = System.Drawing.Color.Red;
                Button1_actualizardescripcion.BorderColor = System.Drawing.Color.Red;

                Button2_editarestado.Enabled = false;
                Button2_editarestado.BackColor = System.Drawing.Color.LightGray;
                Button2_editarestado.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdProfesion");
                Int32 IdProfesion = Convert.ToInt32(C);

                clsProfesion obj = new clsProfesion();
                clsProfesionGESTOR G = new clsProfesionGESTOR();
                obj = G.RetornarPorId(IdProfesion);
                obj.Descripcion = TextBox1.Text;
                if (G.ActualizarDescripcion(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Profesion/Editar.aspx?IdProfesion="+obj.IdProfesion);
                }
            }
        }

        protected void Button2_editarestado_Click(object sender, EventArgs e)
        {
            if (Button2_editarestado.Text == "Editar estado")
            {
                String C = Request.QueryString.Get("IdProfesion");
                Int32 IdProfesion = Convert.ToInt32(C);

                clsProfesion obj = new clsProfesion();
                clsProfesionGESTOR G = new clsProfesionGESTOR();
                obj = G.RetornarPorId(IdProfesion);
                if (obj.Estado == true)
                {
                    CheckBox1.Checked = true;
                }
                
                CheckBox1.Visible = true;
                Label2.Visible = false;
                Button2_editarestado.Text = "Guardar cambios";
                Button2_editarestado.BackColor = System.Drawing.Color.Red;
                Button2_editarestado.BorderColor = System.Drawing.Color.Red;

                Button1_actualizardescripcion.Enabled = false;
                Button1_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdProfesion");
                Int32 IdProfesion = Convert.ToInt32(C);

                clsProfesion obj = new clsProfesion();
                clsProfesionGESTOR G = new clsProfesionGESTOR();
                obj = G.RetornarPorId(IdProfesion);
                obj.Estado = CheckBox1.Checked;
                if (G.ActualizarEstado(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Profesion/Editar.aspx?IdProfesion=" + obj.IdProfesion);
                }
            }
        }
    }
}