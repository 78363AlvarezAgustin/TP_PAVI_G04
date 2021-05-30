
namespace Inmobiliaria.Formularios.FrmTransacciones
{
    partial class frmRegistroExpensas
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
            this.grillaExpensas = new System.Windows.Forms.DataGridView();
            this.id_edificioExpensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.grillaEdificios = new System.Windows.Forms.DataGridView();
            this.id_edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_deptos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiene_ascensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtIdEdificio = new System.Windows.Forms.TextBox();
            this.lblPropiedad = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMedioPublicitario = new System.Windows.Forms.Label();
            this.lblPublicidades = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarPublicidad = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaExpensas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEdificios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Expensas";
            // 
            // grillaExpensas
            // 
            this.grillaExpensas.AllowUserToAddRows = false;
            this.grillaExpensas.AllowUserToDeleteRows = false;
            this.grillaExpensas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaExpensas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_edificioExpensa,
            this.mes,
            this.año,
            this.importe});
            this.grillaExpensas.Location = new System.Drawing.Point(50, 406);
            this.grillaExpensas.Name = "grillaExpensas";
            this.grillaExpensas.ReadOnly = true;
            this.grillaExpensas.Size = new System.Drawing.Size(463, 144);
            this.grillaExpensas.TabIndex = 37;
            // 
            // id_edificioExpensa
            // 
            this.id_edificioExpensa.DataPropertyName = "id_edificio";
            this.id_edificioExpensa.HeaderText = "id_edificio";
            this.id_edificioExpensa.Name = "id_edificioExpensa";
            this.id_edificioExpensa.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // año
            // 
            this.año.DataPropertyName = "año";
            this.año.HeaderText = "Año";
            this.año.Name = "año";
            this.año.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.DataPropertyName = "importe";
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(364, 253);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(249, 16);
            this.lblMensaje.TabIndex = 36;
            this.lblMensaje.Text = "Debes seleccionar un edificio en la grilla";
            // 
            // grillaEdificios
            // 
            this.grillaEdificios.AllowUserToAddRows = false;
            this.grillaEdificios.AllowUserToDeleteRows = false;
            this.grillaEdificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEdificios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_edificio,
            this.n_edificio,
            this.cantidad_deptos,
            this.tiene_ascensor,
            this.calle,
            this.nro_calle,
            this.id_barrio});
            this.grillaEdificios.Location = new System.Drawing.Point(367, 91);
            this.grillaEdificios.Name = "grillaEdificios";
            this.grillaEdificios.ReadOnly = true;
            this.grillaEdificios.Size = new System.Drawing.Size(730, 159);
            this.grillaEdificios.TabIndex = 35;
            this.grillaEdificios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaEdificios_CellClick);
            // 
            // id_edificio
            // 
            this.id_edificio.DataPropertyName = "id_edificio";
            this.id_edificio.HeaderText = "id_edificio";
            this.id_edificio.Name = "id_edificio";
            this.id_edificio.ReadOnly = true;
            // 
            // n_edificio
            // 
            this.n_edificio.DataPropertyName = "n_edificio";
            this.n_edificio.HeaderText = "n_edificio";
            this.n_edificio.Name = "n_edificio";
            this.n_edificio.ReadOnly = true;
            // 
            // cantidad_deptos
            // 
            this.cantidad_deptos.DataPropertyName = "cantidad_deptos";
            this.cantidad_deptos.HeaderText = "cantidad_deptos";
            this.cantidad_deptos.Name = "cantidad_deptos";
            this.cantidad_deptos.ReadOnly = true;
            this.cantidad_deptos.Width = 80;
            // 
            // tiene_ascensor
            // 
            this.tiene_ascensor.DataPropertyName = "tiene_ascensor";
            this.tiene_ascensor.HeaderText = "tiene_ascensor";
            this.tiene_ascensor.Name = "tiene_ascensor";
            this.tiene_ascensor.ReadOnly = true;
            this.tiene_ascensor.Width = 75;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // nro_calle
            // 
            this.nro_calle.DataPropertyName = "nro_calle";
            this.nro_calle.HeaderText = "nro_calle";
            this.nro_calle.Name = "nro_calle";
            this.nro_calle.ReadOnly = true;
            this.nro_calle.Width = 75;
            // 
            // id_barrio
            // 
            this.id_barrio.DataPropertyName = "id_barrio";
            this.id_barrio.HeaderText = "id_barrio";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Width = 75;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(720, 313);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(81, 74);
            this.btnLimpiarCampos.TabIndex = 30;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click_1);
            // 
            // txtIdEdificio
            // 
            this.txtIdEdificio.Enabled = false;
            this.txtIdEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEdificio.Location = new System.Drawing.Point(190, 122);
            this.txtIdEdificio.Name = "txtIdEdificio";
            this.txtIdEdificio.Size = new System.Drawing.Size(137, 24);
            this.txtIdEdificio.TabIndex = 34;
            // 
            // lblPropiedad
            // 
            this.lblPropiedad.AutoSize = true;
            this.lblPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropiedad.Location = new System.Drawing.Point(364, 70);
            this.lblPropiedad.Name = "lblPropiedad";
            this.lblPropiedad.Size = new System.Drawing.Size(64, 18);
            this.lblPropiedad.TabIndex = 33;
            this.lblPropiedad.Text = "Edificios";
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(110, 269);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(62, 18);
            this.lblSeccion.TabIndex = 32;
            this.lblSeccion.Text = "Importe:";
            // 
            // txtaño
            // 
            this.txtaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaño.Location = new System.Drawing.Point(190, 220);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(137, 24);
            this.txtaño.TabIndex = 24;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(140, 223);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 18);
            this.lblCosto.TabIndex = 31;
            this.lblCosto.Text = "Año";
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(190, 173);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(137, 24);
            this.txtMes.TabIndex = 22;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(139, 173);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(41, 18);
            this.lblDescripcion.TabIndex = 28;
            this.lblDescripcion.Text = "Mes:";
            // 
            // lblMedioPublicitario
            // 
            this.lblMedioPublicitario.AutoSize = true;
            this.lblMedioPublicitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedioPublicitario.Location = new System.Drawing.Point(89, 122);
            this.lblMedioPublicitario.Name = "lblMedioPublicitario";
            this.lblMedioPublicitario.Size = new System.Drawing.Size(95, 18);
            this.lblMedioPublicitario.TabIndex = 25;
            this.lblMedioPublicitario.Text = "Id de Edificio:";
            // 
            // lblPublicidades
            // 
            this.lblPublicidades.AutoSize = true;
            this.lblPublicidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicidades.Location = new System.Drawing.Point(45, 28);
            this.lblPublicidades.Name = "lblPublicidades";
            this.lblPublicidades.Size = new System.Drawing.Size(222, 25);
            this.lblPublicidades.TabIndex = 18;
            this.lblPublicidades.Text = "Registro de Expensas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_728918;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(950, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 74);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarPublicidad
            // 
            this.btnGuardarPublicidad.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnGuardarPublicidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarPublicidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPublicidad.Location = new System.Drawing.Point(839, 313);
            this.btnGuardarPublicidad.Name = "btnGuardarPublicidad";
            this.btnGuardarPublicidad.Size = new System.Drawing.Size(74, 74);
            this.btnGuardarPublicidad.TabIndex = 27;
            this.btnGuardarPublicidad.UseVisualStyleBackColor = true;
            this.btnGuardarPublicidad.Click += new System.EventHandler(this.btnGuardarPublicidad_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(190, 266);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(137, 24);
            this.txtImporte.TabIndex = 39;
            // 
            // frmRegistroExpensas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 562);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaExpensas);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.grillaEdificios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarPublicidad);
            this.Controls.Add(this.txtIdEdificio);
            this.Controls.Add(this.lblPropiedad);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMedioPublicitario);
            this.Controls.Add(this.lblPublicidades);
            this.Name = "frmRegistroExpensas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Expensas";
            this.Load += new System.EventHandler(this.frmRegistroExpensas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaExpensas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEdificios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaExpensas;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView grillaEdificios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnGuardarPublicidad;
        private System.Windows.Forms.TextBox txtIdEdificio;
        private System.Windows.Forms.Label lblPropiedad;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMedioPublicitario;
        private System.Windows.Forms.Label lblPublicidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_deptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiene_ascensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_edificioExpensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
    }
}