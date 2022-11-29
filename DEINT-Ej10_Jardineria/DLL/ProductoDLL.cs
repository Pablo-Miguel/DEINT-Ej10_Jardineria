using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DataSet getProductoMes(int mes)
        {   
            //SELECT p.* FROM producto p JOIN detalle_pedido dp ON p.codigo_producto = dp.codigo_producto JOIN pedido pd ON dp.codigo_pedido = pd.codigo_pedido WHERE MONTH(fecha_pedido)='11';
            SqlCommand sentencia = new SqlCommand($"SELECT * FROM pedido WHERE MONTH(fecha_pedido)='{mes}';");
            return conexion.EjecutarSentencia(sentencia);
        }

        public DataSet getProductoMasCaroYMasBarato() {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM producto WHERE precio_venta=(SELECT MAX(precio_venta) FROM producto) or precio_venta=(SELECT MIN(precio_venta) FROM producto)");
            return conexion.EjecutarSentencia(sentencia);
        }

    }
}
