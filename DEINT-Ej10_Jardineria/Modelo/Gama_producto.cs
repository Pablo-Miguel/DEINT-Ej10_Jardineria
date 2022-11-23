using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.Modelo
{
    public class Gama_producto
    {
        public string gama { get; set; }
        public string descripcion_texto { get; set; }
        public string descripcion_html { get; set; }
        public string imagen { get; set; }

        public Gama_producto(string gama, string descripcion_texto, string descripcion_html, string imagen)
        {
            this.gama = gama;
            this.descripcion_texto = descripcion_texto;
            this.descripcion_html = descripcion_html;
            this.imagen = imagen;
        }

        public override bool Equals(object obj)
        {
            return obj is Gama_producto producto &&
                   gama.Equals(producto.gama);
        }

        public override int GetHashCode()
        {
            return 1362593011 + EqualityComparer<string>.Default.GetHashCode(gama);
        }
    }
}
