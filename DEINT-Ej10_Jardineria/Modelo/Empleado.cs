using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej10_Jardineria.Modelo
{
    public class Empleado
    {
        public int codigo_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string extension { get; set; }
        public string email { get; set; }
        public Oficina oficina { get; set; }
        public Empleado jefe { get; set; }
        public string puesto { get; set; }

        public Empleado(int codigo_empleado, string nombre, string apellido1, string apellido2, string extension, string email, Oficina oficina, Empleado jefe, string puesto)
        {
            this.codigo_empleado = codigo_empleado;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.extension = extension;
            this.email = email;
            this.oficina = oficina;
            this.jefe = jefe;
            this.puesto = puesto;
        }

        public override bool Equals(object obj)
        {
            return obj is Empleado empleado &&
                   codigo_empleado == empleado.codigo_empleado;
        }

        public override int GetHashCode()
        {
            return 1182746450 + codigo_empleado.GetHashCode();
        }
    }
}
