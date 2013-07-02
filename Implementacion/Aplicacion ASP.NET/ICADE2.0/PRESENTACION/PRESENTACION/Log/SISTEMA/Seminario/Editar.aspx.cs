using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ICADE2._0.Administracion.ENTIDADES;
using ICADE2._0.Administracion.DAO;
using ICADE2._0.Administracion.NEGOCIO;

namespace PRESENTACION.PRESENTACION.Log.SISTEMA.Seminario
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String C = Request.QueryString.Get("IdSeminario");
            Int32 IdSeminario = Convert.ToInt32(C);

            clsSeminario obj = new clsSeminario();
            clsSeminarioGESTOR DAO = new clsSeminarioGESTOR();
            obj = DAO.RetornarPorId(IdSeminario);

            clsDiplomado objP = new clsDiplomado();
            clsDiplomadoGESTOR daoP = new clsDiplomadoGESTOR();
            objP = daoP.RetornarPorId(obj.Diplomado);

            Label1.Text = objP.Descripcion;
            Label2.Text = obj.Descripcion;
        }

        protected void Button1_actualizardiplomado_Click(object sender, EventArgs e)
        {
            if (Button1_actualizardiplomado.Text == "Editar diplomado")
            {
                DropDownList1.Visible = true;
                Label1.Visible = false;
                Button1_actualizardiplomado.Text = "Guardar cambios";
                Button1_actualizardiplomado.BackColor = System.Drawing.Color.Red;
                Button1_actualizardiplomado.BorderColor = System.Drawing.Color.Red;

                Button2_actualizardescripcion.Enabled = false;
                Button2_actualizardescripcion.BackColor = System.Drawing.Color.LightGray;
                Button2_actualizardescripcion.BorderColor = System.Drawing.Color.LightGray;

                clsDiplomadoDAO dao = new clsDiplomadoDAO();
                DropDownList1.DataValueField = "IdDiplomado";
                DropDownList1.DataTextField = "Descripcion";
                DropDownList1.DataSource = dao.LISTAR();
                DropDownList1.DataBind();
            }
            else
            {
                String C = Request.QueryString.Get("IdSeminario");
                Int32 IdSeminario = Convert.ToInt32(C);

                clsSeminario obj = new clsSeminario();
                clsSeminarioGESTOR DAO = new clsSeminarioGESTOR();
                obj = DAO.RetornarPorId(IdSeminario);

                obj.Diplomado = Convert.ToInt32(DropDownList1.SelectedValue);
                if (DAO.ActualizarDiplomado(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Seminario/Editar.aspx?IdSeminario=" + obj.IdSeminario);
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

                Button1_actualizardiplomado.Enabled = false;
                Button1_actualizardiplomado.BackColor = System.Drawing.Color.LightGray;
                Button1_actualizardiplomado.BorderColor = System.Drawing.Color.LightGray;
            }
            else
            {
                String C = Request.QueryString.Get("IdSeminario");
                Int32 IdSeminario = Convert.ToInt32(C);

                clsSeminario obj = new clsSeminario();
                clsSeminarioGESTOR dao = new clsSeminarioGESTOR();
                obj = dao.RetornarPorId(IdSeminario);
                obj.Descripcion = TextBox2.Text;
                if (dao.ActualizarDescripcion(obj))
                {
                    Response.Redirect("/PRESENTACION/Log/SISTEMA/Seminario/Editar.aspx?IdSeminario=" + obj.IdSeminario);
                }
            }
        }
    }
}