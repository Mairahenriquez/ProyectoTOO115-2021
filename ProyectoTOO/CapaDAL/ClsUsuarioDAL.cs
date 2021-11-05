using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaDAL
{
    public class ClsUsuarioDAL
    {
        //consultar Usuarios
        public static List<ClsUsuarioEnt> ObtenerUsuario()
        {
            List<ClsUsuarioEnt> lista = new List<ClsUsuarioEnt>();
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("ConsutarUsuario", Datos.cn);
                Datos.comando.CommandType = System.Data.CommandType.StoredProcedure;
                Datos.cn.Open();
                Datos.DataR = Datos.comando.ExecuteReader();
                lista = new List<ClsUsuarioEnt>();
                while (Datos.DataR.Read())
                {
                    ClsUsuarioEnt Usuario = new ClsUsuarioEnt();
                    Usuario.IdUsuario = Convert.ToInt32(Datos.DataR["idUsuario"].ToString());
                    Usuario.Nombres = Datos.DataR["nombres"].ToString();
                    Usuario.Apellidos = Datos.DataR["apellidos"].ToString();
                    Usuario.FechaNacimiento = Datos.DataR["fechaNacimiento"].ToString();
                    Usuario.CorreoElectronico = Datos.DataR["correoElectronico"].ToString();
                    Usuario.Passcode = Datos.DataR["passcode"].ToString();
                    Usuario.Telefono = Datos.DataR["telefono"].ToString();
                    Usuario.Estado = Convert.ToInt32(Datos.DataR["idEstado"].ToString());
                    lista.Add(Usuario);
                }
            }
            catch
            {
                lista = null;
            }
            return lista;
        }

        //agregar usuarios
        public static string InsertarUsuario(ClsUsuarioEnt usuario)
        {
            string mensaje = "";
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("agregarUsuario", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@nombres", usuario.Nombres);
                Datos.comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                Datos.comando.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                Datos.comando.Parameters.AddWithValue("@correoElectronico", usuario.CorreoElectronico);
                Datos.comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                Datos.comando.Parameters.AddWithValue("@passcode", usuario.Passcode);
                Datos.comando.Parameters.AddWithValue("@estado", usuario.Estado);
                Datos.comando.CommandType = System.Data.CommandType.StoredProcedure;
                Datos.cn.Open();
                Datos.DataR = Datos.comando.ExecuteReader();
                Datos.DataR.Read();
                mensaje = Datos.DataR["mensaje"].ToString();
            }
            catch (Exception e)
            {
                mensaje = "Error del sistema:" + e.Message;
            }
            return mensaje;
        }

        //Modificar usuario
        public static string ModificarUsuario(ClsUsuarioEnt usuario)
        {
            string mensaje = "";
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("ModificarUsuario", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                Datos.comando.Parameters.AddWithValue("@nombres", usuario.Nombres);
                Datos.comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                Datos.comando.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                Datos.comando.Parameters.AddWithValue("@correoElectronico", usuario.CorreoElectronico);
                Datos.comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                Datos.comando.Parameters.AddWithValue("@passcode", usuario.Passcode);
                Datos.comando.Parameters.AddWithValue("@estado", usuario.Estado);
                Datos.comando.CommandType = System.Data.CommandType.StoredProcedure;
                Datos.cn.Open();
                Datos.DataR = Datos.comando.ExecuteReader();
                Datos.DataR.Read();
                mensaje = Datos.DataR["mensaje"].ToString();
            }
            catch (Exception e)
            {
                mensaje = "Error del sistema:" + e.Message;
            }
            return mensaje;
        }

        //Eliminar usuario
        public static string EliminarUsuario(int Id)
        {
            string mensaje = "";
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("EliminarUsuario", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@idUsuario", Id);
                Datos.comando.CommandType = System.Data.CommandType.StoredProcedure;
                Datos.cn.Open();
                Datos.DataR = Datos.comando.ExecuteReader();
                Datos.DataR.Read();
                mensaje = Datos.DataR["mensaje"].ToString();
            }
            catch (Exception e)
            {
                mensaje = "Error del sistema:" + e.Message;
            }
            return mensaje;
        }

        //Buscar Usuario
        public static ClsUsuarioEnt BuscarUsuario(int id)
        {
            ClsUsuarioEnt Usuario = new ClsUsuarioEnt();
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("BuscarUsuarioPorId", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@idUsuario", id);
                Datos.comando.CommandType = System.Data.CommandType.StoredProcedure;
                Datos.cn.Open();
                Datos.DataR = Datos.comando.ExecuteReader();
                while (Datos.DataR.Read())
                {

                    Usuario.IdUsuario = Convert.ToInt32(Datos.DataR["idUsuario"].ToString());
                    Usuario.Nombres = Datos.DataR["nombres"].ToString();
                    Usuario.Apellidos = Datos.DataR["apellidos"].ToString();
                    Usuario.FechaNacimiento = Datos.DataR["fechaNacimiento"].ToString();
                    Usuario.CorreoElectronico = Datos.DataR["correoElectronico"].ToString();
                    Usuario.Telefono = Datos.DataR["telefono"].ToString();
                    Usuario.Passcode = Datos.DataR["passcode"].ToString();
                    Usuario.Estado = Convert.ToInt32(Datos.DataR["estado"].ToString());
                }
            }
            catch
            {
                Usuario = null;
            }
            return Usuario;
        }
        public static string ComprobarLogin(ClsUsuarioEnt Login)
        {
            string mensaje = "";
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("UsuarioLogin", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@nombres", Login.Nombres);
                Datos.comando.Parameters.AddWithValue("@passcode", Login.Passcode);
                Datos.comando.CommandType = System.Data.CommandType.StoredProcedure;
                Datos.cn.Open();
                Datos.DataR = Datos.comando.ExecuteReader();
                Datos.DataR.Read();
                mensaje = Datos.DataR["mensaje"].ToString();
            }
            catch (Exception e)
            {
                mensaje = "Error del sistema:" + e.Message;
            }
            return mensaje;
        }
    }
}
