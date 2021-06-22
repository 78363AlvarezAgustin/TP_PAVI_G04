
namespace Inmobiliaria.Formularios.FrmEstadisticas
{
    partial class frmEstadisticaGastosDeUnMesPorCadaProveedor
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rpGastosProv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(405, 49);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(98, 30);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(303, 54);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(78, 20);
            this.txtMes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gastos por Proveedor";
            // 
            // rpGastosProv
            // 
            this.rpGastosProv.LocalReport.ReportEmbeddedResource = "Inmobiliaria.EstadisticaProvGastos.rdlc";
            this.rpGastosProv.Location = new System.Drawing.Point(0, 116);
            this.rpGastosProv.Name = "rpGastosProv";
            this.rpGastosProv.ServerReport.BearerToken = null;
            this.rpGastosProv.Size = new System.Drawing.Size(680, 351);
            this.rpGastosProv.TabIndex = 12;
            // 
            // frmEstadisticaGastosDeUnMesPorCadaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 469);
            this.Controls.Add(this.rpGastosProv);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadisticaGastosDeUnMesPorCadaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica Gastos de un Mes por cada Proveedor";
            this.Load += new System.EventHandler(this.frmEstadisticaGastosDeUnMesPorCadaProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpGastosProv;
    }
}