﻿
namespace Inmobiliaria.formularios
{
    partial class frm_ABM_empleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrarPorLegajo = new System.Windows.Forms.TextBox();
            this.gdrEmpleados = new System.Windows.Forms.DataGridView();
            this.LegajoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo:";
            // 
            // txtFiltrarPorLegajo
            // 
            this.txtFiltrarPorLegajo.Location = new System.Drawing.Point(88, 47);
            this.txtFiltrarPorLegajo.Name = "txtFiltrarPorLegajo";
            this.txtFiltrarPorLegajo.Size = new System.Drawing.Size(136, 26);
            this.txtFiltrarPorLegajo.TabIndex = 2;
            // 
            // gdrEmpleados
            // 
            this.gdrEmpleados.AllowUserToAddRows = false;
            this.gdrEmpleados.AllowUserToDeleteRows = false;
            this.gdrEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LegajoEmpleado,
            this.NombreEmpleado,
            this.ApellidoEmpleado,
            this.NombreUsuario,
            this.Password});
            this.gdrEmpleados.Location = new System.Drawing.Point(5, 105);
            this.gdrEmpleados.Name = "gdrEmpleados";
            this.gdrEmpleados.ReadOnly = true;
            this.gdrEmpleados.Size = new System.Drawing.Size(656, 282);
            this.gdrEmpleados.TabIndex = 1;
            this.gdrEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEmpleados_CellClick);
            // 
            // LegajoEmpleado
            // 
            this.LegajoEmpleado.DataPropertyName = "legajo";
            this.LegajoEmpleado.HeaderText = "Legajo";
            this.LegajoEmpleado.Name = "LegajoEmpleado";
            this.LegajoEmpleado.ReadOnly = true;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.DataPropertyName = "n_empleado";
            this.NombreEmpleado.HeaderText = "Nombre";
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.ReadOnly = true;
            this.NombreEmpleado.Width = 130;
            // 
            // ApellidoEmpleado
            // 
            this.ApellidoEmpleado.DataPropertyName = "apellido_empleado";
            this.ApellidoEmpleado.HeaderText = "Apellido";
            this.ApellidoEmpleado.Name = "ApellidoEmpleado";
            this.ApellidoEmpleado.ReadOnly = true;
            this.ApellidoEmpleado.Width = 150;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DataPropertyName = "n_usuario";
            this.NombreUsuario.HeaderText = "Usuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 120;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "contraseña";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Seleccione un Empleado de la tabla para modificar o eliminar*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gdrEmpleados);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltrarPorLegajo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro empleados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_eccomerce___search_3440910;
            this.btnBuscar.Location = new System.Drawing.Point(229, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 43);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_reload_46828;
            this.btnActualizar.Location = new System.Drawing.Point(136, 440);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 75);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.Control;
            this.btnInicio.Image = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.btnInicio.Location = new System.Drawing.Point(593, 440);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(81, 75);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::Inmobiliaria.Properties.Resources.iconfinder_add1__323781;
            this.button4.Location = new System.Drawing.Point(29, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 75);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_ABM_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 517);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ABM_empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ABM_empleados";
            this.Load += new System.EventHandler(this.frm_ABM_empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrarPorLegajo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gdrEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}