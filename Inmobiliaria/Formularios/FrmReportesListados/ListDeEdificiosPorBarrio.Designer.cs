
namespace Inmobiliaria.Formularios.FrmReportesListados
{
    partial class ListDeEdificiosPorBarrio
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
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.btnFiltrarDes = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.btnFiltrarDni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inmobiliaria.ListDeEdificiosPorBarrio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 364);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(645, 14);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 56);
            this.btnLimpiarFiltros.TabIndex = 14;
            this.btnLimpiarFiltros.Text = "LIMPIAR FILTROS";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(409, 31);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(100, 20);
            this.txtBarrio.TabIndex = 13;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(344, 35);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(59, 13);
            this.lblBarrio.TabIndex = 12;
            this.lblBarrio.Text = "Id Barrio:";
            // 
            // btnFiltrarDes
            // 
            this.btnFiltrarDes.Location = new System.Drawing.Point(515, 21);
            this.btnFiltrarDes.Name = "btnFiltrarDes";
            this.btnFiltrarDes.Size = new System.Drawing.Size(75, 43);
            this.btnFiltrarDes.TabIndex = 11;
            this.btnFiltrarDes.Text = "Filtrar";
            this.btnFiltrarDes.UseVisualStyleBackColor = true;
            this.btnFiltrarDes.Click += new System.EventHandler(this.btnFiltrarDes_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdificio.Location = new System.Drawing.Point(29, 34);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(96, 13);
            this.lblEdificio.TabIndex = 9;
            this.lblEdificio.Text = "Nombre Edificio";
            // 
            // btnFiltrarDni
            // 
            this.btnFiltrarDni.Location = new System.Drawing.Point(237, 20);
            this.btnFiltrarDni.Name = "btnFiltrarDni";
            this.btnFiltrarDni.Size = new System.Drawing.Size(75, 41);
            this.btnFiltrarDni.TabIndex = 8;
            this.btnFiltrarDni.Text = "Filtrar";
            this.btnFiltrarDni.UseVisualStyleBackColor = true;
            this.btnFiltrarDni.Click += new System.EventHandler(this.btnFiltrarDni_Click);
            // 
            // ListDeEdificiosPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.btnFiltrarDes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdificio);
            this.Controls.Add(this.btnFiltrarDni);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListDeEdificiosPorBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Edificios por Barrio";
            this.Load += new System.EventHandler(this.ListDeEdificiosPorBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Button btnFiltrarDes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.Button btnFiltrarDni;
    }
}