﻿
namespace Inmobiliaria.Formularios
{
    partial class frmABMEdificios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMEdificios));
            this.btnEliminarEdificio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.txtNumeroCalle = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.chkAscensor = new System.Windows.Forms.CheckBox();
            this.txtCantidadDptos = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarEdificio
            // 
            this.btnEliminarEdificio.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEdificio.Image")));
            this.btnEliminarEdificio.Location = new System.Drawing.Point(191, 305);
            this.btnEliminarEdificio.Name = "btnEliminarEdificio";
            this.btnEliminarEdificio.Size = new System.Drawing.Size(75, 66);
            this.btnEliminarEdificio.TabIndex = 8;
            this.btnEliminarEdificio.UseVisualStyleBackColor = true;
            this.btnEliminarEdificio.Click += new System.EventHandler(this.btnEliminarEdificio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(272, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 66);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(216, 258);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(130, 21);
            this.cmbBarrio.TabIndex = 6;
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Location = new System.Drawing.Point(217, 231);
            this.txtNumeroCalle.Mask = "99999";
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(33, 20);
            this.txtNumeroCalle.TabIndex = 5;
            this.txtNumeroCalle.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 31);
            this.label7.TabIndex = 68;
            this.label7.Text = "Alta Edificios";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(29, 305);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 66);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(110, 305);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 66);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(216, 191);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(131, 20);
            this.txtCalle.TabIndex = 4;
            // 
            // chkAscensor
            // 
            this.chkAscensor.AutoSize = true;
            this.chkAscensor.Location = new System.Drawing.Point(217, 165);
            this.chkAscensor.Name = "chkAscensor";
            this.chkAscensor.Size = new System.Drawing.Size(15, 14);
            this.chkAscensor.TabIndex = 3;
            this.chkAscensor.UseVisualStyleBackColor = true;
            // 
            // txtCantidadDptos
            // 
            this.txtCantidadDptos.Location = new System.Drawing.Point(217, 129);
            this.txtCantidadDptos.Mask = "999";
            this.txtCantidadDptos.Name = "txtCantidadDptos";
            this.txtCantidadDptos.Size = new System.Drawing.Size(33, 20);
            this.txtCantidadDptos.TabIndex = 2;
            this.txtCantidadDptos.ValidatingType = typeof(int);
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Location = new System.Drawing.Point(217, 97);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(130, 20);
            this.txtNombreEdificio.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 61;
            this.label6.Text = "ID Barrio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "Numero de Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ascensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cantidad de Departamentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nombre del Edificio";
            // 
            // frmABMEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 392);
            this.Controls.Add(this.btnEliminarEdificio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.txtNumeroCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.chkAscensor);
            this.Controls.Add(this.txtCantidadDptos);
            this.Controls.Add(this.txtNombreEdificio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmABMEdificios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmABMEdificios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarEdificio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.MaskedTextBox txtNumeroCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.CheckBox chkAscensor;
        private System.Windows.Forms.MaskedTextBox txtCantidadDptos;
        private System.Windows.Forms.TextBox txtNombreEdificio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}