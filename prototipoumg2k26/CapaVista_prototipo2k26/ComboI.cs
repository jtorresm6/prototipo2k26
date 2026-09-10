using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_prototipo2k26;
using CapaModelo_prototipoumg2k26;

namespace CapaVista_prototipo2k26
{
    public partial class ComboI : UserControl
    {
        ModeloComboI controlador = new ModeloComboI();

        public ComboI()
        {
            InitializeComponent();
        }

        public void llenarCombo(string _tabla, string _campo1, string _campo2)
        {
            var dtTabla = controlador.enviarDatos(_tabla, _campo1, _campo2);

            cboPrueba.DataSource = dtTabla;
            cboPrueba.ValueMember = _campo1;
            cboPrueba.DisplayMember = _campo2;

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (DataRow row in dtTabla.Rows)
            {
                coleccion.Add(Convert.ToString(row[_campo1]) + "-" + Convert.ToString(row[_campo2]));
                coleccion.Add(Convert.ToString(row[_campo2]) + "-" + Convert.ToString(row[_campo1]));
            }

            cboPrueba.AutoCompleteCustomSource = coleccion;
            cboPrueba.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPrueba.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public object ObtenerValor() => cboPrueba.SelectedValue;
        public void SeleccionarValor(object valor) { if (valor != null) cboPrueba.SelectedValue = valor; }
        public void Limpiar() { if (cboPrueba.Items.Count > 0) cboPrueba.SelectedIndex = -1; }
    }

    public class ModeloComboI
    {
        public DataTable enviarDatos(string tabla, string campo1, string campo2)
        {
            // Conecta este método con tu capa Controlador/Modelo real cuando lo tengas listo
            DataTable dt = new DataTable();
            return dt;
        }
    }
}