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
    public partial class frmModificarEliminarBarrios : Form
    {
        public frmModificarEliminarBarrios(Barrios bar)
        {
            InitializeComponent();
            CargarCampos(bar);
        }

        private void CargarCampos(Barrios bar)
        {
            CargarComboBarrios();
            txtID.Text = bar.IdBarrio.ToString();
            txtNombre.Text = bar.NombreBarrio;
            cmbBarrio.SelectedValue = bar.IdLocalidadBarrio;
            ShowDialog();
        }

        private Barrios ObtenerDatosBarrios()
        {
            Barrios bar = new Barrios();
            bar.IdBarrio = int.Parse(txtID.Text.Trim());
            bar.NombreBarrio = txtNombre.Text.Trim();
            bar.IdLocalidadBarrio = (int)cmbBarrio.SelectedValue;

            return bar;
        }

        private void frmModificarEliminarBarrios_Load(object sender, EventArgs e)
        {

        }

        private void CargarComboBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM localidades";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbBarrio.DataSource = tabla;
                cmbBarrio.DisplayMember = "n_localidad";
                cmbBarrio.ValueMember = "id_localidad";
                cmbBarrio.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }
        }
        public static bool EliminarBarrio(Barrios bar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "DELETE FROM barrios WHERE id_barrio like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", bar.IdBarrio);

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

        public static bool ActualizarBarrio(Barrios bar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "UPDATE barrios SET n_barrio = @nombre, id_localidad = @idLocalidad WHERE id_barrio = @id_barrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_barrio", bar.IdBarrio);
                cmd.Parameters.AddWithValue("@nombre", bar.NombreBarrio);
                cmd.Parameters.AddWithValue("@idLocalidad", bar.IdLocalidadBarrio);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;

        }

        private void btnModificarBarrio_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Trim().Equals("") && AD_Barrio.ValidarAlRegistrar(txtNombre.Text.Trim()) == false)
            {
                Barrios bar = ObtenerDatosBarrios();
                bool resultado = ActualizarBarrio(bar);
                if (resultado)
                {
                    MessageBox.Show("Barrio actualizado con éxito");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al actualizar barrio");
                }
            }
            else
            {
                if (txtNombre.Text.Trim().Equals("") || cmbBarrio.Text.Equals(""))
                {
                    MessageBox.Show("Por favor complete los campos que esten vacios");
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el barrio exitosamente");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarBarrio_Click(object sender, EventArgs e)
        {
            Barrios bar = AD_Barrio.ObtenerBarrio(txtID.Text);
            bool resultado = EliminarBarrio(bar);
            if (resultado)
            {
                MessageBox.Show("Localidad eliminada con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar localidad");
            }
        }
    }
}
