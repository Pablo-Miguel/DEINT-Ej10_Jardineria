using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.DLL
{
    public class ProductoDLL
    {
        Conexion conexion;
        public ProductoDLL()
        {
            conexion = new Conexion();
        }

        public bool Agregar(string nombre, string gama, string dimensiones, string proveedor, string descripcion, int cantidad_en_stock, double precio_venta, double precio_proveedor)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO producto (nombre, gama, dimensiones, proveedor, descripcion, cantidad_en_stock, precio_venta, precio_proveedor) " +
                $"VALUES ('{nombre}', '{gama}', '{dimensiones}', '{proveedor}', '{descripcion}', {cantidad_en_stock}, {precio_venta}, {precio_proveedor});");
        }

        public DataSet getProductos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM producto");
            return conexion.EjecutarSentencia(sentencia);
        }

    }
}
