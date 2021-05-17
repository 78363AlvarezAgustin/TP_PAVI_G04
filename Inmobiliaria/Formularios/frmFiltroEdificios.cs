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
    public partial class frmFiltroEdificios : Form
    {
        public frmFiltroEdificios()
        {
            InitializeComponent();
        }





        private void CargarGrilla()
        {
            try
            {
                gdrEdificios.DataSource = AD_Edificios.ObtenerListadoEdificios();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Obtener Edificios");
            }
        }

        private void AltaEdificio_Load(object sender, EventArgs e)
        {
            txtNombreEdificio.Focus();
        }





        private void gdrEdificios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrEdificios.Rows[indice];
            string nombreEdificio = filaSeleccionda.Cells["Nombre"].Value.ToString();
            Edificios ed = AD_Edificios.ObtenerEdificio(nombreEdificio);

            frmABMEdificios ventana = new frmABMEdificios(ed);

            ventana.ShowDialog();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkMostrarTodosEdificios.Checked)
            {
                CargarGrilla();
            }
            else if (txtNombreEdificio.Text.Equals(""))
            {
                MessageBox.Show("Selecciona algun filtro!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreEdificio.Focus();
            }
            else
            {

                gdrEdificios.DataSource = AD_Edificios.GetEdificioPorNombre(txtNombreEdificio.Text);
                if (gdrEdificios.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtNombreEdificio.Text = "";
            chkMostrarTodosEdificios.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            Edificios ed = new Edificios();
            frmABMEdificios ventana = new frmABMEdificios(ed);
            ventana.ShowDialog();
        }
    }
}
