using Inmobiliaria.AccesoADatos;
using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class ABM_Dueños : Form
    {
        public ABM_Dueños()
        {
            InitializeComponent();
        }

        private void ABM_Dueños_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboDocumentos();
            CargarComboBarrios();
            CargarGrilla();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarDueño.Enabled = false;
        }

        private void btnActualizarDueño_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Dueño du = ObtenerDatosDueño();
                bool res = AD_Dueños.ActualizarDueño(du);
                if (res)
                {
                    MessageBox.Show("Dueño Actualizado con exito");
                    LimpiarCampos();
                    CargarComboBarrios();
                    CargarComboDocumentos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Dueño");
                }
            }
            btnActualizarDueño.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                Dueño du = ObtenerDatosDueño();
                bool res = AD_Dueños.AgregarDueñoBD(du);

                if(res)
                {
                    MessageBox.Show("Dueño Agregado Con Exito");
                    LimpiarCampos();
                    CargarComboBarrios();
                    CargarComboDocumentos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al Cargar Dueño");
                }
            }
            btnActualizarDueño.Enabled = false;

        }
        private void LimpiarCampos()
        {
            txtNumeroDocumento.Text = "";
            txtNombreDueño.Text = "";
            txtApellidoDueño.Text = "";
            txtCalle.Text = "";
            txtNumeroCalle.Text = "";

        }
        private void CargarGrilla()
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
        private bool ValidarCamposVacios()
        {
            if(txtNumeroDocumento.Text.Equals("") || cmbTipoDocumento.Text.Equals("") || txtNombreDueño.Text.Equals("") || txtApellidoDueño.Text.Equals("") || txtCalle.Text.Equals("") || txtNumeroCalle.Text.Equals("") || cmbBarrio.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos para continuar");
                return false;
            }
            else
                return true;
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

        private void gdrDueños_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizarDueño.Enabled = true;
            DataGridViewRow filaSeleccionda = gdrDueños.Rows[indice];

            string numeroDocumento = filaSeleccionda.Cells["NumeroDocumento"].Value.ToString();

            Dueño du = AD_Dueños.ObtenerDueño(int.Parse(numeroDocumento));


            LimpiarCampos();

            CargarCampos(du);
        }
    }
}
