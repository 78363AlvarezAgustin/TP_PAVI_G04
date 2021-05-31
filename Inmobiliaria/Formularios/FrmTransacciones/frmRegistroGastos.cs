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
    public partial class frmRegistroGastos : Form
    {
        public frmRegistroGastos()
        {
            InitializeComponent();
        }

        private void frmRegistroGastos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrillaProveedores();
            CargarGrillaEdificios();
            CargarGrillaGastos();
            txtNroComprobante.Focus();
        }
        private void CargarGrillaGastos()
        {
            try
            {
                grillaGastos.DataSource = AD_Gastos.ObtenerGastos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla de gastos!");
                throw;
            }
        }
        private Gastos ObtenerDatosGastos()
        {
            Gastos g = new Gastos();

            g.IdProveedor = int.Parse(txtIdProveedor.Text);           
            g.NroComprobanteGasto = int.Parse(txtNroComprobante.Text);
            g.FechaGasto = DateTime.Parse(txtFecha.Text);
            g.ImporteGasto = int.Parse(txtImporte.Text);
            g.ConceptoGasto = txtConcepto.Text;
            g.IdEdificio = int.Parse(txtIdEdificio.Text);

            return g;
        }      

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNroComprobante.Focus();
        }
        private void LimpiarCampos()
        {
            txtIdProveedor.Text = "";
            txtNroComprobante.Text = "";
            txtFecha.Text = "";
            txtImporte.Text = "";
            txtConcepto.Text = "";
            txtIdEdificio.Text = "";
        }

        private void btnGuardarGasto_Click(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text.Equals("") || txtNroComprobante.Text.Equals("") || txtFecha.Text.Equals("") || txtImporte.Text.Equals("") || txtConcepto.Text.Equals("") || txtIdEdificio.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Complete todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Gastos g = ObtenerDatosGastos();
                bool resultado = AD_Gastos.AgregarGasto(g);

                if (resultado)
                {
                    MessageBox.Show("Gasto agregado correctamente!", "Informacion");
                    LimpiarCampos();                  
                    CargarGrillaProveedores();
                    CargarGrillaEdificios();
                    CargarGrillaGastos();
                    txtNroComprobante.Focus();
                }
                else
                {
                    MessageBox.Show("Error al cargar el gasto!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la transacción?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void CargarGrillaProveedores()
        {
            try
            {
                grillaProveedores.DataSource = AD_Proveedores.ObtenerProveedores();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }
        private void CargarGrillaEdificios()
        {
            try
            {
                grillaEdificios.DataSource = AD_Edificios.ObtenerListadoEdificios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }
        private void grillaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaProveedores.Rows[indice];

            int IdProv = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
            txtIdProveedor.Text = IdProv.ToString();

            string concepto = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            txtConcepto.Text = concepto.ToString();
        }

        private void grillaEdificios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaEdificios.Rows[indice];

            int IdEdif = int.Parse(filaSeleccionada.Cells["id_edificio"].Value.ToString());
            txtIdEdificio.Text = IdEdif.ToString();
        }

        private void lblGastos2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
