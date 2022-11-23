using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.Modelo
{
    public class Pedido
    {
        public int codigo_pedido { get; set; }
        public DateTime fecha_pedido { get; set; }
        public DateTime fecha_esperada { get; set; }
        public DateTime fecha_entrega { get; set; }
        public string estado { get; set; }
        public string comentarios { get; set; }
        public Cliente cliente { get; set; }

        public Pedido(int codigo_pedido, DateTime fecha_pedido, DateTime fecha_esperada, DateTime fecha_entrega, string estado, string comentarios, Cliente cliente)
        {
            this.codigo_pedido = codigo_pedido;
            this.fecha_pedido = fecha_pedido;
            this.fecha_esperada = fecha_esperada;
            this.fecha_entrega = fecha_entrega;
            this.estado = estado;
            this.comentarios = comentarios;
            this.cliente = cliente;
        }

        public override bool Equals(object obj)
        {
            return obj is Pedido pedido &&
                   codigo_pedido == pedido.codigo_pedido;
        }

        public override int GetHashCode()
        {
            return 363498150 + codigo_pedido.GetHashCode();
        }
    }
}
