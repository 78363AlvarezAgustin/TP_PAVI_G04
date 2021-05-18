
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroProveedores
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkMostrarTodosProvee = new System.Windows.Forms.CheckBox();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.lblNro = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(73, 340);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(445, 17);
            this.lblMensaje.TabIndex = 42;
            this.lblMensaje.Text = "Para modificar o eliminar un proveedor debe seleccionarlo de la grilla";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__32378;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(492, 426);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 74);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(592, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 74);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
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
            this.grillaProveedores.Location = new System.Drawing.Point(76, 170);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.ReadOnly = true;
            this.grillaProveedores.Size = new System.Drawing.Size(590, 150);
            this.grillaProveedores.TabIndex = 39;
            this.grillaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProveedores_CellClick_1);
            this.grillaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProveedores_CellContentClick_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(575, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // chkMostrarTodosProvee
            // 
            this.chkMostrarTodosProvee.AutoSize = true;
            this.chkMostrarTodosProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarTodosProvee.Location = new System.Drawing.Point(76, 124);
            this.chkMostrarTodosProvee.Name = "chkMostrarTodosProvee";
            this.chkMostrarTodosProvee.Size = new System.Drawing.Size(261, 22);
            this.chkMostrarTodosProvee.TabIndex = 37;
            this.chkMostrarTodosProvee.Text = "Mostrar todos los proveedores";
            this.chkMostrarTodosProvee.UseVisualStyleBackColor = true;
            this.chkMostrarTodosProvee.CheckedChanged += new System.EventHandler(this.chkMostrarTodosProvee_CheckedChanged_1);
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(37, 29);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(134, 25);
            this.lblProveedores.TabIndex = 36;
            this.lblProveedores.Text = "Proveedores";
            // 
            // txtNro
            // 
            this.txtNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNro.Location = new System.Drawing.Point(206, 81);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(103, 24);
            this.txtNro.TabIndex = 35;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(73, 84);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(124, 18);
            this.lblNro.TabIndex = 34;
            this.lblNro.Text = "Nro Proveedor:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id_proveedor";
            this.Id.HeaderText = "Id de proveedor";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 120;
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
            this.Telefono.Width = 140;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_reload_46828;
            this.btnActualizar.Location = new System.Drawing.Point(394, 426);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 75);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(76, 436);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(96, 52);
            this.btnLimpiarCampos.TabIndex = 44;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click_1);
            // 
            // frmFiltroProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 544);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grillaProveedores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkMostrarTodosProvee);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.lblNro);
            this.Name = "frmFiltroProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFiltroProveedores";
            this.Load += new System.EventHandler(this.frmFiltroProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView grillaProveedores;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkMostrarTodosProvee;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}