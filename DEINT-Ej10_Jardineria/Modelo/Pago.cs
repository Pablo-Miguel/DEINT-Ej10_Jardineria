using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.Modelo
{
    public class Pago
    {
        public Cliente cliente { get; set; }
        public string forma_pago { get; set; }
        public string id_transaccion { get; set; }
        public DateTime fecha_pago { get; set; }
        public double total { get { return total; } set { Math.Round(value, 2); } }

        public Pago(Cliente cliente, string forma_pago, string id_transaccion, DateTime fecha_pago, double total)
        {
            this.cliente = cliente;
            this.forma_pago = forma_pago;
            this.id_transaccion = id_transaccion;
            this.fecha_pago = fecha_pago;
            this.total = total;
        }

        public override bool Equals(object obj)
        {
            return obj is Pago pago &&
                   id_transaccion.Equals(pago.id_transaccion);
        }

        public override int GetHashCode()
        {
            return -1068381512 + EqualityComparer<string>.Default.GetHashCode(id_transaccion);
        }

    }
}
