using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.Modelo
{
    public class Cliente
    {
        public int codigo_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string nombre_contacto { get; set; }
        public string apellido_contacto { get; set; }
        public string telefono { get; set; }
        public string fax { get; set; }
        public string linea_direccion1 { get; set; }
        public string linea_direccion2 { get; set; }
        public string ciudad { get; set; }
        public string region { get; set; }
        public string pais { get; set; }
        public string codigo_postal { get; set; }
        public Empleado empleado { get; set; }
        public double limite_credito { get { return limite_credito; } set { Math.Round(value, 2); } }

        public Cliente(int codigo_cliente, string nombre_cliente, string nombre_contacto, string apellido_contacto, string telefono, string fax, string linea_direccion1, string linea_direccion2, string ciudad, string region, string pais, string codigo_postal, Empleado empleado, double limite_credito)
        {
            this.codigo_cliente = codigo_cliente;
            this.nombre_cliente = nombre_cliente;
            this.nombre_contacto = nombre_contacto;
            this.apellido_contacto = apellido_contacto;
            this.telefono = telefono;
            this.fax = fax;
            this.linea_direccion1 = linea_direccion1;
            this.linea_direccion2 = linea_direccion2;
            this.ciudad = ciudad;
            this.region = region;
            this.pais = pais;
            this.codigo_postal = codigo_postal;
            this.empleado = empleado;
            this.limite_credito = limite_credito;
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   codigo_cliente == cliente.codigo_cliente;
        }

        public override int GetHashCode()
        {
            return -1023843813 + codigo_cliente.GetHashCode();
        }

    }
}
