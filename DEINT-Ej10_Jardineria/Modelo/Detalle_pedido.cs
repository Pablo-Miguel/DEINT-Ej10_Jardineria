using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.Modelo
{
    public class Detalle_pedido
    {
        public Pedido pedido { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public double precio_unidad { get { return precio_unidad; } set { Math.Round(value, 2); } }
        public int numero_linea { get; set; }

        public Detalle_pedido(Pedido pedido, Producto producto, int cantidad, double precio_unidad, int numero_linea)
        {
            this.pedido = pedido;
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio_unidad = precio_unidad;
            this.numero_linea = numero_linea;
        }

        public override bool Equals(object obj)
        {
            return obj is Detalle_pedido pedido &&
                   EqualityComparer<Pedido>.Default.Equals(this.pedido, pedido.pedido) &&
                   EqualityComparer<Producto>.Default.Equals(producto, pedido.producto);
        }

        public override int GetHashCode()
        {
            int hashCode = -1566025683;
            hashCode = hashCode * -1521134295 + EqualityComparer<Pedido>.Default.GetHashCode(pedido);
            hashCode = hashCode * -1521134295 + EqualityComparer<Producto>.Default.GetHashCode(producto);
            return hashCode;
        }

    }
}
