using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClsEmpleadoEnt
    {
        private int idEmpleado;
        private string nombres;
        private string apellidos;
        private double salario;
        private string dui;
        private string nit;
        private string isss;
        private string nup;
        private int puesto;
        private int usuario;
        private int direccion;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Nit { get => nit; set => nit = value; }
        public string Isss { get => isss; set => isss = value; }
        public string Nup { get => nup; set => nup = value; }
        public int Puesto { get => puesto; set => puesto = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public int Direccion { get => direccion; set => direccion = value; }
    }
}
