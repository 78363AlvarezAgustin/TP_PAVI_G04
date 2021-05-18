
namespace Inmobiliaria.Formularios
{
    partial class frmABMMediosPublic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMMediosPublic));
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtNombreMedioPublicitario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gdrMediosPublicitarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedioPublicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMediosPublicitarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(316, 64);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 20);
            this.txtID.TabIndex = 78;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(39, 331);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 66);
            this.btnLimpiarCampos.TabIndex = 73;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtNombreMedioPublicitario
            // 
            this.txtNombreMedioPublicitario.Location = new System.Drawing.Point(137, 64);
            this.txtNombreMedioPublicitario.Name = "txtNombreMedioPublicitario";
            this.txtNombreMedioPublicitario.Size = new System.Drawing.Size(130, 20);
            this.txtNombreMedioPublicitario.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(44, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 31);
            this.label7.TabIndex = 76;
            this.label7.Text = "Medios Publicitarios";
            // 
            // gdrMediosPublicitarios
            // 
            this.gdrMediosPublicitarios.AllowUserToAddRows = false;
            this.gdrMediosPublicitarios.AllowUserToDeleteRows = false;
            this.gdrMediosPublicitarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrMediosPublicitarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MedioPublicidad});
            this.gdrMediosPublicitarios.Location = new System.Drawing.Point(12, 90);
            this.gdrMediosPublicitarios.Name = "gdrMediosPublicitarios";
            this.gdrMediosPublicitarios.ReadOnly = true;
            this.gdrMediosPublicitarios.Size = new System.Drawing.Size(377, 219);
            this.gdrMediosPublicitarios.TabIndex = 75;
            this.gdrMediosPublicitarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrMedioPublicidad_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_medio_publicitario";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // MedioPublicidad
            // 
            this.MedioPublicidad.DataPropertyName = "n_medio_publicitario";
            this.MedioPublicidad.HeaderText = "Medio Publicitario";
            this.MedioPublicidad.Name = "MedioPublicidad";
            this.MedioPublicidad.ReadOnly = true;
            this.MedioPublicidad.Width = 300;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(201, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 66);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(282, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 66);
            this.btnSalir.TabIndex = 74;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarModificar
            // 
            this.btnAgregarModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarModificar.Image")));
            this.btnAgregarModificar.Location = new System.Drawing.Point(120, 331);
            this.btnAgregarModificar.Name = "btnAgregarModificar";
            this.btnAgregarModificar.Size = new System.Drawing.Size(75, 66);
            this.btnAgregarModificar.TabIndex = 71;
            this.btnAgregarModificar.UseVisualStyleBackColor = true;
            this.btnAgregarModificar.Click += new System.EventHandler(this.btnAgregarModificar_Click);
            // 
            // frmABMMediosPublic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombreMedioPublicitario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarModificar);
            this.Controls.Add(this.gdrMediosPublicitarios);
            this.Name = "frmABMMediosPublic";
            this.Text = "frmABMMediosPublic";
            ((System.ComponentModel.ISupportInitialize)(this.gdrMediosPublicitarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombreMedioPublicitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarModificar;
        private System.Windows.Forms.DataGridView gdrMediosPublicitarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedioPublicidad;
    }
}