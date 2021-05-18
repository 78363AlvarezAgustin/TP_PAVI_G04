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
    public partial class frmModificarMediosPago : Form
    {
        public frmModificarMediosPago(MediosPago pago)
        {
            InitializeComponent();
            CargarCampos(pago);
        }


        private void CargarCampos(MediosPago pago)
        {
            txtId.Text = pago.IdPago.ToString();
            txtNom.Text = pago.NombrePago;
            txtDescripcion.Text = pago.DescripcionPago;
            ShowDialog();
        }

        private MediosPago ObtenerDatosMediosPago()
        {
            MediosPago pago = new MediosPago();
            pago.IdPago = int.Parse(txtId.Text.Trim());
            pago.NombrePago = txtNom.Text.Trim();
            pago.DescripcionPago = txtDescripcion.Text.Trim();

            return pago;
        }

        public static bool EliminarMediosPago(MediosPago pago)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM medios_pago WHERE id_medio_pago like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", pago.IdPago);

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


        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtNom.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult aviso = MessageBox.Show("¿Desea confirmar las modificaciones realizadas?", "Confirmar modificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (aviso == DialogResult.Yes)
                {
                    MediosPago pago = ObtenerDatosMediosPago();
                    bool resultado = AD_MediosPago.ActualizarMediosPago(pago);
                    if (resultado)
                    {
                        MessageBox.Show("Medio de pago actualizado con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el Medio de pago!");
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el Medio de Pago seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                MediosPago pago = ObtenerDatosMediosPago();
                bool resultado = AD_MediosPago.EliminarMediosPago(pago);
                if (resultado)
                {
                    MessageBox.Show("Medio de Pago eliminado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Medio de Pago!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
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
