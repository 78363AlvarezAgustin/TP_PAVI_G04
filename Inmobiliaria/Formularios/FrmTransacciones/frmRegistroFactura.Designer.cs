
namespace Inmobiliaria.Formularios.FrmTransacciones
{
    partial class frmRegistroFactura
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
            this.txtNumFac = new System.Windows.Forms.MaskedTextBox();
            this.cmbMedioPagos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDesigCatastral = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAgregarPropiedad = new System.Windows.Forms.Button();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.btnBuscarPropiedad = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIDBarrio = new System.Windows.Forms.TextBox();
            this.btnBuscarDueño = new System.Windows.Forms.Button();
            this.txtApellidoDueño = new System.Windows.Forms.TextBox();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.btnAgregarDueño = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDniDueño = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.grillaPropiedades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaDueño = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalComision = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDueño)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumFac
            // 
            this.txtNumFac.Enabled = false;
            this.txtNumFac.Location = new System.Drawing.Point(136, 69);
            this.txtNumFac.Mask = "99999";
            this.txtNumFac.Name = "txtNumFac";
            this.txtNumFac.Size = new System.Drawing.Size(38, 20);
            this.txtNumFac.TabIndex = 66;
            this.txtNumFac.ValidatingType = typeof(int);
            // 
            // cmbMedioPagos
            // 
            this.cmbMedioPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPagos.FormattingEnabled = true;
            this.cmbMedioPagos.Location = new System.Drawing.Point(136, 167);
            this.cmbMedioPagos.Name = "cmbMedioPagos";
            this.cmbMedioPagos.Size = new System.Drawing.Size(160, 21);
            this.cmbMedioPagos.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(12, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 25);
            this.label12.TabIndex = 83;
            this.label12.Text = "Nueva Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 74;
            this.label4.Text = "Medio Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "Total Comision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "Numero Factura";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(136, 101);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(161, 20);
            this.txtFecha.TabIndex = 68;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(595, 11);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 94;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Enabled = false;
            this.txtApellidoCliente.Location = new System.Drawing.Point(636, 50);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(119, 20);
            this.txtApellidoCliente.TabIndex = 91;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(450, 49);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(119, 20);
            this.txtNombreCliente.TabIndex = 92;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(807, 79);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(106, 26);
            this.btnAgregarAlumno.TabIndex = 95;
            this.btnAgregarAlumno.Text = "Agregar Cliente";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(396, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 88;
            this.label15.Text = "DNI de cliente";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(480, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(109, 20);
            this.txtDni.TabIndex = 93;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(586, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 89;
            this.label16.Text = "Apellido";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(400, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 90;
            this.label17.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 90;
            this.label11.Text = "Calle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(562, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 89;
            this.label13.Text = "Nro Calle";
            // 
            // txtDesigCatastral
            // 
            this.txtDesigCatastral.Location = new System.Drawing.Point(510, 237);
            this.txtDesigCatastral.Name = "txtDesigCatastral";
            this.txtDesigCatastral.Size = new System.Drawing.Size(109, 20);
            this.txtDesigCatastral.TabIndex = 93;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(390, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "Designacion Catastral";
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(807, 304);
            this.btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            this.btnAgregarPropiedad.Size = new System.Drawing.Size(106, 31);
            this.btnAgregarPropiedad.TabIndex = 95;
            this.btnAgregarPropiedad.Text = "Agregar Propiedad";
            this.btnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.btnAgregarPropiedad.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(426, 271);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(119, 20);
            this.txtCalle.TabIndex = 92;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Enabled = false;
            this.txtNroCalle.Location = new System.Drawing.Point(612, 272);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(119, 20);
            this.txtNroCalle.TabIndex = 91;
            // 
            // btnBuscarPropiedad
            // 
            this.btnBuscarPropiedad.Location = new System.Drawing.Point(625, 236);
            this.btnBuscarPropiedad.Name = "btnBuscarPropiedad";
            this.btnBuscarPropiedad.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPropiedad.TabIndex = 94;
            this.btnBuscarPropiedad.Text = "Buscar";
            this.btnBuscarPropiedad.UseVisualStyleBackColor = true;
            this.btnBuscarPropiedad.Click += new System.EventHandler(this.btnBuscarPropiedad_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(746, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 89;
            this.label19.Text = "Id Barrio";
            // 
            // txtIDBarrio
            // 
            this.txtIDBarrio.Enabled = false;
            this.txtIDBarrio.Location = new System.Drawing.Point(794, 272);
            this.txtIDBarrio.Name = "txtIDBarrio";
            this.txtIDBarrio.Size = new System.Drawing.Size(119, 20);
            this.txtIDBarrio.TabIndex = 91;
            // 
            // btnBuscarDueño
            // 
            this.btnBuscarDueño.Location = new System.Drawing.Point(585, 473);
            this.btnBuscarDueño.Name = "btnBuscarDueño";
            this.btnBuscarDueño.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDueño.TabIndex = 104;
            this.btnBuscarDueño.Text = "Buscar";
            this.btnBuscarDueño.UseVisualStyleBackColor = true;
            this.btnBuscarDueño.Click += new System.EventHandler(this.btnBuscarDueño_Click);
            // 
            // txtApellidoDueño
            // 
            this.txtApellidoDueño.Enabled = false;
            this.txtApellidoDueño.Location = new System.Drawing.Point(625, 510);
            this.txtApellidoDueño.Name = "txtApellidoDueño";
            this.txtApellidoDueño.Size = new System.Drawing.Size(119, 20);
            this.txtApellidoDueño.TabIndex = 101;
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Enabled = false;
            this.txtNombreDueño.Location = new System.Drawing.Point(439, 509);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(119, 20);
            this.txtNombreDueño.TabIndex = 102;
            // 
            // btnAgregarDueño
            // 
            this.btnAgregarDueño.Location = new System.Drawing.Point(807, 510);
            this.btnAgregarDueño.Name = "btnAgregarDueño";
            this.btnAgregarDueño.Size = new System.Drawing.Size(106, 29);
            this.btnAgregarDueño.TabIndex = 105;
            this.btnAgregarDueño.Text = "Agregar Dueño";
            this.btnAgregarDueño.UseVisualStyleBackColor = true;
            this.btnAgregarDueño.Click += new System.EventHandler(this.btnAgregarDueño_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(386, 477);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 98;
            this.label21.Text = "DNI de dueño";
            // 
            // txtDniDueño
            // 
            this.txtDniDueño.Location = new System.Drawing.Point(468, 474);
            this.txtDniDueño.Name = "txtDniDueño";
            this.txtDniDueño.Size = new System.Drawing.Size(109, 20);
            this.txtDniDueño.TabIndex = 103;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(575, 513);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 99;
            this.label22.Text = "Apellido";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(389, 513);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 100;
            this.label23.Text = "Nombre";
            // 
            // grillaClientes
            // 
            this.grillaClientes.AllowUserToAddRows = false;
            this.grillaClientes.AllowUserToDeleteRows = false;
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.Nombre,
            this.Apellido});
            this.grillaClientes.Location = new System.Drawing.Point(372, 111);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.ReadOnly = true;
            this.grillaClientes.Size = new System.Drawing.Size(558, 110);
            this.grillaClientes.TabIndex = 106;
            // 
            // grillaPropiedades
            // 
            this.grillaPropiedades.AllowUserToAddRows = false;
            this.grillaPropiedades.AllowUserToDeleteRows = false;
            this.grillaPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Barrio});
            this.grillaPropiedades.Location = new System.Drawing.Point(372, 340);
            this.grillaPropiedades.Name = "grillaPropiedades";
            this.grillaPropiedades.ReadOnly = true;
            this.grillaPropiedades.Size = new System.Drawing.Size(558, 110);
            this.grillaPropiedades.TabIndex = 106;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Desig Catastral";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre Calle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nro calle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // grillaDueño
            // 
            this.grillaDueño.AllowUserToAddRows = false;
            this.grillaDueño.AllowUserToDeleteRows = false;
            this.grillaDueño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDueño.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.grillaDueño.Location = new System.Drawing.Point(372, 545);
            this.grillaDueño.Name = "grillaDueño";
            this.grillaDueño.ReadOnly = true;
            this.grillaDueño.Size = new System.Drawing.Size(558, 110);
            this.grillaDueño.TabIndex = 106;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // txtTotalComision
            // 
            this.txtTotalComision.Location = new System.Drawing.Point(136, 134);
            this.txtTotalComision.Mask = "99999";
            this.txtTotalComision.Name = "txtTotalComision";
            this.txtTotalComision.Size = new System.Drawing.Size(38, 20);
            this.txtTotalComision.TabIndex = 107;
            this.txtTotalComision.ValidatingType = typeof(int);
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarFactura.Image = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnGuardarFactura.Location = new System.Drawing.Point(229, 221);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(68, 70);
            this.btnGuardarFactura.TabIndex = 108;
            this.btnGuardarFactura.UseVisualStyleBackColor = false;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 200;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.button1.Location = new System.Drawing.Point(121, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 70);
            this.button1.TabIndex = 109;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegistroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarFactura);
            this.Controls.Add(this.txtTotalComision);
            this.Controls.Add(this.grillaDueño);
            this.Controls.Add(this.grillaPropiedades);
            this.Controls.Add(this.grillaClientes);
            this.Controls.Add(this.btnBuscarDueño);
            this.Controls.Add(this.txtApellidoDueño);
            this.Controls.Add(this.txtNombreDueño);
            this.Controls.Add(this.btnAgregarDueño);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtDniDueño);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnBuscarPropiedad);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtIDBarrio);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.txtDesigCatastral);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtNumFac);
            this.Controls.Add(this.cmbMedioPagos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Name = "frmRegistroFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmobiliaria";
            this.Load += new System.EventHandler(this.frmRegistroFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDueño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNumFac;
        public System.Windows.Forms.ComboBox cmbMedioPagos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDesigCatastral;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAgregarPropiedad;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Button btnBuscarPropiedad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIDBarrio;
        private System.Windows.Forms.Button btnBuscarDueño;
        private System.Windows.Forms.TextBox txtApellidoDueño;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.Button btnAgregarDueño;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDniDueño;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.DataGridView grillaPropiedades;
        private System.Windows.Forms.DataGridView grillaDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.MaskedTextBox txtTotalComision;
        private System.Windows.Forms.Button btnGuardarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button button1;
    }
}