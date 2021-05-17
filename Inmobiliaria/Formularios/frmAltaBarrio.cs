using Inmobiliaria.Entidades;
using Inmobiliaria.AccesoADatos;
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
    public partial class frmAltaBarrio : Form
    {
        public frmAltaBarrio()
        {
            InitializeComponent();
        }

        private void frmAltaBarrio_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboLocalidades();
        }

        private void CargarComboLocalidades()
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

                cmbLocalidad.DataSource = tabla;
                cmbLocalidad.DisplayMember = "n_localidad";
                cmbLocalidad.ValueMember = "id_localidad";
                cmbLocalidad.SelectedIndex = -1;
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

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
        }

        private Barrios ObtenerDatosBarrio()
        {
            Barrios bar = new Barrios();
            bar.NombreBarrio = txtNombre.Text.Trim();
            bar.IdLocalidadBarrio = (int)cmbLocalidad.SelectedValue;

            return bar;
        }

        private void btnAltaBarrio_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Trim().Equals("") && !cmbLocalidad.Text.Equals("") && AD_Barrio.ValidarAlRegistrar(txtNombre.Text.Trim()) == false)
            {
                Barrios bar = ObtenerDatosBarrio();
                bool resultado = AD_Barrio.AgregarBarrioABD(bar);
                if (resultado)
                {
                    MessageBox.Show("Barrio agregada con éxito");
                    LimpiarCampos();
                    CargarComboLocalidades();

                }
                else
                {
                    MessageBox.Show("Error al agregar barrio");
                }

                //MessageBox.Show(nombre + " " + apellido + " " + sexo + " " + tipoDocumento + " " + nroDocumento);
                //MessageBox.Show("Datos de la persona: " + per.NombrePersona + " " + per.ApellidoPersona + " " + per.DocumentoPersona);
            }
            else
            {
                if (AD_Barrio.ValidarAlRegistrar(txtNombre.Text.Trim()) == true)
                {
                    MessageBox.Show("El nombre del barrio ya existe");
                }
                else if (txtNombre.Text.Trim().Equals("") || cmbLocalidad.Text.Equals(""))
                {
                    MessageBox.Show("Por favor complete los campos que esten vacios");
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el barrio exitosamente");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
