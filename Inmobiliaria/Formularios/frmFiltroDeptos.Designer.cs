
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroDeptos
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
            this.btnSalirDepto = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grillaDeptos = new System.Windows.Forms.DataGridView();
            this.IdDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarDeptos = new System.Windows.Forms.Button();
            this.chkTodosDeptos = new System.Windows.Forms.CheckBox();
            this.txtIdProvincia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarDepto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeptos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirDepto
            // 
            this.btnSalirDepto.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_2_27391185;
            this.btnSalirDepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalirDepto.Location = new System.Drawing.Point(405, 401);
            this.btnSalirDepto.Name = "btnSalirDepto";
            this.btnSalirDepto.Size = new System.Drawing.Size(65, 65);
            this.btnSalirDepto.TabIndex = 8;
            this.btnSalirDepto.UseVisualStyleBackColor = true;
            this.btnSalirDepto.Click += new System.EventHandler(this.btnSalirDepto_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(37, 416);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(82, 50);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // grillaDeptos
            // 
            this.grillaDeptos.AllowUserToAddRows = false;
            this.grillaDeptos.AllowUserToDeleteRows = false;
            this.grillaDeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDeptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDepto,
            this.Departamento,
            this.IdProvincia});
            this.grillaDeptos.Location = new System.Drawing.Point(36, 181);
            this.grillaDeptos.Name = "grillaDeptos";
            this.grillaDeptos.ReadOnly = true;
            this.grillaDeptos.Size = new System.Drawing.Size(434, 187);
            this.grillaDeptos.TabIndex = 5;
            this.grillaDeptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDeptos_CellClick);
            // 
            // IdDepto
            // 
            this.IdDepto.DataPropertyName = "id_departamento";
            this.IdDepto.HeaderText = "Id Departamento";
            this.IdDepto.Name = "IdDepto";
            this.IdDepto.ReadOnly = true;
            this.IdDepto.Width = 110;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "n_departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 180;
            // 
            // IdProvincia
            // 
            this.IdProvincia.DataPropertyName = "id_provincia";
            this.IdProvincia.HeaderText = "Id Provincia";
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            // 
            // btnBuscarDeptos
            // 
            this.btnBuscarDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDeptos.Location = new System.Drawing.Point(388, 87);
            this.btnBuscarDeptos.Name = "btnBuscarDeptos";
            this.btnBuscarDeptos.Size = new System.Drawing.Size(82, 28);
            this.btnBuscarDeptos.TabIndex = 4;
            this.btnBuscarDeptos.Text = "Buscar";
            this.btnBuscarDeptos.UseVisualStyleBackColor = true;
            this.btnBuscarDeptos.Click += new System.EventHandler(this.btnBuscarDeptos_Click);
            // 
            // chkTodosDeptos
            // 
            this.chkTodosDeptos.AutoSize = true;
            this.chkTodosDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodosDeptos.Location = new System.Drawing.Point(36, 131);
            this.chkTodosDeptos.Name = "chkTodosDeptos";
            this.chkTodosDeptos.Size = new System.Drawing.Size(262, 24);
            this.chkTodosDeptos.TabIndex = 3;
            this.chkTodosDeptos.Text = "Mostrar todos los departamentos";
            this.chkTodosDeptos.UseVisualStyleBackColor = true;
            this.chkTodosDeptos.CheckedChanged += new System.EventHandler(this.chkTodosDeptos_CheckedChanged);
            // 
            // txtIdProvincia
            // 
            this.txtIdProvincia.Location = new System.Drawing.Point(144, 87);
            this.txtIdProvincia.Name = "txtIdProvincia";
            this.txtIdProvincia.Size = new System.Drawing.Size(66, 20);
            this.txtIdProvincia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nro Provincia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamentos Geográficos";
            // 
            // btnAgregarDepto
            // 
            this.btnAgregarDepto.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__323787;
            this.btnAgregarDepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarDepto.Location = new System.Drawing.Point(308, 401);
            this.btnAgregarDepto.Name = "btnAgregarDepto";
            this.btnAgregarDepto.Size = new System.Drawing.Size(65, 65);
            this.btnAgregarDepto.TabIndex = 7;
            this.btnAgregarDepto.UseVisualStyleBackColor = true;
            this.btnAgregarDepto.Click += new System.EventHandler(this.btnAgregarDepto_Click);
            // 
            // frmFiltroDeptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 492);
            this.Controls.Add(this.btnSalirDepto);
            this.Controls.Add(this.btnAgregarDepto);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.grillaDeptos);
            this.Controls.Add(this.btnBuscarDeptos);
            this.Controls.Add(this.chkTodosDeptos);
            this.Controls.Add(this.txtIdProvincia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFiltroDeptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Deptos";
            this.Load += new System.EventHandler(this.frmFiltroDeptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirDepto;
        private System.Windows.Forms.Button btnAgregarDepto;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grillaDeptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
        private System.Windows.Forms.Button btnBuscarDeptos;
        private System.Windows.Forms.CheckBox chkTodosDeptos;
        private System.Windows.Forms.TextBox txtIdProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}