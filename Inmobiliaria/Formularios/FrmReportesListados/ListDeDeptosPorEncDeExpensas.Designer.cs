
namespace Inmobiliaria.Formularios.FrmReportesListados
{
    partial class ListDeDeptosPorEncDeExpensas
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
            this.RVExpensas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RVExpensas
            // 
            this.RVExpensas.LocalReport.ReportEmbeddedResource = "Inmobiliaria.ReporteDptosXExpensas.rdlc";
            this.RVExpensas.Location = new System.Drawing.Point(12, 97);
            this.RVExpensas.Name = "RVExpensas";
            this.RVExpensas.ServerReport.BearerToken = null;
            this.RVExpensas.Size = new System.Drawing.Size(776, 407);
            this.RVExpensas.TabIndex = 0;
            this.RVExpensas.Load += new System.EventHandler(this.RVExpensas_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Buscar Departamentos por Encargado de Expensas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(263, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(140, 55);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(117, 20);
            this.txtLegajo.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ingrese Legajo:";
            // 
            // ListDeDeptosPorEncDeExpensas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.RVExpensas);
            this.Name = "ListDeDeptosPorEncDeExpensas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Deptos por Enc de Expensas";
            this.Load += new System.EventHandler(this.ListDeDeptosPorEncDeExpensas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVExpensas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label2;
    }
}