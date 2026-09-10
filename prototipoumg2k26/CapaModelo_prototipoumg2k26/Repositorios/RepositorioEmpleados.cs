using CapaModelo_prototipoumg2k26.Contratos;
using CapaModelo_prototipoumg2k26.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_prototipoumg2k26.Repositorios
{
    public class RepositorioEmpleados : RepositorioMaestro, IRepositorioEmpleados
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public RepositorioEmpleados()
        {
            selectAll = "SELECT * FROM empleados";
            insert = "INSERT INTO empleados (dpi_emp, nit_emp, nombre_emp, apellido_emp, fecha_nacimiento, direccion_emp, fecha_contratacion, estado_emp, id_puesto) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            update = "UPDATE empleados SET dpi_emp=?, nit_emp=?, nombre_emp=?, apellido_emp=?, fecha_nacimiento=?, direccion_emp=?, fecha_contratacion=?, estado_emp=?, id_puesto=? WHERE id_empleado=?";
            delete = "DELETE FROM empleados WHERE id_empleado=?";
        }
        public int Agregar(Empleados entidad)
        {
            var _parametros = new List<OdbcParameter>();

            _parametros.Add(new OdbcParameter("p_dpi_emp", entidad.dpi_emp));
            _parametros.Add(new OdbcParameter("p_nit_emp", entidad.nit_emp));
            _parametros.Add (new OdbcParameter("p_nombre_emp", entidad.nombre_emp));
            _parametros.Add (new OdbcParameter("p_apellido_emp", entidad.apellido_emp));
            _parametros.Add ( new OdbcParameter("p_fecha_nacimiento", entidad.fecha_nacimiento));
            _parametros.Add(  new OdbcParameter("p_direccion_emp", entidad.direccion_emp));
            _parametros.Add (new OdbcParameter("p_fecha_contratacion", entidad.fecha_contratacion));
            _parametros.Add (new OdbcParameter("p_estado_emp", entidad.estado_emp));
            _parametros.Add ( new OdbcParameter("p_id_puesto", entidad.id_puesto));

            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }

        public int Editar(Empleados entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add( new OdbcParameter("p_dpi_emp", entidad.dpi_emp));
            _parametros.Add (new OdbcParameter("p_nit_emp", entidad.nit_emp));
            _parametros.Add (new OdbcParameter("p_nombre_emp", entidad.nombre_emp));
            _parametros.Add (new OdbcParameter("p_apellido_emp", entidad.apellido_emp));
            _parametros.Add (new OdbcParameter("p_fecha_nacimiento", entidad.fecha_nacimiento));
            _parametros.Add (new OdbcParameter("p_direccion_emp", entidad.direccion_emp));
            _parametros.Add (new OdbcParameter("p_fecha_contratacion", entidad.fecha_contratacion));
            _parametros.Add (new OdbcParameter("p_estado_emp", entidad.estado_emp));
            _parametros.Add (new OdbcParameter("p_id_puesto", entidad.id_puesto));
            _parametros.Add (new OdbcParameter("p_id_empleado", entidad.id_empleado));
            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }
        public int Remover(Empleados entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_id_empleado", entidad.id_empleado));
            return EjecucionNonQuery(delete, _parametros, CommandType.Text);


        }
        public IEnumerable<Empleados> GetAll()
        {
            var listaEmpleados = new List<Empleados>();
            var TblTabla= EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in TblTabla.Rows)
            {

                var empleado = new Empleados();
                   empleado.id_empleado = Convert.ToInt32(row[0]);
                   empleado.dpi_emp = row[1].ToString();
                   empleado.nit_emp = row[2].ToString();
                   empleado.nombre_emp = row[3].ToString();
                   empleado.apellido_emp = row[4].ToString();
                   empleado.fecha_nacimiento = Convert.ToDateTime(row[5]);
                   empleado.direccion_emp = row[6].ToString();
                   empleado.fecha_contratacion = Convert.ToDateTime(row[7]);
                   empleado.estado_emp = row[8].ToString();
                   empleado.id_puesto = Convert.ToInt32(row[9]);
              
            }
            TblTabla.Clear();
            TblTabla = null;
            return listaEmpleados;
        }
    }
}
