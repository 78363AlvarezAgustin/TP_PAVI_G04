
namespace Inmobiliaria.Formularios.FrmTransacciones
{
    partial class frmAltaPublicidad
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
            this.lblPublicidades = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDesignacionCatastral = new System.Windows.Forms.Label();
            this.lblMedioPublicitario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbMedioPublicitario = new System.Windows.Forms.ComboBox();
            this.txtCostoPublicidad = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblPropiedad = new System.Windows.Forms.Label();
            this.txtDesignacionCatastral = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnGuardarPublicidad = new System.Windows.Forms.Button();
            this.grillaPropiedades = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.DesignacionCatastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaPublicidades = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignacionCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedioPublicitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPublicidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPublicidades
            // 
            this.lblPublicidades.AutoSize = true;
            this.lblPublicidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicidades.Location = new System.Drawing.Point(53, 34);
            this.lblPublicidades.Name = "lblPublicidades";
            this.lblPublicidades.Size = new System.Drawing.Size(250, 25);
            this.lblPublicidades.TabIndex = 0;
            this.lblPublicidades.Text = "Registro de Publicidades";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(198, 72);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(137, 24);
            this.txtFecha.TabIndex = 0;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(131, 78);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 18);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDesignacionCatastral
            // 
            this.lblDesignacionCatastral.AutoSize = true;
            this.lblDesignacionCatastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignacionCatastral.Location = new System.Drawing.Point(29, 320);
            this.lblDesignacionCatastral.Name = "lblDesignacionCatastral";
            this.lblDesignacionCatastral.Size = new System.Drawing.Size(153, 18);
            this.lblDesignacionCatastral.TabIndex = 3;
            this.lblDesignacionCatastral.Text = "Designacion Catastral";
            // 
            // lblMedioPublicitario
            // 
            this.lblMedioPublicitario.AutoSize = true;
            this.lblMedioPublicitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedioPublicitario.Location = new System.Drawing.Point(55, 124);
            this.lblMedioPublicitario.Name = "lblMedioPublicitario";
            this.lblMedioPublicitario.Size = new System.Drawing.Size(125, 18);
            this.lblMedioPublicitario.TabIndex = 4;
            this.lblMedioPublicitario.Text = "Medio Publicitario";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(93, 178);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(198, 175);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(137, 24);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cmbMedioPublicitario
            // 
            this.cmbMedioPublicitario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPublicitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedioPublicitario.FormattingEnabled = true;
            this.cmbMedioPublicitario.Location = new System.Drawing.Point(198, 121);
            this.cmbMedioPublicitario.Name = "cmbMedioPublicitario";
            this.cmbMedioPublicitario.Size = new System.Drawing.Size(137, 26);
            this.cmbMedioPublicitario.TabIndex = 1;
            // 
            // txtCostoPublicidad
            // 
            this.txtCostoPublicidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoPublicidad.Location = new System.Drawing.Point(198, 222);
            this.txtCostoPublicidad.Name = "txtCostoPublicidad";
            this.txtCostoPublicidad.Size = new System.Drawing.Size(137, 24);
            this.txtCostoPublicidad.TabIndex = 3;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(131, 225);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(49, 18);
            this.lblCosto.TabIndex = 8;
            this.lblCosto.Text = "Costo";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(198, 268);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(137, 26);
            this.cmbSeccion.TabIndex = 4;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(118, 271);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(62, 18);
            this.lblSeccion.TabIndex = 10;
            this.lblSeccion.Text = "Seccion";
            // 
            // lblPropiedad
            // 
            this.lblPropiedad.AutoSize = true;
            this.lblPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropiedad.Location = new System.Drawing.Point(372, 72);
            this.lblPropiedad.Name = "lblPropiedad";
            this.lblPropiedad.Size = new System.Drawing.Size(91, 18);
            this.lblPropiedad.TabIndex = 12;
            this.lblPropiedad.Text = "Propiedades";
            // 
            // txtDesignacionCatastral
            // 
            this.txtDesignacionCatastral.Enabled = false;
            this.txtDesignacionCatastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignacionCatastral.Location = new System.Drawing.Point(198, 317);
            this.txtDesignacionCatastral.Name = "txtDesignacionCatastral";
            this.txtDesignacionCatastral.Size = new System.Drawing.Size(137, 24);
            this.txtDesignacionCatastral.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_728918;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(958, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 74);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(728, 315);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(81, 74);
            this.btnLimpiarCampos.TabIndex = 7;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnGuardarPublicidad
            // 
            this.btnGuardarPublicidad.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnGuardarPublicidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarPublicidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPublicidad.Location = new System.Drawing.Point(847, 315);
            this.btnGuardarPublicidad.Name = "btnGuardarPublicidad";
            this.btnGuardarPublicidad.Size = new System.Drawing.Size(74, 74);
            this.btnGuardarPublicidad.TabIndex = 5;
            this.btnGuardarPublicidad.UseVisualStyleBackColor = true;
            this.btnGuardarPublicidad.Click += new System.EventHandler(this.btnGuardarPublicidad_Click);
            // 
            // grillaPropiedades
            // 
            this.grillaPropiedades.AllowUserToAddRows = false;
            this.grillaPropiedades.AllowUserToDeleteRows = false;
            this.grillaPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesignacionCatastral,
            this.Calle,
            this.NroCalle,
            this.IdBarrio,
            this.Monto,
            this.IdMoneda,
            this.IdTipoOperacion});
            this.grillaPropiedades.Location = new System.Drawing.Point(375, 93);
            this.grillaPropiedades.Name = "grillaPropiedades";
            this.grillaPropiedades.ReadOnly = true;
            this.grillaPropiedades.Size = new System.Drawing.Size(657, 159);
            this.grillaPropiedades.TabIndex = 14;
            this.grillaPropiedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPropiedades_CellClick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(372, 255);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(266, 16);
            this.lblMensaje.TabIndex = 15;
            this.lblMensaje.Text = "Debes seleccionar la propiedad en la grilla";
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
            // grillaPublicidades
            // 
            this.grillaPublicidades.AllowUserToAddRows = false;
            this.grillaPublicidades.AllowUserToDeleteRows = false;
            this.grillaPublicidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPublicidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.DesignacionCat,
            this.MedioPublicitario,
            this.Descripcion,
            this.Costo,
            this.Seccion});
            this.grillaPublicidades.Location = new System.Drawing.Point(58, 408);
            this.grillaPublicidades.Name = "grillaPublicidades";
            this.grillaPublicidades.ReadOnly = true;
            this.grillaPublicidades.Size = new System.Drawing.Size(645, 150);
            this.grillaPublicidades.TabIndex = 16;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // DesignacionCat
            // 
            this.DesignacionCat.DataPropertyName = "Designacion Catastral";
            this.DesignacionCat.HeaderText = "Designacion Catastral";
            this.DesignacionCat.Name = "DesignacionCat";
            this.DesignacionCat.ReadOnly = true;
            // 
            // MedioPublicitario
            // 
            this.MedioPublicitario.DataPropertyName = "Medio Publicitario";
            this.MedioPublicitario.HeaderText = "Medio Publicitario";
            this.MedioPublicitario.Name = "MedioPublicitario";
            this.MedioPublicitario.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "Costo";
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Seccion
            // 
            this.Seccion.DataPropertyName = "Seccion";
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Publicidades";
            // 
            // frmAltaPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaPublicidades);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.grillaPropiedades);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarPublicidad);
            this.Controls.Add(this.txtDesignacionCatastral);
            this.Controls.Add(this.lblPropiedad);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.txtCostoPublicidad);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.cmbMedioPublicitario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMedioPublicitario);
            this.Controls.Add(this.lblDesignacionCatastral);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblPublicidades);
            this.Name = "frmAltaPublicidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Publicidades";
            this.Load += new System.EventHandler(this.frmAltaPublicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPublicidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPublicidades;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDesignacionCatastral;
        private System.Windows.Forms.Label lblMedioPublicitario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbMedioPublicitario;
        private System.Windows.Forms.TextBox txtCostoPublicidad;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblPropiedad;
        private System.Windows.Forms.TextBox txtDesignacionCatastral;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnGuardarPublicidad;
        private System.Windows.Forms.DataGridView grillaPropiedades;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignacionCatastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoOperacion;
        private System.Windows.Forms.DataGridView grillaPublicidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignacionCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedioPublicitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.Label label1;
    }
}