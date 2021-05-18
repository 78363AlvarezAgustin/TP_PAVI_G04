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
    public partial class frmAltaMediosPago : Form
    {
        public frmAltaMediosPago()
        {
            InitializeComponent();
        }

        private MediosPago ObtenerDatosMediosPago()
        {
            MediosPago pago = new MediosPago();

            pago.NombrePago = txtNombre.Text;
            pago.DescripcionPago = txtDescripcion.Text;

            return pago;
        }

        private void LimpiarCampos()
        {

            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool existe = AD_MediosPago.ExisteMediosPago(txtNombre.Text);
                if (existe)
                {
                    MessageBox.Show("El Medio de Pago ingresado ya existe en el sistema", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                }
                else
                {
                    if (txtNombre.Text.Equals(""))
                    {
                        DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombre.Focus();
                    }
                    else
                    {
                        MediosPago pago = ObtenerDatosMediosPago();
                        bool resultado = AD_MediosPago.AgregarMediosPago(pago);

                        if (resultado)
                        {
                            MessageBox.Show("Medio de Pago agredado correctamente!", "Informacion");
                            LimpiarCampos();

                        }
                        else
                        {
                            MessageBox.Show("Error al insertar el Medio de Pago!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Ingrese datos de Medio de Pago");
                txtNombre.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
