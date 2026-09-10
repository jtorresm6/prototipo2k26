using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaVista_prototipo2k26
{
    public partial class Combo : UserControl
    {
        ModeloCombo controlador = new ModeloCombo();

        public Combo()
        {
            InitializeComponent();
        }

        // Se agregaron los parámetros _columnaEstado y _valorEstado
        public void llenarCombo(string _tabla, string _campo1, string _campo2, string _columnaEstado, string _valorEstado)
        {
            var dtTabla = controlador.enviarDatos(_tabla, _campo1, _campo2, _columnaEstado, _valorEstado);

            // Limpia el origen de datos actual
            cboPrueba.DataSource = null;

            // Asigna los miembros ANTES de asignar el DataSource
            cboPrueba.ValueMember = _campo1;
            cboPrueba.DisplayMember = _campo2;
            cboPrueba.DataSource = dtTabla;

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            if (dtTabla != null)
            {
                foreach (DataRow row in dtTabla.Rows)
                {
                    coleccion.Add(Convert.ToString(row[_campo1]) + "-" + Convert.ToString(row[_campo2]));
                    coleccion.Add(Convert.ToString(row[_campo2]) + "-" + Convert.ToString(row[_campo1]));
                }
            }

            cboPrueba.AutoCompleteCustomSource = coleccion;
            cboPrueba.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPrueba.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Devuelve el valor (clave) actualmente seleccionado en el combo.
        // Si no hay nada seleccionado, devuelve null.
        public object ObtenerValor()
        {
            if (cboPrueba.SelectedValue == null || cboPrueba.SelectedIndex == -1)
                return null;

            return cboPrueba.SelectedValue;
        }

        // Limpia la selección actual del combo
        public void Limpiar()
        {
            cboPrueba.SelectedIndex = -1;
            cboPrueba.Text = string.Empty;
        }

        // Selecciona en el combo el item cuyo ValueMember coincida con el valor recibido
        public void SeleccionarValor(object valor)
        {
            if (valor == null || cboPrueba.DataSource == null)
                return;

            try
            {
                cboPrueba.SelectedValue = valor;
            }
            catch (Exception)
            {
                cboPrueba.SelectedIndex = -1;
            }
        }

        public class ModeloCombo
        {
            // Mismo DSN que usa Repositorio.cs (CapaModelo_prototipoumg2k26.Repositorios)
            private static readonly string cadenaConexion = "Dsn=BD_ProyectoNominas";

            public DataTable enviarDatos(string tabla, string campo1, string campo2, string columnaEstado, string valorEstado)
            {
                DataTable dt = new DataTable();

                // Se usan parámetros (?) para prevenir inyección SQL en ODBC
                string consultaSql = $"SELECT {campo1}, {campo2} FROM {tabla} WHERE {columnaEstado} = ?";

                try
                {
                    using (OdbcConnection conexion = new OdbcConnection(cadenaConexion))
                    using (OdbcCommand comando = new OdbcCommand(consultaSql, conexion))
                    {
                        comando.Parameters.AddWithValue("?", valorEstado);

                        conexion.Open();

                        using (OdbcDataAdapter adaptador = new OdbcDataAdapter(comando))
                        {
                            adaptador.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el combo: " + ex.Message);
                }

                return dt;
            }
        }
    }
}