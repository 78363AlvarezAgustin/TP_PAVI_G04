
namespace Inmobiliaria.Formularios
{
    partial class frmAltaBarrio
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
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAltaBarrio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(131, 104);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(160, 21);
            this.cmbLocalidad.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(33, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 68;
            this.label12.Text = "Alta Barrio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 67;
            this.label4.Text = "Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_728918;
            this.button2.Location = new System.Drawing.Point(85, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 75);
            this.button2.TabIndex = 70;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAltaBarrio
            // 
            this.btnAltaBarrio.BackColor = System.Drawing.SystemColors.Control;
            this.btnAltaBarrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAltaBarrio.Image = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnAltaBarrio.Location = new System.Drawing.Point(203, 157);
            this.btnAltaBarrio.Name = "btnAltaBarrio";
            this.btnAltaBarrio.Size = new System.Drawing.Size(69, 75);
            this.btnAltaBarrio.TabIndex = 69;
            this.btnAltaBarrio.UseVisualStyleBackColor = false;
            this.btnAltaBarrio.Click += new System.EventHandler(this.btnAltaBarrio_Click);
            // 
            // frmAltaBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAltaBarrio);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmAltaBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmobiliaria";
            this.Load += new System.EventHandler(this.frmAltaBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAltaBarrio;
        public System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNombre;
    }
}