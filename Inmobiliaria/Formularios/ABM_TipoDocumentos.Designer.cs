﻿
namespace Inmobiliaria
{
    partial class ABM_TipoDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_TipoDocumentos));
            this.gdrTiposDocumentos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarModificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrTiposDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gdrTiposDocumentos
            // 
            this.gdrTiposDocumentos.AllowUserToAddRows = false;
            this.gdrTiposDocumentos.AllowUserToDeleteRows = false;
            this.gdrTiposDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrTiposDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TipodeDocumento});
            this.gdrTiposDocumentos.Location = new System.Drawing.Point(12, 91);
            this.gdrTiposDocumentos.Name = "gdrTiposDocumentos";
            this.gdrTiposDocumentos.ReadOnly = true;
            this.gdrTiposDocumentos.Size = new System.Drawing.Size(377, 200);
            this.gdrTiposDocumentos.TabIndex = 15;
            this.gdrTiposDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrTiposDocumentos_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(281, 297);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 66);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarModificar
            // 
            this.btnAgregarModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarModificar.Image")));
            this.btnAgregarModificar.Location = new System.Drawing.Point(119, 297);
            this.btnAgregarModificar.Name = "btnAgregarModificar";
            this.btnAgregarModificar.Size = new System.Drawing.Size(75, 66);
            this.btnAgregarModificar.TabIndex = 51;
            this.btnAgregarModificar.UseVisualStyleBackColor = true;
            this.btnAgregarModificar.Click += new System.EventHandler(this.btnAgregarModificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(44, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 31);
            this.label7.TabIndex = 53;
            this.label7.Text = "Tipos de Documentos";
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(155, 65);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(130, 20);
            this.txtTipoDocumento.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tipo de Documento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(200, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 66);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(38, 297);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 66);
            this.btnLimpiarCampos.TabIndex = 57;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_tipo_documento";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // TipodeDocumento
            // 
            this.TipodeDocumento.DataPropertyName = "n_tipo_documento";
            this.TipodeDocumento.HeaderText = "Tipo De Documento";
            this.TipodeDocumento.Name = "TipodeDocumento";
            this.TipodeDocumento.ReadOnly = true;
            this.TipodeDocumento.Width = 300;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(334, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 20);
            this.txtID.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "ID";
            // 
            // ABM_TipoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarModificar);
            this.Controls.Add(this.gdrTiposDocumentos);
            this.Name = "ABM_TipoDocumentos";
            this.Text = "ABM_TipoDocumentos";
            this.Load += new System.EventHandler(this.ABM_TipoDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrTiposDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdrTiposDocumentos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeDocumento;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
    }
}