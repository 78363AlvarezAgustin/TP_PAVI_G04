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
    public partial class frmABMTipoProp : Form
    {
        public frmABMTipoProp()
        {
            InitializeComponent();
            txtTipoPropiedad.Text = "";
            txtDescripcion.Text = "";
            
            txtID.Text = "";
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                gdrTiposPropiedad.DataSource = AD_TiposPropiedades.ObtenerTiposPropiedades();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener Tipos de Propiedades");
            }


        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtTipoPropiedad.Text = "";
            txtDescripcion.Text = "";
            txtID.Text = "";
        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            TipoPropiedad tp= new TipoPropiedad();
            tp.NombreTipoPropiedad = txtTipoPropiedad.Text;
            tp.Descripcion = txtDescripcion.Text;





            if (txtID.Text.Equals(""))
            {
                if (txtTipoPropiedad.Text.Equals("") || txtDescripcion.Text.Equals(""))
                {
                    DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTipoPropiedad.Focus();
                }
                else
                {
                    bool res = AD_TiposPropiedades.AgregarTipoPropiedadD(tp);

                    if (res)
                    {
                        MessageBox.Show("Tipo de Propiedad agredada correctamente!", "Informacion");
                        txtTipoPropiedad.Text = "";
                        txtDescripcion.Text = "";
                        txtID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar Tipo de Propiedad!");
                    }
                }
            }
            else
            {
                tp.Id= int.Parse(txtID.Text);
                bool res = AD_TiposPropiedades.ActualizarTipoPropiedad(tp);
                txtTipoPropiedad.Focus();
                MessageBox.Show("Tipo de Propiedad actualizada correctamente!", "Informacion");
            }
            CargarGrilla();
            txtID.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el Tipo de Propiedad seleccionada?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                TipoPropiedad tp = new TipoPropiedad();
                tp.NombreTipoPropiedad= txtTipoPropiedad.Text;
                bool resultado = AD_TiposPropiedades.EliminarTipoPropiedad(tp);
                if (resultado)
                {
                    MessageBox.Show("Tipo de Propiedad eliminado con exito!");
                }
                else
                {
                    MessageBox.Show("Error al eliminar Tipo de Propiedad!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
            CargarGrilla();
            txtID.Text = "";
        }

        private void gdrTiposPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrTiposPropiedad.Rows[indice];
            string prop = filaSeleccionda.Cells["TipoPropiedad"].Value.ToString();
            string id = filaSeleccionda.Cells["ID"].Value.ToString();
            string desc= filaSeleccionda.Cells["Descripcion"].Value.ToString();



            txtTipoPropiedad.Text = "";
            txtDescripcion.Text = "";
            txtID.Text = "";
            txtID.Text = id;
            txtTipoPropiedad.Text = prop;
            txtDescripcion.Text = desc;
        }

    }
}
