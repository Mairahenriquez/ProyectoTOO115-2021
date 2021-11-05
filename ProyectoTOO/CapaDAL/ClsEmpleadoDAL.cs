using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaDAL
{
    public class ClsEmpleadoDAL
    {
        //Consultar empleado
        public static List<ClsEmpleadoEnt> ObtenerEmpleado()
        {
            List<ClsEmpleadoEnt> Lista = new List<ClsEmpleadoEnt>();
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("ConsutarEmpleado", Datos.cn);
                Datos.comando.CommandType = System.Data.CommandType.StoredProcedure;
                Datos.cn.Open();
                Datos.DataR = Datos.comando.ExecuteReader();
                Lista = new List<ClsEmpleadoEnt>();
                while (Datos.DataR.Read())
                {
                    ClsEmpleadoEnt empleado = new ClsEmpleadoEnt();
                    empleado.IdEmpleado = Convert.ToInt32(Datos.DataR["idEmpleado"].ToString());
                    empleado.Nombres = Datos.DataR["nombres"].ToString();
                    empleado.Apellidos = Datos.DataR["apellidos"].ToString();
                    empleado.Salario = Convert.ToDouble(Datos.DataR["salario"].ToString());
                    empleado.Dui = Datos.DataR["dui"].ToString();
                    empleado.Nit = Datos.DataR["nit"].ToString();
                    empleado.Isss = Datos.DataR["isss"].ToString();
                    empleado.Nup = Datos.DataR["nup"].ToString();
                    empleado.Puesto = Convert.ToInt32(Datos.DataR["puestoDeTrabajo"].ToString());
                    Lista.Add(empleado);
                }
            }
            catch
            {
                Lista = null;
            }
            return Lista;
        }

        //Agregar empleado
        public static string InsertarEmpleado(ClsEmpleadoEnt empleado)
        {
            string mensaje = "";
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("agregarEmpleado", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@nombres", empleado.Nombres);
                Datos.comando.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
                Datos.comando.Parameters.AddWithValue("@salario", empleado.Salario);
                Datos.comando.Parameters.AddWithValue("@dui", empleado.Dui);
                Datos.comando.Parameters.AddWithValue("@nit", empleado.Nit);
                Datos.comando.Parameters.AddWithValue("@isss", empleado.Isss);
                Datos.comando.Parameters.AddWithValue("@nup", empleado.Nup);
                Datos.comando.Parameters.AddWithValue("@puestoDeTrabajo", empleado.Puesto);
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

        //Modificar empleado
        public static string ModificarEmpleado(ClsEmpleadoEnt empleado)
        {
            string mensaje = "";
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("ModificarEmpleado", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@nombres", empleado.Nombres);
                Datos.comando.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
                Datos.comando.Parameters.AddWithValue("@salario", empleado.Salario);
                Datos.comando.Parameters.AddWithValue("@dui", empleado.Dui);
                Datos.comando.Parameters.AddWithValue("@nit", empleado.Nit);
                Datos.comando.Parameters.AddWithValue("@isss", empleado.Isss);
                Datos.comando.Parameters.AddWithValue("@nup", empleado.Nup);
                Datos.comando.Parameters.AddWithValue("@puestoDeTrabajo", empleado.Puesto);
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

        //Eliminar empleado
        public static string EliminarEmpleado(int id)
        {
            string mensaje = "";
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("EliminarEmpleado", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@idEmpleado", id);
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

        //Buscar empleado
        public static ClsEmpleadoEnt BuscarEmpleado(int id)
        {
            ClsEmpleadoEnt empleado = new ClsEmpleadoEnt();
            try
            {
                ClsConexion Datos = new ClsConexion();
                Datos.comando = new SqlCommand("BuscarEmpleadoPorId", Datos.cn);
                Datos.comando.Parameters.AddWithValue("@idEmpleado", id);
                Datos.comando.CommandType = System.Data.CommandType.StoredProcedure;
                Datos.cn.Open();
                Datos.DataR = Datos.comando.ExecuteReader();
                while (Datos.DataR.Read())
                {

                    empleado.IdEmpleado = Convert.ToInt32(Datos.DataR["idEmpleado"].ToString());
                    empleado.Nombres = Datos.DataR["nombres"].ToString();
                    empleado.Apellidos = Datos.DataR["apellidos"].ToString();
                    empleado.Salario = Convert.ToDouble(Datos.DataR["salario"].ToString());
                    empleado.Dui = Datos.DataR["dui"].ToString();
                    empleado.Nit = Datos.DataR["nit"].ToString();
                    empleado.Isss = Datos.DataR["isss"].ToString();
                    empleado.Nup = Datos.DataR["nup"].ToString();
                    empleado.Puesto = Convert.ToInt32(Datos.DataR["puestoDeTrabajo"].ToString());
                }
            }
            catch
            {
                empleado = null;
            }
            return empleado;
        }
    }
}
