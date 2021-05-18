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
    public partial class frmAltaEncExpensas : Form
    {
        public frmAltaEncExpensas()
        {
            InitializeComponent();
        }

        private void btnGuardarEnc_Click(object sender, EventArgs e)
        {
            try
            {
                bool existe = AD_EncExpensas.ExisteEncExpensas(int.Parse(txtLegajo.Text));
                if (existe)
                {
                    MessageBox.Show("El Enc. de Expensas ingresado ya existe en el sistema", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLegajo.Focus();
                }
                else
                {
                    if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtLegajo.Text.Equals("") || txtTelefono.Text.Equals(""))
                    {
                        DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLegajo.Focus();
                    }
                    else
                    {
                        EncExpensas enc = ObtenerDatosEncExpensas();
                        bool resultado = AD_EncExpensas.AgregarEncExpensas(enc);

                        if (resultado)
                        {
                            MessageBox.Show("Enc. de Expensas agredado correctamente!", "Informacion");
                            LimpiarCampos();
                            //COMO AGREGO PARA QUE ACTUALICE LA GRILLA LUEGO DE CARGAR A UN NUEVO ENCARGADO?

                        }
                        else
                        {
                            MessageBox.Show("Error al insertar el Enc. de Expensas!");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese datos de nuevo Enc. de Expensas!");
                txtLegajo.Focus();
            }
        }


        private void LimpiarCampos()
        {
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
        }



        private EncExpensas ObtenerDatosEncExpensas()
        {
            EncExpensas enc = new EncExpensas();

            enc.LegajoEncExpensas = int.Parse(txtLegajo.Text);
            enc.NombreEncExpensas = txtNombre.Text;
            enc.ApellidoEncExpensas = txtApellido.Text;
            enc.TelefonoEncExpensas = int.Parse(txtTelefono.Text);
            return enc;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
