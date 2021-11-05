using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDAL;
using CapaEntidad;

namespace CapaBL
{
    public class ClsEmpleadoBL
    {
        public static List<ClsEmpleadoEnt> ConsultarEmpleado()
        {
            return ClsEmpleadoDAL.ObtenerEmpleado();
        }
        public static string AgregarEmpleado(ClsEmpleadoEnt empleado)
        {
            return ClsEmpleadoDAL.InsertarEmpleado(empleado);
        }
        public static string EliminarEmpleado(int id)
        {
            return ClsEmpleadoDAL.EliminarEmpleado(id);
        }
        public static string ModificarEmpleado(ClsEmpleadoEnt empleado)
        {
            return ClsEmpleadoDAL.ModificarEmpleado(empleado);
        }
        public static ClsEmpleadoEnt ObtenerEmpleadoPorID(int id)
        {
            return ClsEmpleadoDAL.BuscarEmpleado(id);
        }
    }
}
