
namespace Inmobiliaria
{
    partial class ABM_Edificio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Edificio));
            this.gdrEdificios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDptos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ascensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkMostrarTodosEdificios = new System.Windows.Forms.CheckBox();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.lblNombreEdificio = new System.Windows.Forms.Label();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEdificios)).BeginInit();
            this.SuspendLayout();
            // 
            // gdrEdificios
            // 
            this.gdrEdificios.AllowUserToAddRows = false;
            this.gdrEdificios.AllowUserToDeleteRows = false;
            this.gdrEdificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEdificios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.CantidadDptos,
            this.Ascensor,
            this.Calle,
            this.NumeroCalle,
            this.IdBarrio});
            this.gdrEdificios.Location = new System.Drawing.Point(35, 173);
            this.gdrEdificios.Name = "gdrEdificios";
            this.gdrEdificios.ReadOnly = true;
            this.gdrEdificios.Size = new System.Drawing.Size(527, 289);
            this.gdrEdificios.TabIndex = 14;
            this.gdrEdificios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEdificios_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "n_edificio";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
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
            this.NumeroCalle.Width = 70;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "id_barrio";
            this.IdBarrio.HeaderText = "IdBarrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            this.IdBarrio.Width = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(67, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Edificios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(471, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkMostrarTodosEdificios
            // 
            this.chkMostrarTodosEdificios.AutoSize = true;
            this.chkMostrarTodosEdificios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarTodosEdificios.Location = new System.Drawing.Point(205, 133);
            this.chkMostrarTodosEdificios.Name = "chkMostrarTodosEdificios";
            this.chkMostrarTodosEdificios.Size = new System.Drawing.Size(230, 22);
            this.chkMostrarTodosEdificios.TabIndex = 19;
            this.chkMostrarTodosEdificios.Text = "Mostrar todos los edificios";
            this.chkMostrarTodosEdificios.UseVisualStyleBackColor = true;
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEdificio.Location = new System.Drawing.Point(205, 103);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(233, 24);
            this.txtNombreEdificio.TabIndex = 17;
            // 
            // lblNombreEdificio
            // 
            this.lblNombreEdificio.AutoSize = true;
            this.lblNombreEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEdificio.Location = new System.Drawing.Point(70, 103);
            this.lblNombreEdificio.Name = "lblNombreEdificio";
            this.lblNombreEdificio.Size = new System.Drawing.Size(129, 18);
            this.lblNombreEdificio.TabIndex = 16;
            this.lblNombreEdificio.Text = "Nombre Edificio";
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEdificio.Image")));
            this.btnAgregarEdificio.Location = new System.Drawing.Point(240, 468);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(75, 60);
            this.btnAgregarEdificio.TabIndex = 49;
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            this.btnAgregarEdificio.Click += new System.EventHandler(this.btnAgregarEdificio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(321, 468);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 60);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ABM_Edificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 543);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarEdificio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkMostrarTodosEdificios);
            this.Controls.Add(this.txtNombreEdificio);
            this.Controls.Add(this.lblNombreEdificio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gdrEdificios);
            this.Name = "ABM_Edificio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Edificios";
            this.Load += new System.EventHandler(this.AltaEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEdificios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gdrEdificios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ascensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkMostrarTodosEdificios;
        private System.Windows.Forms.TextBox txtNombreEdificio;
        private System.Windows.Forms.Label lblNombreEdificio;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.Button btnSalir;
    }
}