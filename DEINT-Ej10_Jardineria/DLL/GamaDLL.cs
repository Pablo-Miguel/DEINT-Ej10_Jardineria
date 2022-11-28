using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.DLL
{
    public class GamaDLL
    {
        Conexion conexion;
        public GamaDLL()
        {
            conexion = new Conexion();
        }

        public DataSet getGamas()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM gama_producto");
            return conexion.EjecutarSentencia(sentencia);
        }

        public DataSet getGama(string gama) {
            SqlCommand sentencia = new SqlCommand($"SELECT * FROM gama_producto WHERE gama='{gama}'");
            return conexion.EjecutarSentencia(sentencia);
        }

        public bool Borrar(string gama)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"DELETE FROM gama_producto WHERE gama='{gama}'");
        }

    }
}
