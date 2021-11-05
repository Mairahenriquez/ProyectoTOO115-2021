using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaBL;

namespace ProyectoTOO.Administracion
{
    public partial class Login : System.Web.UI.Page
    {
        ClsUsuarioEnt Lon = new ClsUsuarioEnt();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtPasscode.Text != "")
            {
                Lon.Nombres = txtUsuario.Text;
                Lon.Passcode = txtPasscode.Text;
                string obj = ClsUsuarioBL.DatosLogin(Lon);
                if (obj != "No")
                {
                    Session["Login"] = obj;
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    lblError.Text = "Usuario incorrecto";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Falta ingresar campos";
                lblError.Visible = true;
            }
        }
    }
}