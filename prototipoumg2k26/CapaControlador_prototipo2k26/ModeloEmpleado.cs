using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_prototipoumg2k26.Entidades;
using CapaModelo_prototipoumg2k26.Contratos;
using CapaModelo_prototipoumg2k26.Repositorios;
using System.Data.Odbc;
using System.ComponentModel.DataAnnotations;

namespace CapaControlador_prototipo2k26
{
    public class ModeloEmpleado
    {
        private int _id_empleado;
        private string _dpi_emp;
        private string _nit_emp;
        private string _nombre_emp;
        private string _apellido_emp;
        private DateTime _fecha_nacimiento;
        private string _direccion_emp;
        private DateTime _fecha_contratacion;
        private string _estado_emp;
        private int _id_puesto;
        private IRepositorioEmpleados RepositorioEmpleados;
        private List<ModeloEmpleado> ListaEmpleados;

        // Propiedad requerida para la evaluacion del switch
        public EstadoEntidad Estado { get; set; }

        public int id_empleado { get => _id_empleado; set => _id_empleado = value; }

        [Required(ErrorMessage = "El campo DPI es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El DPI debe ser numerico")]
        [StringLength(maximumLength: 13, MinimumLength = 13, ErrorMessage = "El DPI debe tener 13 digitos")]
        public string dpi_emp { get => _dpi_emp; set => _dpi_emp = value; }

        [Required(ErrorMessage = "El campo NIT es requerido")]
        [StringLength(maximumLength: 10, MinimumLength = 8, ErrorMessage = "El NIT debe tener entre 8 y 10 caracteres")]
        public string nit_emp { get => _nit_emp; set => _nit_emp = value; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [RegularExpression(@"^[a-zA-Zá-úÁ-ÚñÑ ]+$", ErrorMessage = "El campo Nombre debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El Nombre debe tener entre 3 y 100 caracteres")]
        public string nombre_emp { get => _nombre_emp; set => _nombre_emp = value; }

        [Required(ErrorMessage = "El campo Apellido es requerido")]
        [RegularExpression(@"^[a-zA-Zá-úÁ-ÚñÑ ]+$", ErrorMessage = "El campo Apellido debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El Apellido debe tener entre 3 y 100 caracteres")]
        public string apellido_emp { get => _apellido_emp; set => _apellido_emp = value; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public DateTime fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }

        [Required(ErrorMessage = "La direccion es requerida")]
        [StringLength(maximumLength: 200, MinimumLength = 5, ErrorMessage = "La direccion debe tener entre 5 y 200 caracteres")]
        public string direccion_emp { get => _direccion_emp; set => _direccion_emp = value; }

        [Required(ErrorMessage = "La fecha de contratacion es requerida")]
        public DateTime fecha_contratacion { get => _fecha_contratacion; set => _fecha_contratacion = value; }

        [Required(ErrorMessage = "El estado es requerido")]
        public string estado_emp { get => _estado_emp; set => _estado_emp = value; }

        [Required(ErrorMessage = "El id de puesto es requerido")]
        public int id_puesto { get => _id_puesto; set => _id_puesto = value; }

        public ModeloEmpleado()
        {
            RepositorioEmpleados = new RepositorioEmpleados();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modeloDatosEmpleados = new Empleados();
                modeloDatosEmpleados.id_empleado = _id_empleado;
                modeloDatosEmpleados.dpi_emp = _dpi_emp;
                modeloDatosEmpleados.nit_emp = _nit_emp;
                modeloDatosEmpleados.nombre_emp = _nombre_emp;
                modeloDatosEmpleados.apellido_emp = _apellido_emp;
                modeloDatosEmpleados.fecha_nacimiento = _fecha_nacimiento;
                modeloDatosEmpleados.direccion_emp = _direccion_emp;
                modeloDatosEmpleados.fecha_contratacion = _fecha_contratacion;
                modeloDatosEmpleados.estado_emp = _estado_emp;
                modeloDatosEmpleados.id_puesto = _id_puesto;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioEmpleados.Agregar(modeloDatosEmpleados);
                        mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioEmpleados.Editar(modeloDatosEmpleados);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioEmpleados.Remover(modeloDatosEmpleados);
                        mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }

            return mensaje;
        }

        public List<ModeloEmpleado> GetAll()
        {
            var modeloDatosEmpleados = RepositorioEmpleados.GetAll();
            ListaEmpleados = new List<ModeloEmpleado>();
            foreach (Empleados item in modeloDatosEmpleados)
            {
                ListaEmpleados.Add(new ModeloEmpleado
                {
                    _id_empleado = item.id_empleado,
                    _dpi_emp = item.dpi_emp,
                    _nit_emp = item.nit_emp,
                    _nombre_emp = item.nombre_emp,
                    _apellido_emp = item.apellido_emp,
                    _fecha_nacimiento = item.fecha_nacimiento,
                    _direccion_emp = item.direccion_emp,
                    _fecha_contratacion = item.fecha_contratacion,
                    _estado_emp = item.estado_emp,
                    _id_puesto = item.id_puesto
                });
            }
            return ListaEmpleados;
        }

        public IEnumerable<ModeloEmpleado> FindbyId(string filter)
        {
            if (ListaEmpleados == null) GetAll();
            return ListaEmpleados.FindAll(e => e._dpi_emp.Contains(filter) || e._nombre_emp.Contains(filter));
        }
    }
}