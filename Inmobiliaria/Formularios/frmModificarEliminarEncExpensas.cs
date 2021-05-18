using Inmobiliaria.AccesoADatos;
using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios
{
    public partial class frmModificarEliminarEncExpensas : Form
    {
        public frmModificarEliminarEncExpensas(EncExpensas enc)
        {
            InitializeComponent();
            CargarCampos(enc);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtTelefono.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult aviso = MessageBox.Show("¿Desea confirmar las modificaciones realizadas?", "Confirmar modificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (aviso == DialogResult.Yes)
                {
                    EncExpensas enc = ObtenerDatosEncExpensas();
                    bool resultado = AD_EncExpensas.ActualizarEncExpensas(enc);
                    if (resultado)
                    {
                        MessageBox.Show("Enc. de Expensas actualizado con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el Enc. de Expensas!");
                    }
                }

            }
        }


        private void CargarCampos(EncExpensas enc)
        {
            txtLegajo.Text = enc.LegajoEncExpensas.ToString();
            txtNombre.Text = enc.NombreEncExpensas;
            txtApellido.Text = enc.ApellidoEncExpensas;
            txtTelefono.Text = enc.TelefonoEncExpensas.ToString();
            ShowDialog();
        }

        //Guardo las modificaciones que hice en el form
        private EncExpensas ObtenerDatosEncExpensas()
        {
            EncExpensas enc = new EncExpensas();
            enc.LegajoEncExpensas = int.Parse(txtLegajo.Text.Trim());
            enc.NombreEncExpensas = txtNombre.Text.Trim();
            enc.ApellidoEncExpensas = txtApellido.Text.Trim();
            enc.TelefonoEncExpensas = int.Parse(txtTelefono.Text.Trim());

            return enc;
        }



        public static bool EliminarEncExpensas(EncExpensas enc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM encargados_expensas WHERE legajo_encargado like @legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", enc.LegajoEncExpensas);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el Enc. de Expensas seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                EncExpensas enc = ObtenerDatosEncExpensas();
                bool resultado = AD_EncExpensas.EliminarEncExpensas(enc);
                if (resultado)
                {
                    MessageBox.Show("Enc. de Expensas eliminado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar al Enc. de Expensas!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
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
