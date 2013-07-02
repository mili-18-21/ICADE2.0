using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;
using ICADE2._0.Administracion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Diplomado
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String C = Request.QueryString.Get("IdDiplomado");
            Int32 IdDiplomado = Convert.ToInt32(C);

            clsDiplomado obj = new clsDiplomado();
            clsDiplomadoGESTOR g = new clsDiplomadoGESTOR();
            obj = g.RetornarPorId(IdDiplomado);

            clsCategoria objC = new clsCategoria();
            clsCategoriaGESTOR GCA = new clsCategoriaGESTOR();
            objC = GCA.RetornarPorId(obj.Categoria);

            Label1.Text = objC.Descripcion;
            Label2.Text = obj.Descripcion;
            Label3.Text = Convert.ToString(obj.Matricula);
            Label4.Text = Convert.ToString(obj.Mensualidad);
            Label5.Text = Convert.ToString(obj.NumeroCuotas);
            Label6.Text = Convert.ToString(obj.HorasAcademicas);
            Label7.Text = "Imagen";
            Image1.ImageUrl = obj.Imagen;
        }

        protected void Button1_actualizarcategoria_Click(object sender, EventArgs e)
        {
            if (Button1_actualizarcategoria.Text == "Editar categoria")
            {
                DropDownList1.Visible = true;
                Label1.Visible = false;
                Button1_actualizarcategoria.Text = "Guardar cambios";
                Button1_actualizarcategoria.BackColor = System.Drawing.Color.Red;
                Button1_actualizarcategoria.BorderColor = System.Drawing.Color.Red;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizarmatricula.Enabled = false;
                Button3_actualizarmatricula.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizarmatricula.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarmensualidad.Enabled = false;
                Button4_actualizarmensualidad.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarmensualidad.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarnumerocuotas.Enabled = false;
                Button5_actualizarnumerocuotas.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarnumerocuotas.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizarhorasacademicas.Enabled = false;
                Button6_actualizarhorasacademicas.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizarhorasacademicas.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizarimagen.Enabled = false;
                Button7_actualizarimagen.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizarimagen.BorderColor = System.Drawing.Color.LightGray;

                clsCategoriaDAO dao = new clsCategoriaDAO();
                DropDownList1.DataValueField = "IdCategoria";
                DropDownList1.DataTextField = "Descripcion";
                DropDownList1.DataSource = dao.LISTAR();
                DropDownList1.DataBind();
            }
            else
            {
                String C = Request.QueryString.Get("IdDiplomado");
                Int32 IdDiplomado = Convert.ToInt32(C);

                clsDiplomado obj = new clsDiplomado();
                clsDiplomadoGESTOR G = new clsDiplomadoGESTOR();
                obj = G.RetornarPorId(IdDiplomado);
                obj.Categoria=Convert.ToInt32(DropDownList1.SelectedValue);
                if (G.ActualizarCategoria(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Diplomado/Editar.aspx?IdDiplomado=" + obj.IdDiplomado);
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

                Button1_actualizarcategoria.Enabled = false;
                Button1_actualizarcategoria.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarcategoria.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizarmatricula.Enabled = false;
                Button3_actualizarmatricula.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizarmatricula.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarmensualidad.Enabled = false;
                Button4_actualizarmensualidad.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarmensualidad.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarnumerocuotas.Enabled = false;
                Button5_actualizarnumerocuotas.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarnumerocuotas.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizarhorasacademicas.Enabled = false;
                Button6_actualizarhorasacademicas.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizarhorasacademicas.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizarimagen.Enabled = false;
                Button7_actualizarimagen.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizarimagen.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdDiplomado");
                Int32 IdDiplomado = Convert.ToInt32(C);

                clsDiplomado obj = new clsDiplomado();
                clsDiplomadoGESTOR dao = new clsDiplomadoGESTOR();
                obj = dao.RetornarPorId(IdDiplomado);
                obj.Descripcion = TextBox2.Text;
                if (dao.ActualizarDescripcion(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Diplomado/Editar.aspx?IdDiplomado=" + obj.IdDiplomado);
                }
            }
        }

        protected void Button3_actualizarmatricula_Click(object sender, EventArgs e)
        {
            if (Button3_actualizarmatricula.Text == "Editar matricula")
            {
                TextBox3.Visible = true;
                Label3.Visible = false;
                Button3_actualizarmatricula.Text = "Guardar cambios";
                Button3_actualizarmatricula.BackColor = System.Drawing.Color.Red;
                Button3_actualizarmatricula.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarcategoria.Enabled = false;
                Button1_actualizarcategoria.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarcategoria.BorderColor = System.Drawing.Color.LightGray;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarmensualidad.Enabled = false;
                Button4_actualizarmensualidad.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarmensualidad.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarnumerocuotas.Enabled = false;
                Button5_actualizarnumerocuotas.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarnumerocuotas.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizarhorasacademicas.Enabled = false;
                Button6_actualizarhorasacademicas.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizarhorasacademicas.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizarimagen.Enabled = false;
                Button7_actualizarimagen.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizarimagen.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdDiplomado");
                Int32 IdDiplomado = Convert.ToInt32(C);

                clsDiplomado obj = new clsDiplomado();
                clsDiplomadoGESTOR dao = new clsDiplomadoGESTOR();
                obj = dao.RetornarPorId(IdDiplomado);
                obj.Matricula = Convert.ToDecimal(TextBox3.Text);
                if (dao.ActualizarMatricula(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Diplomado/Editar.aspx?IdDiplomado=" + obj.IdDiplomado);
                }
            }
        }

        protected void Button4_actualizarmensualidad_Click(object sender, EventArgs e)
        {
            if (Button4_actualizarmensualidad.Text == "Editar mensual")
            {
                TextBox4.Visible = true;
                Label4.Visible = false;
                Button4_actualizarmensualidad.Text = "Guardar cambios";
                Button4_actualizarmensualidad.BackColor = System.Drawing.Color.Red;
                Button4_actualizarmensualidad.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarcategoria.Enabled = false;
                Button1_actualizarcategoria.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarcategoria.BorderColor = System.Drawing.Color.LightGray;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizarmatricula.Enabled = false;
                Button3_actualizarmatricula.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizarmatricula.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarnumerocuotas.Enabled = false;
                Button5_actualizarnumerocuotas.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarnumerocuotas.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizarhorasacademicas.Enabled = false;
                Button6_actualizarhorasacademicas.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizarhorasacademicas.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizarimagen.Enabled = false;
                Button7_actualizarimagen.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizarimagen.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdDiplomado");
                Int32 IdDiplomado = Convert.ToInt32(C);

                clsDiplomado obj = new clsDiplomado();
                clsDiplomadoGESTOR dao = new clsDiplomadoGESTOR();
                obj = dao.RetornarPorId(IdDiplomado);
                obj.Mensualidad = Convert.ToDecimal(TextBox4.Text);
                if (dao.ActualizarMensualidad(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Diplomado/Editar.aspx?IdDiplomado=" + obj.IdDiplomado);
                }
            }
        }

        protected void Button5_actualizarnumerocuotas_Click(object sender, EventArgs e)
        {
            if (Button5_actualizarnumerocuotas.Text == "Editar N cuotas")
            {
                TextBox5.Visible = true;
                Label5.Visible = false;
                Button5_actualizarnumerocuotas.Text = "Guardar cambios";
                Button5_actualizarnumerocuotas.BackColor = System.Drawing.Color.Red;
                Button5_actualizarnumerocuotas.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarcategoria.Enabled = false;
                Button1_actualizarcategoria.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarcategoria.BorderColor = System.Drawing.Color.LightGray;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizarmatricula.Enabled = false;
                Button3_actualizarmatricula.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizarmatricula.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarmensualidad.Enabled = false;
                Button4_actualizarmensualidad.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarmensualidad.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizarhorasacademicas.Enabled = false;
                Button6_actualizarhorasacademicas.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizarhorasacademicas.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizarimagen.Enabled = false;
                Button7_actualizarimagen.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizarimagen.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdDiplomado");
                Int32 IdDiplomado = Convert.ToInt32(C);

                clsDiplomado obj = new clsDiplomado();
                clsDiplomadoGESTOR dao = new clsDiplomadoGESTOR();
                obj = dao.RetornarPorId(IdDiplomado);
                obj.NumeroCuotas = Convert.ToInt32(TextBox5.Text);
                if (dao.ActualizarNumeroCuotas(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Diplomado/Editar.aspx?IdDiplomado=" + obj.IdDiplomado);
                }
            }
        }

        protected void Button6_actualizarhorasacademicas_Click(object sender, EventArgs e)
        {
            if (Button6_actualizarhorasacademicas.Text == "Editar hrs. acad.")
            {
                TextBox6.Visible = true;
                Label6.Visible = false;
                Button6_actualizarhorasacademicas.Text = "Guardar cambios";
                Button6_actualizarhorasacademicas.BackColor = System.Drawing.Color.Red;
                Button6_actualizarhorasacademicas.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarcategoria.Enabled = false;
                Button1_actualizarcategoria.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarcategoria.BorderColor = System.Drawing.Color.LightGray;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizarmatricula.Enabled = false;
                Button3_actualizarmatricula.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizarmatricula.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarmensualidad.Enabled = false;
                Button4_actualizarmensualidad.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarmensualidad.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarnumerocuotas.Enabled = false;
                Button5_actualizarnumerocuotas.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarnumerocuotas.BorderColor = System.Drawing.Color.LightGray;

                Button7_actualizarimagen.Enabled = false;
                Button7_actualizarimagen.BackColor = System.Drawing.Color.LightGray;
                Button7_actualizarimagen.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdDiplomado");
                Int32 IdDiplomado = Convert.ToInt32(C);

                clsDiplomado obj = new clsDiplomado();
                clsDiplomadoGESTOR dao = new clsDiplomadoGESTOR();
                obj = dao.RetornarPorId(IdDiplomado);
                obj.HorasAcademicas = Convert.ToInt32(TextBox6.Text);
                if (dao.ActualizarHorasAcademicas(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Diplomado/Editar.aspx?IdDiplomado=" + obj.IdDiplomado);
                }
            }
        }

        protected void Button7_actualizarimagen_Click(object sender, EventArgs e)
        {
            if (Button7_actualizarimagen.Text == "Editar imagen")
            {
                FileUpload1.Visible = true;
                Label7.Visible = false;
                Button7_actualizarimagen.Text = "Guardar cambios";
                Button7_actualizarimagen.BackColor = System.Drawing.Color.Red;
                Button7_actualizarimagen.BorderColor = System.Drawing.Color.Red;

                Button1_actualizarcategoria.Enabled = false;
                Button1_actualizarcategoria.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizarcategoria.BorderColor = System.Drawing.Color.LightGray;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                Button3_actualizarmatricula.Enabled = false;
                Button3_actualizarmatricula.BackColor = System.Drawing.Color.LightGray;
                Button3_actualizarmatricula.BorderColor = System.Drawing.Color.LightGray;

                Button4_actualizarmensualidad.Enabled = false;
                Button4_actualizarmensualidad.BackColor = System.Drawing.Color.LightGray;
                Button4_actualizarmensualidad.BorderColor = System.Drawing.Color.LightGray;

                Button5_actualizarnumerocuotas.Enabled = false;
                Button5_actualizarnumerocuotas.BackColor = System.Drawing.Color.LightGray;
                Button5_actualizarnumerocuotas.BorderColor = System.Drawing.Color.LightGray;

                Button6_actualizarhorasacademicas.Enabled = false;
                Button6_actualizarhorasacademicas.BackColor = System.Drawing.Color.LightGray;
                Button6_actualizarhorasacademicas.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdDiplomado");
                Int32 IdDiplomado = Convert.ToInt32(C);

                clsDiplomado obj = new clsDiplomado();
                clsDiplomadoGESTOR dao = new clsDiplomadoGESTOR();
                obj = dao.RetornarPorId(IdDiplomado);
                obj.Imagen = "~/Imagenes/Diplomado/" + FileUpload1.FileName;
                if (dao.ActualizarImagen(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Diplomado/Editar.aspx?IdDiplomado=" + obj.IdDiplomado);
                }
            }
        }
    }
}