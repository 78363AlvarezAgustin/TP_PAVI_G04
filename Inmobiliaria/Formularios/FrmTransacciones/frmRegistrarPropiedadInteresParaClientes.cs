using Inmobiliaria.AccesoADatos;
using Inmobiliaria.AccesoADatos.Transacciones;
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

namespace Inmobiliaria.Formularios.FrmTransacciones
{
    public partial class frmRegistrarPropiedadInteresParaClientes : Form
    {
        public frmRegistrarPropiedadInteresParaClientes()
        {
            InitializeComponent();
            CargarGrillaPropiedades();
            CargarComboDocumentos();
            CargarGrillaClientes();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDesignacionCatastral.Text = "";
            txtNroDocumento.Text = "";
            cmbTipoDocumento.SelectedItem = null;
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

        private void CargarGrillaClientes()
        {
            try
            {
                gdrClientes.DataSource = AD_Clientes.ObtenerClientes();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Obtener Clientes");
                throw;
            }
        }

        private void CargarComboDocumentos()
        {
            try
            {

                cmbTipoDocumento.DataSource = AD_Clientes.ObtenerTabla("tipos_documentos"); //lo naranja es a que tabla tengo que ir a buscar los datos tipo doc
                cmbTipoDocumento.DisplayMember = "n_tipo_documento"; //lo que quiero mostrar de la bd
                cmbTipoDocumento.ValueMember = "id_tipo_documento"; //lo que quiero guardar en otro lado
                cmbTipoDocumento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedItem == null || txtDesignacionCatastral.Text.Equals("") || txtNroDocumento.Text.Equals(""))
            {
                MessageBox.Show("Debe Cargar Todos los Campos");
            }
            else
            {
                gdrClientes_X_Propiedad.Rows.Add(txtDesignacionCatastral.Text, txtNroDocumento.Text, cmbTipoDocumento.Text);
                btnGuardar.Enabled = true;

            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool res = AD_PropiedadInteresClientes.AgregarClientesXPropiedades(int.Parse(txtNroDocumento.Text), cmbTipoDocumento.SelectedIndex, int.Parse(txtDesignacionCatastral.Text));

            if (res)
            {
                MessageBox.Show("Registro de Propiedades de interes para Clientes realizado con Exito");
            }
            else
            {
                MessageBox.Show("Error al Registrar Propiedades de interes para Clientes");
            }

            gdrClientes_X_Propiedad.Rows.Clear();
            gdrClientes_X_Propiedad.Refresh();
            btnGuardar.Enabled = false;

        }

        
        private void gdrClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = gdrClientes.Rows[indice];
                txtNroDocumento.Text = filaSeleccionada.Cells["Ndoc"].Value.ToString();
                cmbTipoDocumento.SelectedIndex = (int)filaSeleccionada.Cells["tDoc"].Value; 

            }

            catch (Exception)
            {
                MessageBox.Show("Algo ha salido mal, por favor seleccione una fila");
            }

        }

        private void gdrPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrPropiedades.Rows[indice];
            txtDesignacionCatastral.Text = filaSeleccionda.Cells["DesignacionCatastral"].Value.ToString();
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la transacción?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
