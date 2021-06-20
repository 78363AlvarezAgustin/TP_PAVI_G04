
namespace Inmobiliaria.Formularios.FrmEstadisticas
{
    partial class frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grillaPropiedades = new System.Windows.Forms.DataGridView();
            this.DesignacionCatastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDesigCat = new System.Windows.Forms.TextBox();
            this.lblDesigCat = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtTipoPropiedad = new System.Windows.Forms.TextBox();
            this.txtDesigCatastral = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiasOtro = new System.Windows.Forms.MaskedTextBox();
            this.rdTotal = new System.Windows.Forms.CheckBox();
            this.rdAnual = new System.Windows.Forms.CheckBox();
            this.rdMensual = new System.Windows.Forms.CheckBox();
            this.lblct = new System.Windows.Forms.Label();
            this.chkOtro = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCargarGrillaCompleta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inmobiliaria.EstadisticaGastosPublicitarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 455);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1044, 425);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Importe Gastado en Publicidades por Propiedad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Seleccione una Propiedad";
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
            this.grillaPropiedades.Location = new System.Drawing.Point(12, 146);
            this.grillaPropiedades.Name = "grillaPropiedades";
            this.grillaPropiedades.ReadOnly = true;
            this.grillaPropiedades.Size = new System.Drawing.Size(718, 256);
            this.grillaPropiedades.TabIndex = 20;
            this.grillaPropiedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPropiedades_CellContentClick);
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
            this.NroCalle.HeaderText = "Nro de Calle";
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.ReadOnly = true;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "id_barrio";
            this.IdBarrio.HeaderText = "ID Barrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            this.IdBarrio.Width = 80;
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
            // 
            // IdTipoOperacion
            // 
            this.IdTipoOperacion.DataPropertyName = "id_tipo_operacion";
            this.IdTipoOperacion.HeaderText = "ID Tipo Operacion";
            this.IdTipoOperacion.Name = "IdTipoOperacion";
            this.IdTipoOperacion.ReadOnly = true;
            // 
            // txtDesigCat
            // 
            this.txtDesigCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesigCat.Location = new System.Drawing.Point(549, 77);
            this.txtDesigCat.Name = "txtDesigCat";
            this.txtDesigCat.Size = new System.Drawing.Size(100, 24);
            this.txtDesigCat.TabIndex = 21;
            // 
            // lblDesigCat
            // 
            this.lblDesigCat.AutoSize = true;
            this.lblDesigCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesigCat.Location = new System.Drawing.Point(281, 80);
            this.lblDesigCat.Name = "lblDesigCat";
            this.lblDesigCat.Size = new System.Drawing.Size(262, 18);
            this.lblDesigCat.TabIndex = 22;
            this.lblDesigCat.Text = "Buscar por Designacion Catastral";
            // 
            // btnReporte
            // 
            this.btnReporte.Enabled = false;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(839, 331);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 60);
            this.btnReporte.TabIndex = 23;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(804, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Propiedad seleccionada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Calle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tipo de Propiedad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Designacion Catastral";
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(894, 146);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 26;
            // 
            // txtTipoPropiedad
            // 
            this.txtTipoPropiedad.Enabled = false;
            this.txtTipoPropiedad.Location = new System.Drawing.Point(894, 110);
            this.txtTipoPropiedad.Name = "txtTipoPropiedad";
            this.txtTipoPropiedad.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPropiedad.TabIndex = 25;
            // 
            // txtDesigCatastral
            // 
            this.txtDesigCatastral.Enabled = false;
            this.txtDesigCatastral.Location = new System.Drawing.Point(894, 75);
            this.txtDesigCatastral.Name = "txtDesigCatastral";
            this.txtDesigCatastral.Size = new System.Drawing.Size(100, 20);
            this.txtDesigCatastral.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDiasOtro);
            this.panel1.Controls.Add(this.rdTotal);
            this.panel1.Controls.Add(this.rdAnual);
            this.panel1.Controls.Add(this.rdMensual);
            this.panel1.Controls.Add(this.lblct);
            this.panel1.Controls.Add(this.chkOtro);
            this.panel1.Location = new System.Drawing.Point(755, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 89);
            this.panel1.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Años";
            // 
            // txtDiasOtro
            // 
            this.txtDiasOtro.Location = new System.Drawing.Point(159, 35);
            this.txtDiasOtro.Mask = "99";
            this.txtDiasOtro.Name = "txtDiasOtro";
            this.txtDiasOtro.Size = new System.Drawing.Size(24, 20);
            this.txtDiasOtro.TabIndex = 28;
            this.txtDiasOtro.ValidatingType = typeof(int);
            // 
            // rdTotal
            // 
            this.rdTotal.AutoSize = true;
            this.rdTotal.Location = new System.Drawing.Point(24, 64);
            this.rdTotal.Name = "rdTotal";
            this.rdTotal.Size = new System.Drawing.Size(50, 17);
            this.rdTotal.TabIndex = 27;
            this.rdTotal.Text = "Total";
            this.rdTotal.UseVisualStyleBackColor = true;
            // 
            // rdAnual
            // 
            this.rdAnual.AutoSize = true;
            this.rdAnual.Location = new System.Drawing.Point(24, 38);
            this.rdAnual.Name = "rdAnual";
            this.rdAnual.Size = new System.Drawing.Size(62, 17);
            this.rdAnual.TabIndex = 26;
            this.rdAnual.Text = "Un Año";
            this.rdAnual.UseVisualStyleBackColor = true;
            // 
            // rdMensual
            // 
            this.rdMensual.AutoSize = true;
            this.rdMensual.Location = new System.Drawing.Point(24, 15);
            this.rdMensual.Name = "rdMensual";
            this.rdMensual.Size = new System.Drawing.Size(66, 17);
            this.rdMensual.TabIndex = 25;
            this.rdMensual.Text = "6 Meses";
            this.rdMensual.UseVisualStyleBackColor = true;
            // 
            // lblct
            // 
            this.lblct.AutoSize = true;
            this.lblct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblct.Location = new System.Drawing.Point(109, 38);
            this.lblct.Name = "lblct";
            this.lblct.Size = new System.Drawing.Size(44, 13);
            this.lblct.TabIndex = 23;
            this.lblct.Text = "Ultimos:";
            // 
            // chkOtro
            // 
            this.chkOtro.AutoSize = true;
            this.chkOtro.Location = new System.Drawing.Point(159, 15);
            this.chkOtro.Name = "chkOtro";
            this.chkOtro.Size = new System.Drawing.Size(46, 17);
            this.chkOtro.TabIndex = 22;
            this.chkOtro.Text = "Otro";
            this.chkOtro.UseVisualStyleBackColor = true;
            this.chkOtro.CheckedChanged += new System.EventHandler(this.chkOtro_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Gastos en los ultimos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(431, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Reporte de Estadistica";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(655, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 32);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCargarGrillaCompleta
            // 
            this.btnCargarGrillaCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarGrillaCompleta.Location = new System.Drawing.Point(17, 113);
            this.btnCargarGrillaCompleta.Name = "btnCargarGrillaCompleta";
            this.btnCargarGrillaCompleta.Size = new System.Drawing.Size(221, 32);
            this.btnCargarGrillaCompleta.TabIndex = 35;
            this.btnCargarGrillaCompleta.Text = "Cargar todas las Propiedades";
            this.btnCargarGrillaCompleta.UseVisualStyleBackColor = true;
            this.btnCargarGrillaCompleta.Click += new System.EventHandler(this.btnCargarGrillaCompleta_Click);
            // 
            // frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 905);
            this.Controls.Add(this.btnCargarGrillaCompleta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtTipoPropiedad);
            this.Controls.Add(this.txtDesigCatastral);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtDesigCat);
            this.Controls.Add(this.lblDesigCat);
            this.Controls.Add(this.grillaPropiedades);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad";
            this.Load += new System.EventHandler(this.frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grillaPropiedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignacionCatastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoOperacion;
        private System.Windows.Forms.TextBox txtDesigCat;
        private System.Windows.Forms.Label lblDesigCat;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtTipoPropiedad;
        private System.Windows.Forms.TextBox txtDesigCatastral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCargarGrillaCompleta;
        private System.Windows.Forms.MaskedTextBox txtDiasOtro;
        private System.Windows.Forms.CheckBox rdTotal;
        private System.Windows.Forms.CheckBox rdAnual;
        private System.Windows.Forms.CheckBox rdMensual;
        private System.Windows.Forms.Label lblct;
        private System.Windows.Forms.CheckBox chkOtro;
        private System.Windows.Forms.Label label9;
    }
}