using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.DLL
{
    public class ClienteDLL
    {
        Conexion conexion;
        public ClienteDLL()
        {
            conexion = new Conexion();
        }

        public DataSet getClientesQueNoPagan()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM cliente WHERE codigo_cliente NOT IN (SELECT codigo_cliente FROM pago) AND codigo_cliente IN (SELECT codigo_cliente FROM pedido);");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
