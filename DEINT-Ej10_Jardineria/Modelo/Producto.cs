using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.Modelo
{
    public class Producto
    {
        public int codigo_producto { get; set; }
        public string nombre { get; set; }
        public string gama { get; set; }
        public string dimensiones { get; set; }
        public string proveedor { get; set; }
        public string descripcion { get; set; }
        public int cantidad_en_stock { get; set; }
        public double precio_venta { get { return precio_venta; } set { Math.Round(value, 2); } }
        public double precio_proveedor { get { return precio_proveedor; } set { Math.Round(value, 2); } }

        public Producto(int codigo_producto, string nombre, string gama, string dimensiones, string proveedor, string descripcion, int cantidad_en_stock, double precio_venta, double precio_proveedor)
        {
            this.codigo_producto = codigo_producto;
            this.nombre = nombre;
            this.gama = gama;
            this.dimensiones = dimensiones;
            this.proveedor = proveedor;
            this.descripcion = descripcion;
            this.cantidad_en_stock = cantidad_en_stock;
            this.precio_venta = precio_venta;
            this.precio_proveedor = precio_proveedor;
        }

        public Producto()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Producto producto &&
                   codigo_producto == producto.codigo_producto;
        }

        public override int GetHashCode()
        {
            return -1303175577 + codigo_producto.GetHashCode();
        }
    }
}
