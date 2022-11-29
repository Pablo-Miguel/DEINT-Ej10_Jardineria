using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.DLL
{
    public class EmpleadoDLL
    {
        Conexion conexion;
        public EmpleadoDLL()
        {
            conexion = new Conexion();
        }

        public DataSet getEmpleadosJefe(int id_jefe)
        {
            SqlCommand sentencia = new SqlCommand($"SELECT * FROM empleado WHERE codigo_jefe={id_jefe}");
            return conexion.EjecutarSentencia(sentencia);
        }

    }
}
