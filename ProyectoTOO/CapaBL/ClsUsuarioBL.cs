using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDAL;
using CapaEntidad;

namespace CapaBL
{
    public class ClsUsuarioBL
    {
        public static List<ClsUsuarioEnt> ConsultarUsuario()
        {
            return ClsUsuarioDAL.ObtenerUsuario();
        }
        public static string AgregarUsuario(ClsUsuarioEnt Usuario)
        {
            return ClsUsuarioDAL.InsertarUsuario(Usuario);
        }
        public static string EliminarUsuario(int id)
        {
            return ClsUsuarioDAL.EliminarUsuario(id);
        }
        public static string ModificarUsuario(ClsUsuarioEnt Usuario)
        {
            return ClsUsuarioDAL.ModificarUsuario(Usuario);
        }
        public static ClsUsuarioEnt ObtenerUsuarioPorID(int id)
        {
            return ClsUsuarioDAL.BuscarUsuario(id);
        }
        public static string DatosLogin(ClsUsuarioEnt Login)
        {
            return ClsUsuarioDAL.ComprobarLogin(Login);
        }
    }
}
