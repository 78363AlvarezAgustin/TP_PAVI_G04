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
    public partial class frmAltaPublicidad : Form
    {
        public frmAltaPublicidad()
        {
            InitializeComponent();
        }

        private void frmAltaPublicidad_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboMedios();
            CargarComboSecciones();
            CargarGrillaPropiedades();
            CargarGrillaPublicidades();
        }
        private void LimpiarCampos()
        {
            txtFecha.Text = "";
            txtDesignacionCatastral.Text = "";
            txtDescripcion.Text = "";
            txtCostoPublicidad.Text = "";
        }
        private void CargarComboMedios()
        {
            try
            {
                cmbMedioPublicitario.DataSource = AD_MediosPublicidad.ObtenerListadoMedioPublicitario();
                cmbMedioPublicitario.DisplayMember = "n_medio_publicitario";
                cmbMedioPublicitario.ValueMember = "id_medio_publicitario";
                cmbMedioPublicitario.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los medios publicitarios!");
                throw;
            }
        }
        private void CargarComboSecciones()
        {
            try
            {
                cmbSeccion.DataSource = AD_Secciones.ObtenerListadoSecciones();
                cmbSeccion.DisplayMember = "n_seccion_publicidad";
                cmbSeccion.ValueMember = "id_seccion";
                cmbSeccion.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las secciones publicitarias!");
                throw;
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
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
        private void CargarGrillaPropiedades()
        {
            try
            {
                grillaPropiedades.DataSource = AD_Propiedades.ObtenerPropiedades();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }

        private void btnGuardarPublicidad_Click(object sender, EventArgs e)
        {
            if (txtDesignacionCatastral.Text.Equals("") || txtCostoPublicidad.Text.Equals("") || txtDescripcion.Text.Equals("") || cmbSeccion.SelectedIndex.Equals(-1) || cmbMedioPublicitario.SelectedIndex.Equals(-1) || txtFecha.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Publicidad p = ObtenerDatosPublicidad();
                bool resultado = AD_Publicidad.AgregarPublicidad(p);

                if (resultado)
                {
                    MessageBox.Show("Publicidad agredada correctamente!", "Informacion");
                    LimpiarCampos();
                    CargarComboMedios();
                    CargarComboSecciones();
                    CargarGrillaPropiedades();
                    CargarGrillaPublicidades();
                }
                else
                {
                    MessageBox.Show("Error al insertar la publicidad!");
                }
            }
        }

        private void grillaPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaPropiedades.Rows[indice];

            int desigCatastral = int.Parse(filaSeleccionada.Cells["DesignacionCatastral"].Value.ToString());
            txtDesignacionCatastral.Text = desigCatastral.ToString();
        }

        private Publicidad ObtenerDatosPublicidad()
        {
            Publicidad publi = new Publicidad();

            publi.DesigCatastralPubli = int.Parse(txtDesignacionCatastral.Text);
            publi.FechaPubli = DateTime.Parse(txtFecha.Text);
            publi.CostoPubli = int.Parse(txtCostoPublicidad.Text);
            publi.DescripcionPubli = txtDescripcion.Text;
            publi.IdMedioPubli = (int)cmbMedioPublicitario.SelectedValue;
            publi.IdSeccionPubli = (int)cmbSeccion.SelectedValue;

            return publi;
        }
        private void CargarGrillaPublicidades()
        {
            try
            {
                grillaPublicidades.DataSource = AD_Publicidad.ObtenerPublicidades();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla de publicidades!");
                throw;
            }
        }
    }
}
