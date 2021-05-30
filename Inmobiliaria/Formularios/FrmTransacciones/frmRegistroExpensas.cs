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

namespace Inmobiliaria.Formularios.FrmTransacciones
{
    public partial class frmRegistroExpensas : Form
    {
        public frmRegistroExpensas()
        {
            InitializeComponent();
        }

        private void frmRegistroExpensas_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrillaEdificios();
            CargarGrillaExpensas();
        }

        private void LimpiarCampos()
        {
            txtIdEdificio.Text = "";
            txtaño.Text = "";
            txtImporte.Text = "";
            txtMes.Text = "";
        }

        private void btnLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la transacción?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
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
        private void CargarGrillaExpensas()
        {
            try
            {
                grillaExpensas.DataSource = AccesoADatos.Transacciones.AD_Expensas.ObtenerExpensas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla de Expensas!");
                throw;
            }
        }

        private void btnGuardarPublicidad_Click(object sender, EventArgs e)
        {
            if (txtIdEdificio.Text.Equals("") || txtaño.Text.Equals("") || txtImporte.Text.Equals("") || txtMes.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Expensas p = ObtenerDatosExpensa();
                bool resultado = AccesoADatos.Transacciones.AD_Expensas.AgregarExpensa(p);

                if (resultado)
                {
                    MessageBox.Show("Expensa agredada correctamente!", "Informacion");
                    LimpiarCampos();
                    CargarGrillaEdificios();
                    CargarGrillaExpensas();
                }
                else
                {
                    MessageBox.Show("Error al insertar la publicidad!");
                }
            }
        }

        private void grillaEdificios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaEdificios.Rows[indice];

            int idEdificio = int.Parse(filaSeleccionada.Cells["id_edificio"].Value.ToString());
            txtIdEdificio.Text = idEdificio.ToString();
        }

        private Expensas ObtenerDatosExpensa()
        {
            Expensas publi = new Expensas();

            publi.IdDeEdificio = int.Parse(txtIdEdificio.Text);
            publi.mesExpensa = int.Parse(txtMes.Text);
            publi.anoExpensa = int.Parse(txtaño.Text);
            publi.importeExpensa = int.Parse(txtImporte.Text);

            return publi;
        }
    }
}
