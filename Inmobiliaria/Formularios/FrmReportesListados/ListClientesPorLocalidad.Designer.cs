
namespace Inmobiliaria.Formularios.FrmReportesListados
{
    partial class ListClientesPorLocalidad
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
            this.btnFiltrarDni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrarDes = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inmobiliaria.ReporteClientesPorLocalidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 345);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnFiltrarDni
            // 
            this.btnFiltrarDni.Location = new System.Drawing.Point(157, 23);
            this.btnFiltrarDni.Name = "btnFiltrarDni";
            this.btnFiltrarDni.Size = new System.Drawing.Size(75, 41);
            this.btnFiltrarDni.TabIndex = 1;
            this.btnFiltrarDni.Text = "Filtrar";
            this.btnFiltrarDni.UseVisualStyleBackColor = true;
            this.btnFiltrarDni.Click += new System.EventHandler(this.btnFiltrarDni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI: ";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(51, 30);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 3;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(393, 31);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 20);
            this.txtDes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designacion Catrastal:";
            // 
            // btnFiltrarDes
            // 
            this.btnFiltrarDes.Location = new System.Drawing.Point(499, 21);
            this.btnFiltrarDes.Name = "btnFiltrarDes";
            this.btnFiltrarDes.Size = new System.Drawing.Size(75, 43);
            this.btnFiltrarDes.TabIndex = 4;
            this.btnFiltrarDes.Text = "Filtrar";
            this.btnFiltrarDes.UseVisualStyleBackColor = true;
            this.btnFiltrarDes.Click += new System.EventHandler(this.btnFiltrarDes_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(629, 14);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 56);
            this.btnLimpiarFiltros.TabIndex = 7;
            this.btnLimpiarFiltros.Text = "LIMPIAR FILTROS";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // ListClientesPorLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltrarDes);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrarDni);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListClientesPorLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListClientesPorLocalidad";
            this.Load += new System.EventHandler(this.ListClientesPorLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnFiltrarDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrarDes;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}