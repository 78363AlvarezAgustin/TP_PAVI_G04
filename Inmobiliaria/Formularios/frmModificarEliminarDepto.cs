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
    public partial class frmModificarEliminarDepto : Form
    {
        public frmModificarEliminarDepto(Depto d)
        {
            InitializeComponent();
            CargarComboProvincias();

            txtNroDepto.Text = d.IdDepto.ToString();
            txtNombreDepto.Text = d.NombreDepto.ToString();
            cmbProvincias.SelectedValue = d.IdProvinciaDepto;
        }


        private void CargarComboProvincias()
        {
            try
            {
                cmbProvincias.DataSource = AD_Provincias.ObtenerProvincias();
                cmbProvincias.DisplayMember = "n_provincia";
                cmbProvincias.ValueMember = "id_provincia";
                cmbProvincias.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las provincias!");
                throw;
            }
        }


        private Depto ObternerDatosDepto()
        {
            Depto d = new Depto();

            d.IdDepto = int.Parse(txtNroDepto.Text.Trim());
            d.NombreDepto = txtNombreDepto.Text.Trim();
            d.IdProvinciaDepto = (int)cmbProvincias.SelectedValue;

            return d;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el departamento seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                Depto d = ObternerDatosDepto();
                bool resultado = AD_Deptos.EliminarDepto(d);
                if (resultado)
                {
                    MessageBox.Show("Departamento eliminado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el departamento!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la eliminación del departamento?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
