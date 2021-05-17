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

            Dueño du = AD_Dueños.ObtenerDueño(int.Parse(numeroDocumento));


            frm_Alta_Dueño ventana = new frm_Alta_Dueño(du);

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
            Dueño du = new Dueño();
            frm_Alta_Dueño ventana = new frm_Alta_Dueño(du);
            ventana.ShowDialog();
        }
    }
}
