
namespace Inmobiliaria.Formularios.FrmReportesListados
{
    partial class ListDeDueñosPorLocalidad
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
            this.gdrLocalidades = new System.Windows.Forms.DataGridView();
            this.IdLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomLoc = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(17, 366);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(727, 342);
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
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dueños por Localidad";
            // 
            // gdrLocalidades
            // 
            this.gdrLocalidades.AllowUserToAddRows = false;
            this.gdrLocalidades.AllowUserToDeleteRows = false;
            this.gdrLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLocal,
            this.Nombre,
            this.IdDepartamento});
            this.gdrLocalidades.Location = new System.Drawing.Point(17, 92);
            this.gdrLocalidades.Name = "gdrLocalidades";
            this.gdrLocalidades.ReadOnly = true;
            this.gdrLocalidades.Size = new System.Drawing.Size(437, 256);
            this.gdrLocalidades.TabIndex = 8;
            this.gdrLocalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrLocalidades_CellClick);
            // 
            // IdLocal
            // 
            this.IdLocal.DataPropertyName = "id_localidad";
            this.IdLocal.HeaderText = "ID";
            this.IdLocal.Name = "IdLocal";
            this.IdLocal.ReadOnly = true;
            this.IdLocal.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "n_localidad";
            this.Nombre.HeaderText = "Nombre Localidad";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 195;
            // 
            // IdDepartamento
            // 
            this.IdDepartamento.DataPropertyName = "n_departamento";
            this.IdDepartamento.HeaderText = "Departamento";
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.ReadOnly = true;
            this.IdDepartamento.Width = 195;
            // 
            // btnReporte
            // 
            this.btnReporte.Enabled = false;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(573, 264);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 60);
            this.btnReporte.TabIndex = 9;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(594, 145);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtNomLoc
            // 
            this.txtNomLoc.Enabled = false;
            this.txtNomLoc.Location = new System.Drawing.Point(594, 180);
            this.txtNomLoc.Name = "txtNomLoc";
            this.txtNomLoc.Size = new System.Drawing.Size(100, 20);
            this.txtNomLoc.TabIndex = 11;
            // 
            // txtDep
            // 
            this.txtDep.Enabled = false;
            this.txtDep.Location = new System.Drawing.Point(594, 216);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(100, 20);
            this.txtDep.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Localidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seleccione una Localidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Localidad seleccionada";
            // 
            // ListDeDueñosPorLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 765);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.txtNomLoc);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.gdrLocalidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListDeDueñosPorLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListDeDueñosPorLocalidad";
            this.Load += new System.EventHandler(this.ListDeDueñosPorLocalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gdrLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDepartamento;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomLoc;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}