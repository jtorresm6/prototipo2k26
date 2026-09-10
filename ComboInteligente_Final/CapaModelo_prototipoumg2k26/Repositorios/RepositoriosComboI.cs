using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_prototipoumg2k26.Repositorios
{
    public class RepositorioComboI : Repositorio
    {
        public DataTable obtenerDatos(string _tabla, string _campo1, string _campo2)
        {
            string sql = "SELECT " + _campo1 + ", " + _campo2 + " FROM " + _tabla + " WHERE estado = 1;";

            using (OdbcConnection conn = ObtenerConexion())
            {
                OdbcCommand command = new OdbcCommand(sql, conn);
                OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                DataTable dtDatos = new DataTable();
                adaptador.Fill(dtDatos);
                return dtDatos;
            }
        }
    }
}
