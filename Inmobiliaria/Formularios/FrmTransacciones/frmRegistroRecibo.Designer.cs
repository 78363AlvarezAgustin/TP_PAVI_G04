
namespace Inmobiliaria.Formularios.FrmTransacciones
{
    partial class frmRegistroRecibo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdRecibo = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtMesExpensa = new System.Windows.Forms.TextBox();
            this.txtAñoExpensa = new System.Windows.Forms.TextBox();
            this.txtIdEdificio = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grillaDepartamentos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cmbEncargadoExp = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.IdEdificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegajoEncargadoExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaRecibos = new System.Windows.Forms.DataGridView();
            this.IdRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesExpensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoExpensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegajoEncargadoExp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEdificio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaCobro = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Recibo";
            // 
            // txtIdRecibo
            // 
            this.txtIdRecibo.Enabled = false;
            this.txtIdRecibo.Location = new System.Drawing.Point(176, 69);
            this.txtIdRecibo.Name = "txtIdRecibo";
            this.txtIdRecibo.Size = new System.Drawing.Size(100, 20);
            this.txtIdRecibo.TabIndex = 1;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(176, 154);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 3;
            // 
            // txtMesExpensa
            // 
            this.txtMesExpensa.Location = new System.Drawing.Point(176, 196);
            this.txtMesExpensa.Name = "txtMesExpensa";
            this.txtMesExpensa.Size = new System.Drawing.Size(100, 20);
            this.txtMesExpensa.TabIndex = 4;
            // 
            // txtAñoExpensa
            // 
            this.txtAñoExpensa.Location = new System.Drawing.Point(176, 238);
            this.txtAñoExpensa.Name = "txtAñoExpensa";
            this.txtAñoExpensa.Size = new System.Drawing.Size(100, 20);
            this.txtAñoExpensa.TabIndex = 5;
            // 
            // txtIdEdificio
            // 
            this.txtIdEdificio.Enabled = false;
            this.txtIdEdificio.Location = new System.Drawing.Point(176, 327);
            this.txtIdEdificio.Name = "txtIdEdificio";
            this.txtIdEdificio.Size = new System.Drawing.Size(100, 20);
            this.txtIdEdificio.TabIndex = 7;
            // 
            // txtPiso
            // 
            this.txtPiso.Enabled = false;
            this.txtPiso.Location = new System.Drawing.Point(176, 371);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 8;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Enabled = false;
            this.txtDenominacion.Location = new System.Drawing.Point(176, 412);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(100, 20);
            this.txtDenominacion.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nro Recibo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de Cobro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Importe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mes de Expensa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Año de Expensa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Encargado Expensas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nro Edificio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Piso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Denominación:";
            // 
            // grillaDepartamentos
            // 
            this.grillaDepartamentos.AllowUserToAddRows = false;
            this.grillaDepartamentos.AllowUserToDeleteRows = false;
            this.grillaDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEdificio,
            this.Piso,
            this.Denominacion,
            this.LegajoEncargadoExp});
            this.grillaDepartamentos.Location = new System.Drawing.Point(370, 69);
            this.grillaDepartamentos.Name = "grillaDepartamentos";
            this.grillaDepartamentos.ReadOnly = true;
            this.grillaDepartamentos.Size = new System.Drawing.Size(543, 258);
            this.grillaDepartamentos.TabIndex = 19;
            this.grillaDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDepartamentos_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(508, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "(*) Elija una fila para autocompletar el ecargado exp, nro de edificio, piso y de" +
    "nominación del departamento";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(370, 367);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(103, 65);
            this.btnLimpiarCampos.TabIndex = 21;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // cmbEncargadoExp
            // 
            this.cmbEncargadoExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncargadoExp.Enabled = false;
            this.cmbEncargadoExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEncargadoExp.FormattingEnabled = true;
            this.cmbEncargadoExp.Location = new System.Drawing.Point(176, 281);
            this.cmbEncargadoExp.Name = "cmbEncargadoExp";
            this.cmbEncargadoExp.Size = new System.Drawing.Size(100, 26);
            this.cmbEncargadoExp.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_7289187;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(848, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 65);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IdEdificio
            // 
            this.IdEdificio.DataPropertyName = "id_edificio";
            this.IdEdificio.HeaderText = "ID Edificio";
            this.IdEdificio.Name = "IdEdificio";
            this.IdEdificio.ReadOnly = true;
            // 
            // Piso
            // 
            this.Piso.DataPropertyName = "piso";
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            // 
            // Denominacion
            // 
            this.Denominacion.DataPropertyName = "denominacion";
            this.Denominacion.HeaderText = "Denominación";
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.ReadOnly = true;
            // 
            // LegajoEncargadoExp
            // 
            this.LegajoEncargadoExp.DataPropertyName = "legajo_encargado_exp";
            this.LegajoEncargadoExp.HeaderText = "Legajo Encargado Exp";
            this.LegajoEncargadoExp.Name = "LegajoEncargadoExp";
            this.LegajoEncargadoExp.ReadOnly = true;
            this.LegajoEncargadoExp.Width = 200;
            // 
            // grillaRecibos
            // 
            this.grillaRecibos.AllowUserToAddRows = false;
            this.grillaRecibos.AllowUserToDeleteRows = false;
            this.grillaRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRecibo,
            this.FechaCobro,
            this.Importe,
            this.MesExpensa,
            this.AñoExpensa,
            this.LegajoEncargadoExp2,
            this.IdEdificio2,
            this.Piso2,
            this.Denominacion2});
            this.grillaRecibos.Location = new System.Drawing.Point(51, 507);
            this.grillaRecibos.Name = "grillaRecibos";
            this.grillaRecibos.ReadOnly = true;
            this.grillaRecibos.Size = new System.Drawing.Size(861, 268);
            this.grillaRecibos.TabIndex = 24;
            // 
            // IdRecibo
            // 
            this.IdRecibo.DataPropertyName = "id_recibo";
            this.IdRecibo.HeaderText = "ID Recibo";
            this.IdRecibo.Name = "IdRecibo";
            this.IdRecibo.ReadOnly = true;
            this.IdRecibo.Width = 80;
            // 
            // FechaCobro
            // 
            this.FechaCobro.DataPropertyName = "fecha_cobro";
            this.FechaCobro.HeaderText = "Fecha Cobro";
            this.FechaCobro.Name = "FechaCobro";
            this.FechaCobro.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 80;
            // 
            // MesExpensa
            // 
            this.MesExpensa.DataPropertyName = "mes_expensa";
            this.MesExpensa.HeaderText = "Mes de Expensa";
            this.MesExpensa.Name = "MesExpensa";
            this.MesExpensa.ReadOnly = true;
            this.MesExpensa.Width = 80;
            // 
            // AñoExpensa
            // 
            this.AñoExpensa.DataPropertyName = "año_expensa";
            this.AñoExpensa.HeaderText = "Año de Expensa";
            this.AñoExpensa.Name = "AñoExpensa";
            this.AñoExpensa.ReadOnly = true;
            this.AñoExpensa.Width = 80;
            // 
            // LegajoEncargadoExp2
            // 
            this.LegajoEncargadoExp2.DataPropertyName = "legajo_encargado_exp";
            this.LegajoEncargadoExp2.HeaderText = "Legajo Encargado Exp";
            this.LegajoEncargadoExp2.Name = "LegajoEncargadoExp2";
            this.LegajoEncargadoExp2.ReadOnly = true;
            this.LegajoEncargadoExp2.Width = 150;
            // 
            // IdEdificio2
            // 
            this.IdEdificio2.DataPropertyName = "id_edificio";
            this.IdEdificio2.HeaderText = "ID Edificio";
            this.IdEdificio2.Name = "IdEdificio2";
            this.IdEdificio2.ReadOnly = true;
            this.IdEdificio2.Width = 90;
            // 
            // Piso2
            // 
            this.Piso2.DataPropertyName = "piso";
            this.Piso2.HeaderText = "Piso";
            this.Piso2.Name = "Piso2";
            this.Piso2.ReadOnly = true;
            this.Piso2.Width = 58;
            // 
            // Denominacion2
            // 
            this.Denominacion2.DataPropertyName = "denominacion";
            this.Denominacion2.HeaderText = "Denominación";
            this.Denominacion2.Name = "Denominacion2";
            this.Denominacion2.ReadOnly = true;
            // 
            // txtFechaCobro
            // 
            this.txtFechaCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCobro.Location = new System.Drawing.Point(176, 108);
            this.txtFechaCobro.Mask = "00/00/0000";
            this.txtFechaCobro.Name = "txtFechaCobro";
            this.txtFechaCobro.Size = new System.Drawing.Size(100, 24);
            this.txtFechaCobro.TabIndex = 2;
            this.txtFechaCobro.ValidatingType = typeof(System.DateTime);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_2856573;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(627, 367);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 65);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmRegistroRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 830);
            this.Controls.Add(this.txtFechaCobro);
            this.Controls.Add(this.grillaRecibos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEncargadoExp);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grillaDepartamentos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtIdEdificio);
            this.Controls.Add(this.txtAñoExpensa);
            this.Controls.Add(this.txtMesExpensa);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtIdRecibo);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Recibo";
            this.Load += new System.EventHandler(this.frmRegistroRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdRecibo;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtMesExpensa;
        private System.Windows.Forms.TextBox txtAñoExpensa;
        private System.Windows.Forms.TextBox txtIdEdificio;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grillaDepartamentos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox cmbEncargadoExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEdificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoEncargadoExp;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grillaRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesExpensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoExpensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoEncargadoExp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEdificio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion2;
        private System.Windows.Forms.MaskedTextBox txtFechaCobro;
    }
}