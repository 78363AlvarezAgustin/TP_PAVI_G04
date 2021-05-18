
namespace Inmobiliaria.Formularios
{
    partial class frmABMTipoProp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMTipoProp));
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtTipoPropiedad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gdrTiposPropiedad = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarModificar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPropiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrTiposPropiedad)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(333, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 20);
            this.txtID.TabIndex = 78;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(458, 349);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 66);
            this.btnLimpiarCampos.TabIndex = 73;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtTipoPropiedad
            // 
            this.txtTipoPropiedad.Location = new System.Drawing.Point(154, 65);
            this.txtTipoPropiedad.Name = "txtTipoPropiedad";
            this.txtTipoPropiedad.Size = new System.Drawing.Size(130, 20);
            this.txtTipoPropiedad.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "Tipo de Propiedad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(43, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 31);
            this.label7.TabIndex = 76;
            this.label7.Text = "Tipos de Propiedad";
            // 
            // gdrTiposPropiedad
            // 
            this.gdrTiposPropiedad.AllowUserToAddRows = false;
            this.gdrTiposPropiedad.AllowUserToDeleteRows = false;
            this.gdrTiposPropiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrTiposPropiedad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TipoPropiedad,
            this.Descripcion});
            this.gdrTiposPropiedad.Location = new System.Drawing.Point(11, 91);
            this.gdrTiposPropiedad.Name = "gdrTiposPropiedad";
            this.gdrTiposPropiedad.ReadOnly = true;
            this.gdrTiposPropiedad.Size = new System.Drawing.Size(799, 235);
            this.gdrTiposPropiedad.TabIndex = 75;
            this.gdrTiposPropiedad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrTiposPropiedades_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(620, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 66);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(701, 349);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 66);
            this.btnSalir.TabIndex = 74;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarModificar
            // 
            this.btnAgregarModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarModificar.Image")));
            this.btnAgregarModificar.Location = new System.Drawing.Point(539, 349);
            this.btnAgregarModificar.Name = "btnAgregarModificar";
            this.btnAgregarModificar.Size = new System.Drawing.Size(75, 66);
            this.btnAgregarModificar.TabIndex = 71;
            this.btnAgregarModificar.UseVisualStyleBackColor = true;
            this.btnAgregarModificar.Click += new System.EventHandler(this.btnAgregarModificar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(499, 20);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(311, 62);
            this.txtDescripcion.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 81;
            this.label3.Text = "Descripcion";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_tipo_propiedad";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // TipoPropiedad
            // 
            this.TipoPropiedad.DataPropertyName = "n_tipo_propiedad";
            this.TipoPropiedad.HeaderText = "Tipo De Propiedad";
            this.TipoPropiedad.Name = "TipoPropiedad";
            this.TipoPropiedad.ReadOnly = true;
            this.TipoPropiedad.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 555;
            // 
            // frmABMTipoProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtTipoPropiedad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarModificar);
            this.Controls.Add(this.gdrTiposPropiedad);
            this.Name = "frmABMTipoProp";
            this.Text = "frmABMTipoProp";
            ((System.ComponentModel.ISupportInitialize)(this.gdrTiposPropiedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTipoPropiedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarModificar;
        private System.Windows.Forms.DataGridView gdrTiposPropiedad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}