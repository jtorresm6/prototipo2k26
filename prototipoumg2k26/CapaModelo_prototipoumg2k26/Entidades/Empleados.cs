using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_prototipoumg2k26.Entidades
{
    public class Empleados
    {
        public int id_empleado { get; set; }
        public string dpi_emp { get; set; }
        public string nit_emp { get; set; }
        public string nombre_emp { get; set; }
        public string apellido_emp { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string direccion_emp { get; set; }
        public DateTime fecha_contratacion { get; set; }
        public string estado_emp { get; set; }
        public int id_puesto { get; set; }
    }
}
