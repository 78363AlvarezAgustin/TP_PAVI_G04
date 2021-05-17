using Inmobiliaria.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Entidades;

namespace Inmobiliaria
{
    public partial class frm_Alta_Dueño : Form
    {
        public frm_Alta_Dueño(Dueño du)
        {
            InitializeComponent();
            CargarComboBarrios();
            CargarComboDocumentos();
            LimpiarCampos();
            if (du == null)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                CargarCampos(du);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existe = AD_Dueños.ExisteDueño(int.Parse(txtNumeroDocumento.Text));

            if (existe)
            {
                Dueño du = ObtenerDatosDueño();
                bool res = AD_Dueños.ActualizarDueño(du);
                txtNumeroDocumento.Focus();
            }
            else
            {
                if (txtNumeroDocumento.Equals("") || txtNombreDueño.Text.Equals("") || cmbBarrio.Text.Equals("") || txtApellidoDueño.Text.Equals("") || txtNumeroCalle.Text.Equals("") || cmbTipoDocumento.Text.Equals(""))
                {
                    DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumeroDocumento.Focus();
                }
                else
                {
                    Dueño du = ObtenerDatosDueño();
                    bool res = AD_Dueños.AgregarDueñoBD(du);

                    if (res)
                    {
                        MessageBox.Show("Dueño agredado correctamente!", "Informacion");
                        LimpiarCampos();
                        CargarComboBarrios();
                        CargarComboDocumentos();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el Dueño!");
                    }
                }
            }

        }



        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNumeroDocumento.Text = "";
            txtNombreDueño.Text = "";
            txtApellidoDueño.Text = "";
            txtCalle.Text = "";
            txtNumeroCalle.Text = "";
            cmbBarrio.SelectedItem = null;
            cmbTipoDocumento.SelectedItem = null;

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
        private void CargarComboBarrios()
        {

            try
            {

                cmbBarrio.DataSource = AD_Dueños.ObtenerTabla("barrios");
                cmbBarrio.DisplayMember = "n_barrio";
                cmbBarrio.ValueMember = "id_barrio";
                cmbBarrio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private Dueño ObtenerDatosDueño()
        {
            Dueño du = new Dueño();

            du.NumeroDocumentoDueño = int.Parse(txtNumeroDocumento.Text.Trim());
            du.TipoDocumentoDueño = (int)cmbTipoDocumento.SelectedValue;
            du.NombreDueño = txtNombreDueño.Text.Trim();
            du.ApellidoDueño = txtApellidoDueño.Text.Trim();
            du.CalleDueño = txtCalle.Text.Trim();
            du.NumeroCalleDueño = int.Parse(txtNumeroCalle.Text);
            du.IdBarrioDueño = (int)cmbBarrio.SelectedValue;



            return du;
        }
        private void CargarCampos(Dueño du)
        {
            txtNumeroDocumento.Text = du.NumeroDocumentoDueño.ToString();

            cmbTipoDocumento.SelectedValue = du.TipoDocumentoDueño;
            txtNombreDueño.Text = du.NombreDueño;
            txtApellidoDueño.Text = du.ApellidoDueño;
            txtCalle.Text = du.CalleDueño;
            txtNumeroCalle.Text = du.NumeroCalleDueño.ToString();

            cmbBarrio.SelectedValue = du.IdBarrioDueño;



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el dueño seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Dueño du = ObtenerDatosDueño();
                bool resultado = AD_Dueños.EliminarDueño(du);
                if (resultado)
                {
                    MessageBox.Show("Dueño eliminado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Dueño!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
        }
    }
}
