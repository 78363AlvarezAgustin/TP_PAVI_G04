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
    public partial class frmFiltroMedioPago : Form
    {
        public frmFiltroMedioPago()
        {
            InitializeComponent();
            CargarGrillaMedioPago();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltrarPorId.Text.Equals(""))
                {
                    CargarGrillaMedioPago();
                    MessageBox.Show("Ingrese algun Id");
                }
                else
                {
                    DataTable tablaResultado = AD_MediosPago.ObtenerMediosPagoPorId(int.Parse(txtFiltrarPorId.Text.Trim()));
                    if (tablaResultado.Rows.Count > 0)
                    {
                        MessageBox.Show("Medio de Pago Encontrado!");
                        gdrMedioPago.DataSource = tablaResultado;
                    }
                    else
                    {
                        MessageBox.Show("Medio de Pago Inexistente");
                        txtFiltrarPorId.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void CargarGrillaMedioPago()
        {
            try
            {
                gdrMedioPago.DataSource = AD_MediosPago.ObtenerMediosPago();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaMediosPago ventana = new frmAltaMediosPago();
            ventana.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            CargarGrillaMedioPago();
            txtFiltrarPorId.Text = "";
        }

        private void gdrMedioPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CargarGrillaMedioPago();
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = gdrMedioPago.Rows[indice];
                string id = filaSeleccionada.Cells["Id"].Value.ToString();
                MediosPago pago = AD_MediosPago.ObtenerObjMediosPagoPorId(id);
                frmModificarMediosPago ventana = new frmModificarMediosPago(pago);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha salido mal, por favor seleccione una fila");
            }
        }
    }
}
