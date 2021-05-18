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
    public partial class frmABMMediosPublic : Form
    {
        public frmABMMediosPublic()
        {
            InitializeComponent();
            txtNombreMedioPublicitario.Text = "";
            txtID.Text = "";
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                gdrMediosPublicitarios.DataSource = AD_MediosPublicidad.ObtenerListadoMedioPublicitario();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener Medio de Publicidad");
            }


        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreMedioPublicitario.Text = "";
            txtID.Text = "";
        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            MedioPublicidad mp = new MedioPublicidad();
            mp.NombreMedioPublicitario = txtNombreMedioPublicitario.Text;





            if (txtID.Text.Equals(""))
            {
                if (txtNombreMedioPublicitario.Text.Equals(""))
                {
                    DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreMedioPublicitario.Focus();
                }
                else
                {
                    bool res = AD_MediosPublicidad.AgregarMedioPublicitario(mp);

                    if (res)
                    {
                        MessageBox.Show("Medio Publicitario agredado correctamente!", "Informacion");
                        txtNombreMedioPublicitario.Text = "";
                        txtID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar Medio Publicitario!");
                    }
                }
            }
            else
            {
                mp.Id = int.Parse(txtID.Text);
                bool res = AD_MediosPublicidad.ActualizarMedioPublicitario(mp);
                txtNombreMedioPublicitario.Focus();
                MessageBox.Show("Medio Publicitario actualizado correctamente!", "Informacion");
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
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el Medio de Publicidad seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                MedioPublicidad mp = new MedioPublicidad();
                mp.NombreMedioPublicitario = txtNombreMedioPublicitario.Text;
                bool resultado = AD_MediosPublicidad.EliminarMedioPublicitario(mp);
                if (resultado)
                {
                    MessageBox.Show("Medio Publicitario eliminado con exito!");
                }
                else
                {
                    MessageBox.Show("Error al eliminar Medio Publicitario!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
            CargarGrilla();
            txtID.Text = "";
        }

        private void gdrMedioPublicidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrMediosPublicitarios.Rows[indice];
            string mp = filaSeleccionda.Cells["MedioPublicidad"].Value.ToString();
            string id = filaSeleccionda.Cells["ID"].Value.ToString();



            txtNombreMedioPublicitario.Text = "";
            txtID.Text = "";
            txtID.Text = id;
            txtNombreMedioPublicitario.Text = mp;
        }


    }
}
