using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClsUsuarioEnt
    {
        private int idUsuario;
        private string nombres;
        private string apellidos;
        private string fechaNacimiento;
        private string correoElectronico;
        private string telefono;
        private string passcode;
        private int estado;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Passcode { get => passcode; set => passcode = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
