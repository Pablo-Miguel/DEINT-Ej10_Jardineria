using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.Modelo
{
    public class Oficina
    {
        public int codigo_oficina { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string region { get; set; }
        public string codigo_postal { get; set; }
        public string telefono { get; set; }
        public string linea_direccion1 { get; set; }
        public string linea_direccion2 { get; set; }

        public Oficina(int codigo_oficina, string ciudad, string pais, string region, string codigo_postal, string telefono, string linea_direccion1, string linea_direccion2)
        {
            this.codigo_oficina = codigo_oficina;
            this.ciudad = ciudad;
            this.pais = pais;
            this.region = region;
            this.codigo_postal = codigo_postal;
            this.telefono = telefono;
            this.linea_direccion1 = linea_direccion1;
            this.linea_direccion2 = linea_direccion2;
        }

        public override bool Equals(object obj)
        {
            return obj is Oficina oficina &&
                   codigo_oficina == oficina.codigo_oficina;
        }

        public override int GetHashCode()
        {
            return 957680844 + codigo_oficina.GetHashCode();
        }

    }
}
