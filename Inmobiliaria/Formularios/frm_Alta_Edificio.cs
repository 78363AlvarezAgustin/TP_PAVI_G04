using Inmobiliaria.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Entidades;

namespace Inmobiliaria
{
    public partial class frm_Alta_Edificio : Form
    {
        public frm_Alta_Edificio(Edificio ed)
        {
            InitializeComponent();
            CargarComboBarrios();
            if (ed==null)
            {
                btnEliminarEdificio.Enabled = false;
            }
            else
            {
                CargarCampos(ed);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existe = AD_Edificios.ExisteEdificio(txtNombreEdificio.Text);

            if (existe)
            {
                Edificio ed = ObtenerDatosEdificio();
                bool res = AD_Edificios.ActualizarEdificio(ed);
                txtNombreEdificio.Focus();
            }
            else
            {
                if (txtCalle.Text.Equals("") || txtCantidadDptos.Text.Equals("") || cmbBarrio.Text.Equals("") || txtNombreEdificio.Text.Equals("") || txtNumeroCalle.Text.Equals(""))
                {
                    DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreEdificio.Focus();
                }
                else
                {
                    Edificio ed = ObtenerDatosEdificio();
                    bool res = AD_Edificios.AgregarEdificioBD(ed);

                    if (res)
                    {
                        MessageBox.Show("Edificio agredado correctamente!", "Informacion");
                        LimpiarCampos();
                        CargarComboBarrios();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el Edificio!");
                    }
                }
            }

        }



        private Edificio ObtenerDatosEdificio()
        {
            Edificio ed = new Edificio();
            ed.NombreEdificio = txtNombreEdificio.Text.Trim();
            ed.CantidadDptosEdificio = int.Parse(txtCantidadDptos.Text);
            if (chkAscensor.Checked)
            {
                ed.TieneAscensorEdificio = true;
            }
            else
            {
                ed.TieneAscensorEdificio = false;
            }
            ed.CalleEdificio = txtCalle.Text.Trim();
            ed.NumeroCalleEdificio = int.Parse(txtNumeroCalle.Text);
            ed.IdBarrioEdificio = (int)cmbBarrio.SelectedValue;



            return ed;
        }

        private void CargarComboBarrios()
        {

            try
            {

                cmbBarrio.DataSource = AD_Edificios.ObtenerTabla("barrios");
                cmbBarrio.DisplayMember = "n_barrio";
                cmbBarrio.ValueMember = "id_barrio";
                cmbBarrio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void LimpiarCampos()
        {
            txtNombreEdificio.Text = "";
            txtCantidadDptos.Text = "";
            chkAscensor.Checked = false;
            txtCalle.Text = "";
            txtNumeroCalle.Text = "";
            txtNombreEdificio.Focus();
            cmbBarrio.SelectedItem = null;
            
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CargarCampos(Edificio ed)
        {
            txtNombreEdificio.Text = ed.NombreEdificio;

            txtCantidadDptos.Text = ed.CantidadDptosEdificio.ToString();


            if (ed.TieneAscensorEdificio)
            {
                chkAscensor.Checked = true;
            }
            else
            {
                chkAscensor.Checked = false;
            }

            txtCalle.Text = ed.CalleEdificio;
            txtNumeroCalle.Text = ed.NumeroCalleEdificio.ToString();
            cmbBarrio.SelectedValue = ed.IdBarrioEdificio;

        }

        private void btnEliminarEdificio_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el edificio seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Edificio ed = ObtenerDatosEdificio();
                bool resultado = AD_Edificios.EliminarEdificio(ed);
                if (resultado)
                {
                    MessageBox.Show("Edificio eliminado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el edificio!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
        }
    }
}
