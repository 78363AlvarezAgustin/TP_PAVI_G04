
namespace Inmobiliaria.Formularios.FrmTransacciones
{
    partial class frmRegistrarPropiedadInteresParaClientes
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
            this.gdrClientes = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gdrPropiedades = new System.Windows.Forms.DataGridView();
            this.DesignacionCatastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPropiedad = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPublicidades = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtDesignacionCatastral = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblDesCatastral = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdrClientes_X_Propiedad = new System.Windows.Forms.DataGridView();
            this.Designacion_Catastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Ndoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPropiedades)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrClientes_X_Propiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // gdrClientes
            // 
            this.gdrClientes.AllowUserToAddRows = false;
            this.gdrClientes.AllowUserToDeleteRows = false;
            this.gdrClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ndoc,
            this.tDoc,
            this.NombreDueño,
            this.ApellidoDueño,
            this.Tel,
            this.dataGridViewTextBoxColumn3,
            this.NumeroCalle,
            this.dataGridViewTextBoxColumn4});
            this.gdrClientes.Location = new System.Drawing.Point(12, 97);
            this.gdrClientes.Name = "gdrClientes";
            this.gdrClientes.ReadOnly = true;
            this.gdrClientes.Size = new System.Drawing.Size(741, 235);
            this.gdrClientes.TabIndex = 58;
            this.gdrClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrClientes_CellClick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(4, 633);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(437, 16);
            this.lblMensaje.TabIndex = 57;
            this.lblMensaje.Text = "Debe seleccionar el Cliente y su/s Propiedade/s de interes en las grillas";
            // 
            // gdrPropiedades
            // 
            this.gdrPropiedades.AllowUserToAddRows = false;
            this.gdrPropiedades.AllowUserToDeleteRows = false;
            this.gdrPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesignacionCatastral,
            this.Calle,
            this.NroCalle,
            this.IdBarrio,
            this.Monto,
            this.IdMoneda,
            this.IdTipoOperacion});
            this.gdrPropiedades.Location = new System.Drawing.Point(12, 382);
            this.gdrPropiedades.Name = "gdrPropiedades";
            this.gdrPropiedades.ReadOnly = true;
            this.gdrPropiedades.Size = new System.Drawing.Size(648, 235);
            this.gdrPropiedades.TabIndex = 56;
            this.gdrPropiedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrPropiedades_CellClick);
            // 
            // DesignacionCatastral
            // 
            this.DesignacionCatastral.DataPropertyName = "designacion_catastral";
            this.DesignacionCatastral.HeaderText = "Designacion Catastral";
            this.DesignacionCatastral.Name = "DesignacionCatastral";
            this.DesignacionCatastral.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // NroCalle
            // 
            this.NroCalle.DataPropertyName = "nro_calle";
            this.NroCalle.HeaderText = "Nro Calle";
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.ReadOnly = true;
            this.NroCalle.Width = 80;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "id_barrio";
            this.IdBarrio.HeaderText = "ID Barrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            this.IdBarrio.Width = 75;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // IdMoneda
            // 
            this.IdMoneda.DataPropertyName = "id_moneda";
            this.IdMoneda.HeaderText = "ID Moneda";
            this.IdMoneda.Name = "IdMoneda";
            this.IdMoneda.ReadOnly = true;
            this.IdMoneda.Width = 75;
            // 
            // IdTipoOperacion
            // 
            this.IdTipoOperacion.DataPropertyName = "id_tipo_operacion";
            this.IdTipoOperacion.HeaderText = "ID Tipo Operacion";
            this.IdTipoOperacion.Name = "IdTipoOperacion";
            this.IdTipoOperacion.ReadOnly = true;
            this.IdTipoOperacion.Width = 75;
            // 
            // lblPropiedad
            // 
            this.lblPropiedad.AutoSize = true;
            this.lblPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropiedad.Location = new System.Drawing.Point(12, 361);
            this.lblPropiedad.Name = "lblPropiedad";
            this.lblPropiedad.Size = new System.Drawing.Size(91, 18);
            this.lblPropiedad.TabIndex = 55;
            this.lblPropiedad.Text = "Propiedades";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(12, 76);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(61, 18);
            this.lblClientes.TabIndex = 60;
            this.lblClientes.Text = "Clientes";
            // 
            // lblPublicidades
            // 
            this.lblPublicidades.AutoSize = true;
            this.lblPublicidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicidades.Location = new System.Drawing.Point(12, 9);
            this.lblPublicidades.Name = "lblPublicidades";
            this.lblPublicidades.Size = new System.Drawing.Size(437, 25);
            this.lblPublicidades.TabIndex = 59;
            this.lblPublicidades.Text = "Registrar Propiedad de interes para Clientes";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Enabled = false;
            this.txtNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocumento.Location = new System.Drawing.Point(1052, 107);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(137, 24);
            this.txtNroDocumento.TabIndex = 68;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__32378;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(955, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 74);
            this.btnAgregar.TabIndex = 67;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(1051, 227);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(81, 74);
            this.btnLimpiarCampos.TabIndex = 66;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(1051, 143);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(138, 21);
            this.cmbTipoDocumento.TabIndex = 65;
            // 
            // txtDesignacionCatastral
            // 
            this.txtDesignacionCatastral.Enabled = false;
            this.txtDesignacionCatastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignacionCatastral.Location = new System.Drawing.Point(1052, 180);
            this.txtDesignacionCatastral.Name = "txtDesignacionCatastral";
            this.txtDesignacionCatastral.Size = new System.Drawing.Size(137, 24);
            this.txtDesignacionCatastral.TabIndex = 64;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(917, 146);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(119, 18);
            this.lblTipoDocumento.TabIndex = 63;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(892, 109);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(144, 18);
            this.lblNroDoc.TabIndex = 62;
            this.lblNroDoc.Text = "Numero Documento";
            // 
            // lblDesCatastral
            // 
            this.lblDesCatastral.AutoSize = true;
            this.lblDesCatastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesCatastral.Location = new System.Drawing.Point(884, 183);
            this.lblDesCatastral.Name = "lblDesCatastral";
            this.lblDesCatastral.Size = new System.Drawing.Size(153, 18);
            this.lblDesCatastral.TabIndex = 61;
            this.lblDesCatastral.Text = "Designacion Catastral";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdrClientes_X_Propiedad);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(792, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 364);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes x Propiedades";
            // 
            // gdrClientes_X_Propiedad
            // 
            this.gdrClientes_X_Propiedad.AllowUserToAddRows = false;
            this.gdrClientes_X_Propiedad.AllowUserToDeleteRows = false;
            this.gdrClientes_X_Propiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrClientes_X_Propiedad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Designacion_Catastral,
            this.NumeroDocumento,
            this.TipoDocumento});
            this.gdrClientes_X_Propiedad.Location = new System.Drawing.Point(93, 41);
            this.gdrClientes_X_Propiedad.Name = "gdrClientes_X_Propiedad";
            this.gdrClientes_X_Propiedad.ReadOnly = true;
            this.gdrClientes_X_Propiedad.Size = new System.Drawing.Size(343, 204);
            this.gdrClientes_X_Propiedad.TabIndex = 15;
            // 
            // Designacion_Catastral
            // 
            this.Designacion_Catastral.DataPropertyName = "designacion_catastral";
            this.Designacion_Catastral.HeaderText = "Designacion Catastral";
            this.Designacion_Catastral.Name = "Designacion_Catastral";
            this.Designacion_Catastral.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "nro_documento_dueño";
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "tipo_documento_dueño";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(162, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 74);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_728918;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(259, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 74);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // Ndoc
            // 
            this.Ndoc.DataPropertyName = "nro_documento_c";
            this.Ndoc.HeaderText = "Numero Documento";
            this.Ndoc.Name = "Ndoc";
            this.Ndoc.ReadOnly = true;
            this.Ndoc.Width = 86;
            // 
            // tDoc
            // 
            this.tDoc.DataPropertyName = "tipo_documento_c";
            this.tDoc.HeaderText = "Tipo Documento";
            this.tDoc.Name = "tDoc";
            this.tDoc.ReadOnly = true;
            this.tDoc.Width = 86;
            // 
            // NombreDueño
            // 
            this.NombreDueño.DataPropertyName = "n_cliente";
            this.NombreDueño.HeaderText = "Nombre";
            this.NombreDueño.Name = "NombreDueño";
            this.NombreDueño.ReadOnly = true;
            this.NombreDueño.Width = 86;
            // 
            // ApellidoDueño
            // 
            this.ApellidoDueño.DataPropertyName = "apellido_cliente";
            this.ApellidoDueño.HeaderText = "Apellido";
            this.ApellidoDueño.Name = "ApellidoDueño";
            this.ApellidoDueño.ReadOnly = true;
            this.ApellidoDueño.Width = 86;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "tel_cliente";
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 86;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "calle";
            this.dataGridViewTextBoxColumn3.HeaderText = "Calle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 86;
            // 
            // NumeroCalle
            // 
            this.NumeroCalle.DataPropertyName = "nro_calle";
            this.NumeroCalle.HeaderText = "Numero Calle";
            this.NumeroCalle.Name = "NumeroCalle";
            this.NumeroCalle.ReadOnly = true;
            this.NumeroCalle.Width = 86;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_barrio";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdBarrio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 86;
            // 
            // frmRegistrarPropiedadInteresParaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 714);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.txtDesignacionCatastral);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.lblDesCatastral);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblPublicidades);
            this.Controls.Add(this.gdrClientes);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gdrPropiedades);
            this.Controls.Add(this.lblPropiedad);
            this.Name = "frmRegistrarPropiedadInteresParaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Propiedad de interes para Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.gdrClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPropiedades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdrClientes_X_Propiedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdrClientes;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView gdrPropiedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignacionCatastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoOperacion;
        private System.Windows.Forms.Label lblPropiedad;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPublicidades;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtDesignacionCatastral;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblDesCatastral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdrClientes_X_Propiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designacion_Catastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ndoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}