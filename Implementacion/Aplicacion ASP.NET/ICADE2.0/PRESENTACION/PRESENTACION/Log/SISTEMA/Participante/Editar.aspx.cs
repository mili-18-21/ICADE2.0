using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.SeguridadyAutenticacion.ENTIDADES;
using ICADE2._0.SeguridadyAutenticacion.DAO;
using ICADE2._0.SeguridadyAutenticacion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Participante
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

            clsParticipante P = new clsParticipante();
            clsParticipanteGESTOR G = new clsParticipanteGESTOR();
            P = G.RecuperarParticipante(objU.IdUsuario);

            clsProfesion PR = new clsProfesion();
            clsProfesionGESTOR GP = new clsProfesionGESTOR();
            PR = GP.RetornarPorId(P.Profesion);

            Label5.Text = Convert.ToString(PR.Descripcion);
            Label6.Text = P.Direccion;
            Label7.Text = P.Telefono;
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

                Button5_actualizarprofesion.Enabled = false;
                Button5_actualizarprofesion.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarprofesion.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizardireccion.Enabled = false;
                Button6_actualizardireccion.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizardireccion.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizartelefono.Enabled = false;
                Button7_actualizartelefono.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizartelefono.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsParticipanteGESTOR g = new clsParticipanteGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                obj.Nombre = TextBox1.Text;
                if (g.ActualizarNombre(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
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

                Button5_actualizarprofesion.Enabled = false;
                Button5_actualizarprofesion.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarprofesion.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizardireccion.Enabled = false;
                Button6_actualizardireccion.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizardireccion.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizartelefono.Enabled = false;
                Button7_actualizartelefono.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizartelefono.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsParticipanteGESTOR g = new clsParticipanteGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                obj.Apellidos = TextBox2.Text;
                if (g.ActualizarApellidos(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
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

                Button5_actualizarprofesion.Enabled = false;
                Button5_actualizarprofesion.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarprofesion.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizardireccion.Enabled = false;
                Button6_actualizardireccion.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizardireccion.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizartelefono.Enabled = false;
                Button7_actualizartelefono.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizartelefono.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsParticipanteGESTOR g = new clsParticipanteGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                obj.Email = TextBox3.Text;
                if (g.ActualizarEmail(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
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

                Button5_actualizarprofesion.Enabled = false;
                Button5_actualizarprofesion.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarprofesion.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizardireccion.Enabled = false;
                Button6_actualizardireccion.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizardireccion.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizartelefono.Enabled = false;
                Button7_actualizartelefono.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizartelefono.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsParticipanteGESTOR g = new clsParticipanteGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                obj.Contraseña = TextBox4.Text;
                if (g.ActualizarContraseña(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
                }
            }
        }

        protected void Button5_actualizarprofesion_Click(object sender, EventArgs e)
        {
            if (Button5_actualizarprofesion.Text == "Editar profesion")
            {
                DropDownList1.Visible = true;
                Label5.Visible = false;
                Button5_actualizarprofesion.Text = "Guardar cambios";
                Button5_actualizarprofesion.BackColor = System.Drawing.Color.Red;
                Button5_actualizarprofesion.BorderColor = System.Drawing.Color.Red;

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

                Button6_actualizardireccion.Enabled = false;
                Button6_actualizardireccion.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizardireccion.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizartelefono.Enabled = false;
                Button7_actualizartelefono.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizartelefono.BorderColor = System.Drawing.Color.LightGray;

                clsProfesionDAO dao = new clsProfesionDAO();
                DropDownList1.DataValueField = "IdProfesion";
                DropDownList1.DataTextField = "Descripcion";
                DropDownList1.DataSource = dao.LISTARACTIVOS();
                DropDownList1.DataBind();
            }
            else
            {
                clsParticipanteGESTOR g = new clsParticipanteGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                if (g.ActualizarProfesion(obj,Convert.ToInt32(DropDownList1.SelectedValue)))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
                }
            }
        }

        protected void Button6_actualizardireccion_Click(object sender, EventArgs e)
        {
            if (Button6_actualizardireccion.Text == "Editar direccion")
            {
                TextBox6.Visible = true;
                Label6.Visible = false;
                Button6_actualizardireccion.Text = "Guardar cambios";
                Button6_actualizardireccion.BackColor = System.Drawing.Color.Red;
                Button6_actualizardireccion.BorderColor = System.Drawing.Color.Red;

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

                Button5_actualizarprofesion.Enabled = false;
                Button5_actualizarprofesion.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarprofesion.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizartelefono.Enabled = false;
                Button7_actualizartelefono.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizartelefono.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsParticipanteGESTOR g = new clsParticipanteGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                if (g.ActualizarDireccion(obj, TextBox6.Text))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
                }
            }
        }

        protected void Button7_actualizartelefono_Click(object sender, EventArgs e)
        {
            if (Button7_actualizartelefono.Text == "Editar telefono")
            {
                TextBox7.Visible = true;
                Label7.Visible = false;
                Button7_actualizartelefono.Text = "Guardar cambios";
                Button7_actualizartelefono.BackColor = System.Drawing.Color.Red;
                Button7_actualizartelefono.BorderColor = System.Drawing.Color.Red;

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

                Button5_actualizarprofesion.Enabled = false;
                Button5_actualizarprofesion.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarprofesion.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizardireccion.Enabled = false;
                Button6_actualizardireccion.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizardireccion.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                clsParticipanteGESTOR g = new clsParticipanteGESTOR();
                clsUsuario obj = new clsUsuario();
                obj = (clsUsuario)(Session["Usuario"]);
                if (g.ActualizarTelefono(obj, TextBox7.Text))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Participante/Editar.aspx");
                }
            }
        }
    }
}