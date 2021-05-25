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
    public partial class frmFiltroEncExpensas : Form
    {
        public frmFiltroEncExpensas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltrarPorLegajo.Text.Equals(""))
                {
                    CargarGrillaEncExpensas();
                    MessageBox.Show("Ingrese algun legajo");
                }
                else
                {
                    DataTable tablaResultado = AD_EncExpensas.ObtenerEncExpensasPorLegajo(int.Parse(txtFiltrarPorLegajo.Text.Trim()));
                    if (tablaResultado.Rows.Count > 0)
                    {
                        MessageBox.Show("Enc. de Expensas Encontrado!");
                        gdrEncExpensas.DataSource = tablaResultado;
                    }
                    else
                    {
                        MessageBox.Show("Enc. de Expensas Inexistente");
                        txtFiltrarPorLegajo.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        
        private void CargarGrillaEncExpensas()
        {
            try
            {
                gdrEncExpensas.DataSource = AD_EncExpensas.ObtenerEncExpensas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmAltaEncExpensas ventana = new frmAltaEncExpensas();
            ventana.ShowDialog();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarGrillaEncExpensas();
            txtFiltrarPorLegajo.Text = "";
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdrEncExpensas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CargarGrillaEncExpensas();
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = gdrEncExpensas.Rows[indice];
                string legajo = filaSeleccionada.Cells["Legajo"].Value.ToString();
                EncExpensas enc = AD_EncExpensas.ObtenerObjEncExpensasPorLegajo(legajo);
                frmModificarEliminarEncExpensas ventana = new frmModificarEliminarEncExpensas(enc);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha salido mal, por favor seleccione una fila");
            }
        }

        private void frmFiltroEncExpensas_Load_1(object sender, EventArgs e)
        {
            CargarGrillaEncExpensas();
        }
    }
}
