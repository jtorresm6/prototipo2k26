using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_prototipo2k26;

namespace CapaVista_prototipo2k26.Formas
{
    public partial class FrmEmpleados : Form
    {
        private ModeloEmpleado empleado = new ModeloEmpleado();

        public FrmEmpleados()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            listaEmpleados();

            // Llena el combo al abrir la pantalla filtrando por estado activo ("1")
            // Ajusta los nombres de la tabla y columnas a los reales de tu BD
            comboPuestos.llenarCombo("tbl_puestos", "id_puesto", "nombre_puesto", "estado_puesto", "1");

            // Valor por defecto del estado del empleado
            cboEstado.SelectedIndex = 0; // "Activo"
        }

        private void listaEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = empleado.GetAll();

                // Oculta la columna "Estado" del DataGridView para evitar errores visuales
                if (dgvEmpleados.Columns["Estado"] != null)
                {
                    dgvEmpleados.Columns["Estado"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar empleados: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = empleado.FindbyId(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empleado.dpi_emp = txtDpi.Text;
            empleado.nit_emp = txtNit.Text;
            empleado.nombre_emp = txtNombre.Text;
            empleado.apellido_emp = txtApellido.Text;
            empleado.fecha_nacimiento = txtNacimiento.Value;
            empleado.direccion_emp = txtDireccion.Text;
            empleado.fecha_contratacion = txtContrataacion.Value;

            // Estado tomado del combo fijo (Activo/Inactivo) en vez de texto libre
            empleado.estado_emp = cboEstado.SelectedItem?.ToString() ?? "Activo";

            // Extrae la clave seleccionada desde el control personalizado
            object valCombo = comboPuestos.ObtenerValor();
            empleado.id_puesto = valCombo != null ? Convert.ToInt32(valCombo) : 0;

            bool valido = new Ayudas.ValidacionDatos(empleado).Validar();
            if (valido)
            {
                string resultado = empleado.GrabarCambios();
                MessageBox.Show(resultado);
                listaEmpleados();
                Reinicio();
            }
        }

        private void Reinicio()
        {
            panel1.Enabled = false;
            empleado = new ModeloEmpleado(); // Reinicia el objeto para limpiar IDs previos
            txtIdEmpleado.Clear();
            txtDpi.Clear();
            txtNit.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNacimiento.Value = DateTime.Today;
            txtDireccion.Clear();
            txtContrataacion.Value = DateTime.Today;
            cboEstado.SelectedIndex = 0; // "Activo" por defecto

            // Limpia la selección del componente Combo
            comboPuestos.Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Reinicio();
            panel1.Enabled = true;
            empleado.Estado = EstadoEntidad.Added;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null && dgvEmpleados.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;

                // Extrae el objeto directamente sin depender de los índices de las celdas
                var empSeleccionado = (ModeloEmpleado)dgvEmpleados.CurrentRow.DataBoundItem;

                empleado = empSeleccionado;
                empleado.Estado = EstadoEntidad.Modified;

                txtIdEmpleado.Text = empleado.id_empleado.ToString();
                txtDpi.Text = empleado.dpi_emp;
                txtNit.Text = empleado.nit_emp;
                txtNombre.Text = empleado.nombre_emp;
                txtApellido.Text = empleado.apellido_emp;
                txtNacimiento.Value = empleado.fecha_nacimiento;
                txtDireccion.Text = empleado.direccion_emp;
                txtContrataacion.Value = empleado.fecha_contratacion;

                // Selecciona en el combo el estado guardado; si no coincide con
                // "Activo"/"Inactivo" (ej. datos previos con basura), cae a "Activo"
                int idx = cboEstado.Items.IndexOf(empleado.estado_emp);
                cboEstado.SelectedIndex = idx >= 0 ? idx : 0;

                // Selecciona el valor del puesto en el combo según la fila a editar
                comboPuestos.SeleccionarValor(empleado.id_puesto);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null && dgvEmpleados.SelectedRows.Count > 0)
            {
                var empSeleccionado = (ModeloEmpleado)dgvEmpleados.CurrentRow.DataBoundItem;

                empleado = empSeleccionado;
                empleado.Estado = EstadoEntidad.Deleted;

                string resultado = empleado.GrabarCambios();
                MessageBox.Show(resultado);
                listaEmpleados();
                Reinicio();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void comboPuestos_Load(object sender, EventArgs e)
        {

        }
    }
}