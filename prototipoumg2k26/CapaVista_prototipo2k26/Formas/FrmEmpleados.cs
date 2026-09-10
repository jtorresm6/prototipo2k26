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
        }

        private void listaEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = empleado.GetAll();
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
            empleado.estado_emp = txtEstado.Text;
            empleado.id_puesto = string.IsNullOrEmpty(txtPuesto.Text) ? 0 : Convert.ToInt32(txtPuesto.Text);

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
            txtIdEmpleado.Clear();
            txtDpi.Clear();
            txtNit.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNacimiento.Value = DateTime.Today;
            txtDireccion.Clear();
            txtContrataacion.Value = DateTime.Today;
            txtEstado.Clear();
            txtPuesto.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            empleado.Estado = EstadoEntidad.Added;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                empleado.Estado = EstadoEntidad.Modified;

                empleado.id_empleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                txtIdEmpleado.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtDpi.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtNit.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtApellido.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                txtNacimiento.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[5].Value);
                txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
                txtContrataacion.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[7].Value);
                txtEstado.Text = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
                txtPuesto.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                empleado.Estado = EstadoEntidad.Deleted;
                empleado.id_empleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                string resultado = empleado.GrabarCambios();
                MessageBox.Show(resultado);
                listaEmpleados();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}