using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDAL
{
    public class ClsConexion
    {
        private string Cadena = "Data Source=DESKTOP-I06DUQR\\SQLEXPRESS;Initial Catalog=ProyectoTOO;Integrated Security=True";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public SqlDataReader DataR = null;

        //Metodo para conectarse a una base de datos
        public void conectar()
        {
            cn = new SqlConnection(Cadena);
        }

        //Constructor de clases
        public ClsConexion()
        {
            conectar();
        }

        public DataTable consultar2(string tabla)
        {
            //Creando sentenciasql
            string sql = "select * from " + tabla;
            //Creando el data adapter
            da = new SqlDataAdapter(sql, cn);
            //Creando el data set
            DataSet dts = new DataSet();
            //Llenando el data adapter
            da.Fill(dts, tabla);
            //Creando data table
            DataTable dt = new DataTable();
            //Llenando data table
            dt = dts.Tables[tabla];
            //DEvolviendo el resultado
            return dt;
        }

        // Eliminar datos
        public bool Eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Actualizar Datos
        public bool Modificar(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = " update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Consultar Tabla
        public DataTable Consultar2(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
        public bool Insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
