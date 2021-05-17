
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroBarrios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gdrBarrios = new System.Windows.Forms.DataGridView();
            this.txtFiltrarPorBarrio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.IdBarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gdrBarrios);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltrarPorBarrio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 422);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Barrios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Seleccione una Localidad de la tabla para modificar o eliminar*";
            // 
            // gdrBarrios
            // 
            this.gdrBarrios.AllowUserToAddRows = false;
            this.gdrBarrios.AllowUserToDeleteRows = false;
            this.gdrBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBarr,
            this.Nombre,
            this.IdLocalidad});
            this.gdrBarrios.Location = new System.Drawing.Point(5, 105);
            this.gdrBarrios.Name = "gdrBarrios";
            this.gdrBarrios.ReadOnly = true;
            this.gdrBarrios.Size = new System.Drawing.Size(483, 282);
            this.gdrBarrios.TabIndex = 1;
            this.gdrBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrBarrios_CellClick);
            // 
            // txtFiltrarPorBarrio
            // 
            this.txtFiltrarPorBarrio.Location = new System.Drawing.Point(154, 47);
            this.txtFiltrarPorBarrio.Name = "txtFiltrarPorBarrio";
            this.txtFiltrarPorBarrio.Size = new System.Drawing.Size(136, 26);
            this.txtFiltrarPorBarrio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Barrio:";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.Control;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInicio.Image = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.btnInicio.Location = new System.Drawing.Point(431, 437);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(69, 75);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_reload_46828;
            this.btnActualizar.Location = new System.Drawing.Point(144, 437);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 75);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_add1__32378;
            this.btnAgregar.Location = new System.Drawing.Point(35, 437);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 75);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.Image = global::Inmobiliaria.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(301, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 43);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // IdBarr
            // 
            this.IdBarr.DataPropertyName = "id_barrio";
            this.IdBarr.HeaderText = "ID";
            this.IdBarr.Name = "IdBarr";
            this.IdBarr.ReadOnly = true;
            this.IdBarr.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "n_barrio";
            this.Nombre.HeaderText = "Nombre Barrio";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 195;
            // 
            // IdLocalidad
            // 
            this.IdLocalidad.DataPropertyName = "n_localidad";
            this.IdLocalidad.HeaderText = "Localidad";
            this.IdLocalidad.Name = "IdLocalidad";
            this.IdLocalidad.ReadOnly = true;
            this.IdLocalidad.Width = 195;
            // 
            // frmFiltroBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 517);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFiltroBarrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmobiliaria";
            this.Load += new System.EventHandler(this.frmFiltroBarrios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBarrios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gdrBarrios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltrarPorBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocalidad;
    }
}