using Inmobiliaria.AccesoADatos;
using Inmobiliaria.AccesoADatos.Transacciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios.FrmTransacciones
{
    public partial class frmAltaDueñosXPropiedad : Form
    {
        public frmAltaDueñosXPropiedad()
        {
            InitializeComponent();
            CargarGrillaPropiedades();
            CargarComboDocumentos();
            CargarGrillaDueños();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarGrillaPropiedades()
        {
            try
            {
                gdrPropiedades.DataSource = AD_Propiedades.ObtenerPropiedades();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }

        private void CargarGrillaDueños()
        {
            try
            {
                gdrDueños.DataSource = AD_Dueños.ObtenerListadoDueños();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Obtener Dueños");
            }
        }

        private void CargarComboDocumentos()
        {

            try
            {

                cmbTipoDocumento.DataSource = AD_Dueños.ObtenerTabla("tipos_documentos");
                cmbTipoDocumento.DisplayMember = "n_tipo_documento";
                cmbTipoDocumento.ValueMember = "id_tipo_documento";
                cmbTipoDocumento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void LimpiarCampos()
        {
            txtDesignacionCatastral.Text = "";
            txtNroDocumento.Text = "";
            cmbTipoDocumento.SelectedItem = null;
        }

        private void gdrDueños_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrDueños.Rows[indice];

            txtNroDocumento.Text = filaSeleccionda.Cells["Ndoc"].Value.ToString();
            cmbTipoDocumento.SelectedIndex = (int)filaSeleccionda.Cells["tDoc"].Value;
            
        }

        private void grillaPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrPropiedades.Rows[indice];

            txtDesignacionCatastral.Text = filaSeleccionda.Cells["DesignacionCatastral"].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedItem == null || txtDesignacionCatastral.Text.Equals("") || txtNroDocumento.Text.Equals(""))
            {
                MessageBox.Show("Debe Cargar Todos los Campos");
            }
            else
            {
                gdrDueños_X_Propiedad.Rows.Add(txtDesignacionCatastral.Text, txtNroDocumento.Text, cmbTipoDocumento.Text);
                btnGuardar.Enabled= true;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            bool exs = ValidarRegistroPropiedad(int.Parse(txtDesignacionCatastral.Text));

            if (exs)
            {
                MessageBox.Show("La propiedad ya registra un Dueño");

            }
            else
            {
                bool res = AD_DueñoXPropiedad.AgregarDueñosXPropiedades(int.Parse(txtDesignacionCatastral.Text), int.Parse(txtNroDocumento.Text), cmbTipoDocumento.SelectedIndex);

                if (res)
                {
                    MessageBox.Show("Registro de Propiedades por Dueños con Exito");
                }
                else
                {
                    MessageBox.Show("Error al Registrar Propiedades por Dueños");
                }




            }
            gdrDueños_X_Propiedad.Rows.Clear();
            gdrDueños_X_Propiedad.Refresh();
            btnGuardar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la transacción?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool ValidarRegistroPropiedad(int desigCatastral)
        {
            DataTable a = AD_DueñoXPropiedad.ObtenerListadoDueñosxPropiedad(desigCatastral);
            if (a.Rows.Count > 0)
            {
                return true;
            }
            return false;

        }
    }
}
