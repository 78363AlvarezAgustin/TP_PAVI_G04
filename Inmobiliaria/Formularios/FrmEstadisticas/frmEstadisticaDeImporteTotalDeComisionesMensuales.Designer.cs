
namespace Inmobiliaria.Formularios.FrmEstadisticas
{
    partial class frmEstadisticaDeImporteTotalDeComisionesMensuales
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
            this.EstadisticaComisiones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EstadisticaComisiones
            // 
            this.EstadisticaComisiones.LocalReport.ReportEmbeddedResource = "Inmobiliaria.ComisionesTotalesMensuales.rdlc";
            this.EstadisticaComisiones.Location = new System.Drawing.Point(12, 157);
            this.EstadisticaComisiones.Name = "EstadisticaComisiones";
            this.EstadisticaComisiones.ServerReport.BearerToken = null;
            this.EstadisticaComisiones.Size = new System.Drawing.Size(983, 405);
            this.EstadisticaComisiones.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(571, 95);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(98, 30);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(386, 100);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(78, 20);
            this.txtAño.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comisiones Totales Mensuales";
            // 
            // frmEstadisticaDeImporteTotalDeComisionesMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 575);
            this.Controls.Add(this.EstadisticaComisiones);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadisticaDeImporteTotalDeComisionesMensuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística de Importe de Comisiones Mensuales";
            this.Load += new System.EventHandler(this.frmEstadisticaDeImporteTotalDeComisionesMensuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer EstadisticaComisiones;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}