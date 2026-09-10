namespace CapaVista_prototipo2k26.Formas
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContrataacion = new System.Windows.Forms.DateTimePicker();
            this.txtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNaci = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.lblNombEmpleado = new System.Windows.Forms.Label();
            this.lblNitEmpleado = new System.Windows.Forms.Label();
            this.lblDpiEmpleado = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboPuestos = new CapaVista_prototipo2k26.Combo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(63, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(705, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(44, 80);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(805, 308);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAyuda.Location = new System.Drawing.Point(467, 390);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.LawnGreen;
            this.btnImprimir.Location = new System.Drawing.Point(548, 390);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.Location = new System.Drawing.Point(629, 391);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditar.Location = new System.Drawing.Point(710, 390);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.DeepPink;
            this.btnBorrar.Location = new System.Drawing.Point(793, 390);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtContrataacion);
            this.panel1.Controls.Add(this.txtNacimiento);
            this.panel1.Controls.Add(this.txtDpi);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.txtPuesto);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNit);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtIdEmpleado);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lblPuesto);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblFechaContratacion);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.lblFechaNaci);
            this.panel1.Controls.Add(this.LblApellido);
            this.panel1.Controls.Add(this.lblNombEmpleado);
            this.panel1.Controls.Add(this.lblNitEmpleado);
            this.panel1.Controls.Add(this.lblDpiEmpleado);
            this.panel1.Controls.Add(this.lblIdEmpleado);
            this.panel1.Location = new System.Drawing.Point(874, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 393);
            this.panel1.TabIndex = 7;
            // 
            // txtContrataacion
            // 
            this.txtContrataacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtContrataacion.Location = new System.Drawing.Point(136, 247);
            this.txtContrataacion.Name = "txtContrataacion";
            this.txtContrataacion.Size = new System.Drawing.Size(134, 22);
            this.txtContrataacion.TabIndex = 22;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.CustomFormat = "";
            this.txtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNacimiento.Location = new System.Drawing.Point(123, 183);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(150, 22);
            this.txtNacimiento.TabIndex = 21;
            // 
            // txtDpi
            // 
            this.txtDpi.Location = new System.Drawing.Point(107, 51);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(163, 22);
            this.txtDpi.TabIndex = 20;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(110, 281);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(160, 24);
            this.cboEstado.TabIndex = 18;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(110, 309);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(160, 22);
            this.txtPuesto.TabIndex = 17;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(107, 214);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(163, 22);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(107, 151);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 22);
            this.txtApellido.TabIndex = 13;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(107, 85);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(163, 22);
            this.txtNit.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(107, 23);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(163, 22);
            this.txtIdEmpleado.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(110, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 39);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(13, 311);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(49, 16);
            this.lblPuesto.TabIndex = 9;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 284);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Location = new System.Drawing.Point(3, 252);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(127, 16);
            this.lblFechaContratacion.TabIndex = 7;
            this.lblFechaContratacion.Text = "Fecha_Contratacion";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(13, 220);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblFechaNaci
            // 
            this.lblFechaNaci.AutoSize = true;
            this.lblFechaNaci.Location = new System.Drawing.Point(-3, 188);
            this.lblFechaNaci.Name = "lblFechaNaci";
            this.lblFechaNaci.Size = new System.Drawing.Size(120, 16);
            this.lblFechaNaci.TabIndex = 5;
            this.lblFechaNaci.Text = "Fecha_Nacimiento";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(13, 157);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(57, 16);
            this.LblApellido.TabIndex = 4;
            this.LblApellido.Text = "Apellido";
            // 
            // lblNombEmpleado
            // 
            this.lblNombEmpleado.AutoSize = true;
            this.lblNombEmpleado.Location = new System.Drawing.Point(13, 124);
            this.lblNombEmpleado.Name = "lblNombEmpleado";
            this.lblNombEmpleado.Size = new System.Drawing.Size(56, 16);
            this.lblNombEmpleado.TabIndex = 3;
            this.lblNombEmpleado.Text = "Nombre";
            // 
            // lblNitEmpleado
            // 
            this.lblNitEmpleado.AutoSize = true;
            this.lblNitEmpleado.Location = new System.Drawing.Point(13, 88);
            this.lblNitEmpleado.Name = "lblNitEmpleado";
            this.lblNitEmpleado.Size = new System.Drawing.Size(93, 16);
            this.lblNitEmpleado.TabIndex = 2;
            this.lblNitEmpleado.Text = "Nit_Empleado";
            // 
            // lblDpiEmpleado
            // 
            this.lblDpiEmpleado.AutoSize = true;
            this.lblDpiEmpleado.Location = new System.Drawing.Point(3, 53);
            this.lblDpiEmpleado.Name = "lblDpiEmpleado";
            this.lblDpiEmpleado.Size = new System.Drawing.Size(98, 16);
            this.lblDpiEmpleado.TabIndex = 1;
            this.lblDpiEmpleado.Text = "Dpi_Empleado";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Location = new System.Drawing.Point(13, 26);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(88, 16);
            this.lblIdEmpleado.TabIndex = 0;
            this.lblIdEmpleado.Text = "id_Empleado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(774, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboPuestos
            // 
            this.comboPuestos.Location = new System.Drawing.Point(63, 52);
            this.comboPuestos.Name = "comboPuestos";
            this.comboPuestos.Size = new System.Drawing.Size(718, 28);
            this.comboPuestos.TabIndex = 9;
            this.comboPuestos.Load += new System.EventHandler(this.comboPuestos_Load);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.comboPuestos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.txtBuscar);
            this.Name = "FrmEmpleados";
            this.Text = "01005 Manteimiento Empleados - Prototipo v 0.5.0";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombEmpleado;
        private System.Windows.Forms.Label lblNitEmpleado;
        private System.Windows.Forms.Label lblDpiEmpleado;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNaci;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.DateTimePicker txtNacimiento;
        private System.Windows.Forms.DateTimePicker txtContrataacion;
        private System.Windows.Forms.Button btnBuscar;
        private Combo comboPuestos;
    }
}