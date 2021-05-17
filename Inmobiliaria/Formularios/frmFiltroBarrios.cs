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
    public partial class frmFiltroBarrios : Form
    {
        public frmFiltroBarrios()
        {
            InitializeComponent();
        }

        private void frmFiltroBarrios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            try
            {
                gdrBarrios.DataSource = AD_Barrio.ObtenerBarrios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtenerbarrios");
            }

        }


        private void gdrBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CargarGrilla();
                int indice = e.RowIndex;
                DataGridViewRow filaSeleccionada = gdrBarrios.Rows[indice];
                string id = filaSeleccionada.Cells["IdBarr"].Value.ToString();
                Barrios bar = AD_Barrio.ObtenerBarrio(id);
                frmModificarEliminarBarrios vent = new frmModificarEliminarBarrios(bar);
                //CargarCampos(em);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha salido mal, por favor seleccione una fila");
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmAltaBarrio ventana = new frmAltaBarrio();
            ventana.ShowDialog();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltrarPorBarrio.Text.Equals(""))
                {
                    CargarGrilla();
                    MessageBox.Show("Ingrese algun nombre");
                }
                else
                {
                    DataTable tablaResultado = AD_Barrio.ObtenerBarrioXNombre(txtFiltrarPorBarrio.Text.Trim());
                    if (tablaResultado.Rows.Count > 0)
                    {
                        gdrBarrios.DataSource = tablaResultado;
                    }
                    else
                    {
                        MessageBox.Show("Barrio Inexistente");
                        txtFiltrarPorBarrio.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}

