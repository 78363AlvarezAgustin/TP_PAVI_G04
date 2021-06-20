
namespace Inmobiliaria.Formularios.FrmReportesListados
{
    partial class RepDePublicidadesEnRangoDeFechas
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
            this.components = new System.ComponentModel.Container();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarXFecha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bD3K7G04_2021DataSet = new Inmobiliaria.BD3K7G04_2021DataSet();
            this.bD3K7G042021DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G04_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G042021DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(334, 132);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(94, 24);
            this.txtHasta.TabIndex = 2;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(334, 92);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(94, 24);
            this.txtDesde.TabIndex = 1;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta: ";
            // 
            // btnBuscarXFecha
            // 
            this.btnBuscarXFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarXFecha.Location = new System.Drawing.Point(469, 94);
            this.btnBuscarXFecha.Name = "btnBuscarXFecha";
            this.btnBuscarXFecha.Size = new System.Drawing.Size(119, 62);
            this.btnBuscarXFecha.TabIndex = 3;
            this.btnBuscarXFecha.Text = "Generar Reporte";
            this.btnBuscarXFecha.UseVisualStyleBackColor = true;
            this.btnBuscarXFecha.Click += new System.EventHandler(this.btnBuscarXFecha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Publicidades por Fecha";
            // 
            // bD3K7G04_2021DataSet
            // 
            this.bD3K7G04_2021DataSet.DataSetName = "BD3K7G04_2021DataSet";
            this.bD3K7G04_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bD3K7G042021DataSetBindingSource
            // 
            this.bD3K7G042021DataSetBindingSource.DataSource = this.bD3K7G04_2021DataSet;
            this.bD3K7G042021DataSetBindingSource.Position = 0;
            // 
            // publicidadesBindingSource
            // 
            this.publicidadesBindingSource.DataMember = "publicidades";
            this.publicidadesBindingSource.DataSource = this.bD3K7G04_2021DataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 183);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(721, 473);
            this.reportViewer1.TabIndex = 9;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(614, 94);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(119, 62);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seleccione un rango de fechas";
            // 
            // RepDePublicidadesEnRangoDeFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 678);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarXFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtHasta);
            this.Name = "RepDePublicidadesEnRangoDeFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepDePublicidadesEnRangoDeFechas";
            this.Load += new System.EventHandler(this.RepDePublicidadesEnRangoDeFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G04_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G042021DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarXFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bD3K7G042021DataSetBindingSource;
        private BD3K7G04_2021DataSet bD3K7G04_2021DataSet;
        private System.Windows.Forms.BindingSource publicidadesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label label4;
    }
}