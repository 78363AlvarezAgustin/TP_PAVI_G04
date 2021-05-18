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

namespace Inmobiliaria.Formularios
{
    public partial class frmFiltroDueños : Form
    {
        public frmFiltroDueños()
        {
            InitializeComponent();
            txtNroDocumentoDueño.Focus();
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

        private void gdrDueños_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrDueños.Rows[indice];

            string numeroDocumento = filaSeleccionda.Cells["NumeroDocumento"].Value.ToString();

            Dueños du = AD_Dueños.ObtenerDueño(int.Parse(numeroDocumento));


            frmABMDueños ventana = new frmABMDueños(du);

            ventana.ShowDialog();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkMostrarTodosDueños.Checked)
            {
                CargarGrilla();
            }
            else if (txtNroDocumentoDueño.Text.Equals(""))
            {
                MessageBox.Show("Selecciona algun filtro!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNroDocumentoDueño.Focus();
            }
            else
            {

                gdrDueños.DataSource = AD_Edificios.GetEdificioPorNombre(txtNroDocumentoDueño.Text);
                if (gdrDueños.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtNroDocumentoDueño.Text = "";
            chkMostrarTodosDueños.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarDueño_Click(object sender, EventArgs e)
        {
            Dueños du = new Dueños();
            frmABMDueños ventana = new frmABMDueños(du);
            ventana.ShowDialog();
        }
    }
}
