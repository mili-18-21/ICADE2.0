using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;
using ICADE2._0.SeguridadyAutenticacion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Administrador
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUsuario objU = new clsUsuario();
            objU = (clsUsuario)(Session["Usuario"]);

            Label1.Text = objU.Nombre;
            Label2.Text = objU.Apellidos;
            Label3.Text = objU.Email;
            Label4.Text = "●●●●●●●●●●●●";

            clsAdministrador P = new clsAdministrador();
            clsAdministradorGESTOR G = new clsAdministradorGESTOR();
            P = G.RecuperarAdministrador(objU.IdUsuario);
            Label5.Text = Convert.ToString(P.Sueldo);
        }

        protected void Button1_actualizarnombre_Click(object sender, EventArgs e)
        {
            if (Button1_actualizarnombre.Text == "Editar nombre")
            {
                TextBox1.Visible = true;
                Label1.Visible = false;
                Button1_actualizarnombre.Text = "Guardar cambios";
                Button1_actualizarnombre.BackColor = System.Drawing.Color.Red;
                Button1_actualizarnombre.BorderColor = System.Drawing.Color.Red;

                Button2_actualizarapellidos.Enabled = false;
                Button2_actualizarapellidos.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizarapellidos.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizaremail.Enabled = false;
                Button3_actualizaremail.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizaremail.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarcontraseña.Enabled = false;
                Button4_actualizarcontraseña.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarcontraseña.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarsueldo.Enabled = false;
                Button5_actualizarsueldo.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarsueldo.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsAdministradorGESTOR g = new clsAdministradorGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                obj.Nombre = TextBox1.Text;
                if (g.ActualizarNombre(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Administrador/Editar.aspx");
                }
            }
        }

        protected void Button2_actualizarapellidos_Click(object sender, EventArgs e)
        {
            if (Button2_actualizarapellidos.Text == "Editar apellidos")
            {
                TextBox2.Visible = true;
                Label2.Visible = false;
                Button2_actualizarapellidos.Text = "Guardar cambios";
                Button2_actualizarapellidos.BackColor = System.Drawing.Color.Red;
                Button2_actualizarapellidos.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarnombre.Enabled = false;
                Button1_actualizarnombre.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarnombre.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizaremail.Enabled = false;
                Button3_actualizaremail.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizaremail.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarcontraseña.Enabled = false;
                Button4_actualizarcontraseña.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarcontraseña.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarsueldo.Enabled = false;
                Button5_actualizarsueldo.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarsueldo.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsAdministradorGESTOR g = new clsAdministradorGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                obj.Apellidos = TextBox2.Text;
                if (g.ActualizarApellidos(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Administrador/Editar.aspx");
                }
            }
        }

        protected void Button3_actualizaremail_Click(object sender, EventArgs e)
        {
            if (Button3_actualizaremail.Text == "Editar email")
            {
                TextBox3.Visible = true;
                Label3.Visible = false;
                Button3_actualizaremail.Text = "Guardar cambios";
                Button3_actualizaremail.BackColor = System.Drawing.Color.Red;
                Button3_actualizaremail.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarnombre.Enabled = false;
                Button1_actualizarnombre.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarnombre.BorderColor = System.Drawing.Color.LightGray;

                Button2_actualizarapellidos.Enabled = false;
                Button2_actualizarapellidos.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizarapellidos.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarcontraseña.Enabled = false;
                Button4_actualizarcontraseña.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarcontraseña.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarsueldo.Enabled = false;
                Button5_actualizarsueldo.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarsueldo.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsAdministradorGESTOR g = new clsAdministradorGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                obj.Email = TextBox3.Text;
                if (g.ActualizarEmail(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Administrador/Editar.aspx");
                }
            }
        }

        protected void Button4_actualizarcontraseña_Click(object sender, EventArgs e)
        {
            if (Button4_actualizarcontraseña.Text == "Editar contraseña")
            {
                TextBox4.Visible = true;
                Label4.Visible = false;
                Button4_actualizarcontraseña.Text = "Guardar cambios";
                Button4_actualizarcontraseña.BackColor = System.Drawing.Color.Red;
                Button4_actualizarcontraseña.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarnombre.Enabled = false;
                Button1_actualizarnombre.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarnombre.BorderColor = System.Drawing.Color.LightGray;

                Button2_actualizarapellidos.Enabled = false;
                Button2_actualizarapellidos.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizarapellidos.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizaremail.Enabled = false;
                Button3_actualizaremail.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizaremail.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarsueldo.Enabled = false;
                Button5_actualizarsueldo.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarsueldo.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsAdministradorGESTOR g = new clsAdministradorGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                obj.Contraseña = TextBox4.Text;
                if (g.ActualizarContraseña(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Administrador/Editar.aspx");
                }
            }
        }

        protected void Button5_actualizarsueldo_Click(object sender, EventArgs e)
        {
            if (Button5_actualizarsueldo.Text == "Editar sueldo")
            {
                TextBox5.Visible = true;
                Label5.Visible = false;
                Button5_actualizarsueldo.Text = "Guardar cambios";
                Button5_actualizarsueldo.BackColor = System.Drawing.Color.Red;
                Button5_actualizarsueldo.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarnombre.Enabled = false;
                Button1_actualizarnombre.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarnombre.BorderColor = System.Drawing.Color.LightGray;

                Button2_actualizarapellidos.Enabled = false;
                Button2_actualizarapellidos.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizarapellidos.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizaremail.Enabled = false;
                Button3_actualizaremail.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizaremail.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarcontraseña.Enabled = false;
                Button4_actualizarcontraseña.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarcontraseña.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsAdministradorGESTOR g = new clsAdministradorGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                if (g.ActualizarSueldo(obj, Convert.ToDecimal(TextBox5.Text)))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Administrador/Editar.aspx");
                }
            }
        }
    }
}