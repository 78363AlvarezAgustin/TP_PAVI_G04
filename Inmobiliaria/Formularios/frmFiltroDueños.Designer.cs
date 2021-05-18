
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroDueños
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroDueños));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkMostrarTodosDueños = new System.Windows.Forms.CheckBox();
            this.txtNroDocumentoDueño = new System.Windows.Forms.TextBox();
            this.lblNombreDueño = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gdrDueños = new System.Windows.Forms.DataGridView();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarDueño = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrDueños)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(419, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkMostrarTodosDueños
            // 
            this.chkMostrarTodosDueños.AutoSize = true;
            this.chkMostrarTodosDueños.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarTodosDueños.Location = new System.Drawing.Point(153, 124);
            this.chkMostrarTodosDueños.Name = "chkMostrarTodosDueños";
            this.chkMostrarTodosDueños.Size = new System.Drawing.Size(222, 22);
            this.chkMostrarTodosDueños.TabIndex = 2;
            this.chkMostrarTodosDueños.Text = "Mostrar todos los dueños";
            this.chkMostrarTodosDueños.UseVisualStyleBackColor = true;
            // 
            // txtNroDocumentoDueño
            // 
            this.txtNroDocumentoDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocumentoDueño.Location = new System.Drawing.Point(153, 94);
            this.txtNroDocumentoDueño.Name = "txtNroDocumentoDueño";
            this.txtNroDocumentoDueño.Size = new System.Drawing.Size(233, 24);
            this.txtNroDocumentoDueño.TabIndex = 1;
            // 
            // lblNombreDueño
            // 
            this.lblNombreDueño.AutoSize = true;
            this.lblNombreDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDueño.Location = new System.Drawing.Point(18, 94);
            this.lblNombreDueño.Name = "lblNombreDueño";
            this.lblNombreDueño.Size = new System.Drawing.Size(122, 18);
            this.lblNombreDueño.TabIndex = 55;
            this.lblNombreDueño.Text = "Nombre Dueño";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 54;
            this.label1.Text = "Dueños";
            // 
            // gdrDueños
            // 
            this.gdrDueños.AllowUserToAddRows = false;
            this.gdrDueños.AllowUserToDeleteRows = false;
            this.gdrDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrDueños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDocumento,
            this.TipoDocumento,
            this.NombreDueño,
            this.ApellidoDueño,
            this.Calle,
            this.NumeroCalle,
            this.IdBarrio});
            this.gdrDueños.Location = new System.Drawing.Point(21, 152);
            this.gdrDueños.Name = "gdrDueños";
            this.gdrDueños.ReadOnly = true;
            this.gdrDueños.Size = new System.Drawing.Size(573, 291);
            this.gdrDueños.TabIndex = 53;
            this.gdrDueños.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrDueños_CellClick);
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "nro_documento";
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 70;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "tipo_documento";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 70;
            // 
            // NombreDueño
            // 
            this.NombreDueño.DataPropertyName = "n_dueño";
            this.NombreDueño.HeaderText = "Nombre";
            this.NombreDueño.Name = "NombreDueño";
            this.NombreDueño.ReadOnly = true;
            this.NombreDueño.Width = 85;
            // 
            // ApellidoDueño
            // 
            this.ApellidoDueño.DataPropertyName = "apellido_dueño";
            this.ApellidoDueño.HeaderText = "Apellido";
            this.ApellidoDueño.Name = "ApellidoDueño";
            this.ApellidoDueño.ReadOnly = true;
            this.ApellidoDueño.Width = 85;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 85;
            // 
            // NumeroCalle
            // 
            this.NumeroCalle.DataPropertyName = "nro_calle";
            this.NumeroCalle.HeaderText = "Numero Calle";
            this.NumeroCalle.Name = "NumeroCalle";
            this.NumeroCalle.ReadOnly = true;
            this.NumeroCalle.Width = 60;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "id_barrio";
            this.IdBarrio.HeaderText = "IdBarrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            this.IdBarrio.Width = 60;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(311, 458);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 60);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarDueño
            // 
            this.btnAgregarDueño.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDueño.Image")));
            this.btnAgregarDueño.Location = new System.Drawing.Point(230, 458);
            this.btnAgregarDueño.Name = "btnAgregarDueño";
            this.btnAgregarDueño.Size = new System.Drawing.Size(75, 60);
            this.btnAgregarDueño.TabIndex = 4;
            this.btnAgregarDueño.UseVisualStyleBackColor = true;
            this.btnAgregarDueño.Click += new System.EventHandler(this.btnAgregarDueño_Click);
            // 
            // frmFiltroDueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 546);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarDueño);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkMostrarTodosDueños);
            this.Controls.Add(this.txtNroDocumentoDueño);
            this.Controls.Add(this.lblNombreDueño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdrDueños);
            this.Name = "frmFiltroDueños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFiltroDueños";
            ((System.ComponentModel.ISupportInitialize)(this.gdrDueños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarDueño;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkMostrarTodosDueños;
        private System.Windows.Forms.TextBox txtNroDocumentoDueño;
        private System.Windows.Forms.Label lblNombreDueño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdrDueños;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
    }
}