using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaBL;
using CapaEntidad;

namespace ProyectoTOO.Administracion
{
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        List<ClsUsuarioEnt> Lista = ClsUsuarioBL.ConsultarUsuario();
        ClsUsuarioEnt usuario = new ClsUsuarioEnt();

        public void CargarGrid()
        {
            gvUsuario.DataSource = Lista;
            gvUsuario.DataBind();
        }
        public void BorrarUsuario(int id)
        {
            Response.Write("<script language = javascript> alert('" + ClsUsuarioBL.EliminarUsuario(id) + "');</script>");
            CargarGrid();
            Response.Redirect("ListaUsuarios.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                CargarGrid();

                if (Request.QueryString["usuario"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["usuario"].ToString());
                    BorrarUsuario(id);
                }
            }
        }
        protected void gvUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gvUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUsuario.PageIndex = e.NewPageIndex;
            CargarGrid();
        }
    }
}