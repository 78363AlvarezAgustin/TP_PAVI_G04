
namespace Inmobiliaria.Formularios.FrmTransacciones
{
    partial class frmRegistroGastos
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
            this.lblGastos2 = new System.Windows.Forms.Label();
            this.grillaGastos = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEdificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnGuardarGasto = new System.Windows.Forms.Button();
            this.txtIdEdificio = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.lblNroProveedor = new System.Windows.Forms.Label();
            this.lblIdEdificio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblGastos = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.lblNroComprobante = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.grillaEdificios = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDptos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ascensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEdificios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGastos2
            // 
            this.lblGastos2.AutoSize = true;
            this.lblGastos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos2.Location = new System.Drawing.Point(28, 394);
            this.lblGastos2.Name = "lblGastos2";
            this.lblGastos2.Size = new System.Drawing.Size(80, 25);
            this.lblGastos2.TabIndex = 38;
            this.lblGastos2.Text = "Gastos";
            this.lblGastos2.Click += new System.EventHandler(this.lblGastos2_Click);
            // 
            // grillaGastos
            // 
            this.grillaGastos.AllowUserToAddRows = false;
            this.grillaGastos.AllowUserToDeleteRows = false;
            this.grillaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.NroComprobante,
            this.Fecha,
            this.Importe,
            this.Concepto,
            this.IdEdificio});
            this.grillaGastos.Location = new System.Drawing.Point(33, 433);
            this.grillaGastos.Name = "grillaGastos";
            this.grillaGastos.ReadOnly = true;
            this.grillaGastos.Size = new System.Drawing.Size(574, 184);
            this.grillaGastos.TabIndex = 37;
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "id_proveedor";
            this.IdProveedor.HeaderText = "Id del proveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Width = 80;
            // 
            // NroComprobante
            // 
            this.NroComprobante.DataPropertyName = "nro_comprobante";
            this.NroComprobante.HeaderText = "Numero de comprobante";
            this.NroComprobante.Name = "NroComprobante";
            this.NroComprobante.ReadOnly = true;
            this.NroComprobante.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 80;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Width = 110;
            // 
            // IdEdificio
            // 
            this.IdEdificio.DataPropertyName = "id_edificio";
            this.IdEdificio.HeaderText = "Id del edificio";
            this.IdEdificio.Name = "IdEdificio";
            this.IdEdificio.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_728918;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(283, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 74);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(57, 284);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(81, 74);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnGuardarGasto
            // 
            this.btnGuardarGasto.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnGuardarGasto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGasto.Location = new System.Drawing.Point(173, 284);
            this.btnGuardarGasto.Name = "btnGuardarGasto";
            this.btnGuardarGasto.Size = new System.Drawing.Size(74, 74);
            this.btnGuardarGasto.TabIndex = 5;
            this.btnGuardarGasto.UseVisualStyleBackColor = true;
            this.btnGuardarGasto.Click += new System.EventHandler(this.btnGuardarGasto_Click);
            // 
            // txtIdEdificio
            // 
            this.txtIdEdificio.Enabled = false;
            this.txtIdEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEdificio.Location = new System.Drawing.Point(220, 219);
            this.txtIdEdificio.Name = "txtIdEdificio";
            this.txtIdEdificio.Size = new System.Drawing.Size(137, 24);
            this.txtIdEdificio.TabIndex = 34;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(129, 192);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(77, 18);
            this.lblConcepto.TabIndex = 32;
            this.lblConcepto.Text = "Concepto:";
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(220, 159);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(137, 24);
            this.txtImporte.TabIndex = 3;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(144, 162);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(62, 18);
            this.lblImporte.TabIndex = 31;
            this.lblImporte.Text = "Importe:";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(220, 69);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(137, 24);
            this.txtIdProveedor.TabIndex = 22;
            this.txtIdProveedor.TextChanged += new System.EventHandler(this.txtIdProveedor_TextChanged);
            // 
            // lblNroProveedor
            // 
            this.lblNroProveedor.AutoSize = true;
            this.lblNroProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroProveedor.Location = new System.Drawing.Point(90, 72);
            this.lblNroProveedor.Name = "lblNroProveedor";
            this.lblNroProveedor.Size = new System.Drawing.Size(116, 18);
            this.lblNroProveedor.TabIndex = 28;
            this.lblNroProveedor.Text = "Id de Proveedor:";
            // 
            // lblIdEdificio
            // 
            this.lblIdEdificio.AutoSize = true;
            this.lblIdEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEdificio.Location = new System.Drawing.Point(111, 222);
            this.lblIdEdificio.Name = "lblIdEdificio";
            this.lblIdEdificio.Size = new System.Drawing.Size(95, 18);
            this.lblIdEdificio.TabIndex = 23;
            this.lblIdEdificio.Text = "Id de Edificio:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(153, 132);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 18);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(220, 129);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(137, 24);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(28, 24);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(195, 25);
            this.lblGastos.TabIndex = 18;
            this.lblGastos.Text = "Registro de Gastos";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroComprobante.Location = new System.Drawing.Point(220, 99);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(137, 24);
            this.txtNroComprobante.TabIndex = 1;
            // 
            // lblNroComprobante
            // 
            this.lblNroComprobante.AutoSize = true;
            this.lblNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroComprobante.Location = new System.Drawing.Point(54, 102);
            this.lblNroComprobante.Name = "lblNroComprobante";
            this.lblNroComprobante.Size = new System.Drawing.Size(152, 18);
            this.lblNroComprobante.TabIndex = 40;
            this.lblNroComprobante.Text = "Nro de Comprobante:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Enabled = false;
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(220, 189);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(137, 24);
            this.txtConcepto.TabIndex = 41;
            // 
            // grillaProveedores
            // 
            this.grillaProveedores.AllowUserToAddRows = false;
            this.grillaProveedores.AllowUserToDeleteRows = false;
            this.grillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion,
            this.Telefono});
            this.grillaProveedores.Location = new System.Drawing.Point(635, 69);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.ReadOnly = true;
            this.grillaProveedores.Size = new System.Drawing.Size(529, 150);
            this.grillaProveedores.TabIndex = 42;
            this.grillaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProveedores_CellClick);
            // 
            // grillaEdificios
            // 
            this.grillaEdificios.AllowUserToAddRows = false;
            this.grillaEdificios.AllowUserToDeleteRows = false;
            this.grillaEdificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEdificios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_edificio,
            this.dataGridViewTextBoxColumn1,
            this.CantidadDptos,
            this.Ascensor,
            this.Calle,
            this.NumeroCalle,
            this.IdBarrio});
            this.grillaEdificios.Location = new System.Drawing.Point(635, 318);
            this.grillaEdificios.Name = "grillaEdificios";
            this.grillaEdificios.ReadOnly = true;
            this.grillaEdificios.Size = new System.Drawing.Size(529, 166);
            this.grillaEdificios.TabIndex = 52;
            this.grillaEdificios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaEdificios_CellClick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(632, 225);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(220, 16);
            this.lblMensaje.TabIndex = 53;
            this.lblMensaje.Text = "Selecciona el proveedor en la grilla";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.Location = new System.Drawing.Point(632, 487);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(200, 16);
            this.lblMensaje2.TabIndex = 54;
            this.lblMensaje2.Text = "Selecciona el edificio en la grilla";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(630, 24);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(134, 25);
            this.lblProveedor.TabIndex = 55;
            this.lblProveedor.Text = "Proveedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Edificios";
            // 
            // Id_edificio
            // 
            this.Id_edificio.DataPropertyName = "id_edificio";
            this.Id_edificio.HeaderText = "Id del Edificio";
            this.Id_edificio.Name = "Id_edificio";
            this.Id_edificio.ReadOnly = true;
            this.Id_edificio.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "n_edificio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // CantidadDptos
            // 
            this.CantidadDptos.DataPropertyName = "cantidad_deptos";
            this.CantidadDptos.HeaderText = "Cantidad de Departamentos";
            this.CantidadDptos.Name = "CantidadDptos";
            this.CantidadDptos.ReadOnly = true;
            this.CantidadDptos.Width = 85;
            // 
            // Ascensor
            // 
            this.Ascensor.DataPropertyName = "tiene_ascensor";
            this.Ascensor.HeaderText = "Ascensor";
            this.Ascensor.Name = "Ascensor";
            this.Ascensor.ReadOnly = true;
            this.Ascensor.Width = 60;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // NumeroCalle
            // 
            this.NumeroCalle.DataPropertyName = "nro_calle";
            this.NumeroCalle.HeaderText = "Numero de Calle";
            this.NumeroCalle.Name = "NumeroCalle";
            this.NumeroCalle.ReadOnly = true;
            this.NumeroCalle.Width = 50;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "id_barrio";
            this.IdBarrio.HeaderText = "IdBarrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            this.IdBarrio.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id_proveedor";
            this.Id.HeaderText = "Id de proveedor";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 95;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "n_proveedor";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 140;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 140;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "tel_proveedor";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 110;
            // 
            // frmRegistroGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.grillaEdificios);
            this.Controls.Add(this.grillaProveedores);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.txtNroComprobante);
            this.Controls.Add(this.lblNroComprobante);
            this.Controls.Add(this.lblGastos2);
            this.Controls.Add(this.grillaGastos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarGasto);
            this.Controls.Add(this.txtIdEdificio);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.lblNroProveedor);
            this.Controls.Add(this.lblIdEdificio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblGastos);
            this.Name = "frmRegistroGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroGastos";
            this.Load += new System.EventHandler(this.frmRegistroGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEdificios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGastos2;
        private System.Windows.Forms.DataGridView grillaGastos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnGuardarGasto;
        private System.Windows.Forms.TextBox txtIdEdificio;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label lblNroProveedor;
        private System.Windows.Forms.Label lblIdEdificio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.Label lblNroComprobante;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.DataGridView grillaProveedores;
        private System.Windows.Forms.DataGridView grillaEdificios;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEdificio;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ascensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
    }
}