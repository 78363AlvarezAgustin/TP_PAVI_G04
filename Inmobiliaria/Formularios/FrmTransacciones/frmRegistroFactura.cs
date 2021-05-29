using Inmobiliaria.AccesoADatos;
using Inmobiliaria.AccesoADatos.Transacciones;
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

namespace Inmobiliaria.Formularios.FrmTransacciones
{
    public partial class frmRegistroFactura : Form
    {
        public frmRegistroFactura()
        {
            InitializeComponent();
        }

        private void frmRegistroFactura_Load(object sender, EventArgs e)
        {
            CargarFecha();
            ObtenerUltimoNumFactura();
            CargarComboMediosPago();
        }


        private void CargarComboMediosPago()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM medios_pago";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbMedioPagos.DataSource = tabla;
                cmbMedioPagos.DisplayMember = "n_medio_pago";
                cmbMedioPagos.ValueMember = "id_medio_pago";
                cmbMedioPagos.SelectedIndex = -1;
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


        private void CargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void ObtenerUltimoNumFactura()
        {
            int nro = AD_Facturas.ObtenerUltimoNumFactura();
            txtNumFac.Text = (nro + 1).ToString();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Clientes.ObtenerClientePorDocumento(txtDni.Text.Trim());
                if (tablaResultado.Rows.Count > 0)
                {
                    //txtTipoDoc.Text = tablaResultado.Rows[0][1].ToString();
                    txtNombreCliente.Text = tablaResultado.Rows[0][2].ToString();
                    txtApellidoCliente.Text = tablaResultado.Rows[0][3].ToString();
                    //txtIdCliente.Text = tablaResultado.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                    txtDni.Focus();
                    txtNombreCliente.Text = "";
                    txtApellidoCliente.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el cliente");
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (!txtDni.Text.Trim().Equals("") && !txtNombreCliente.Text.Trim().Equals("") && !txtApellidoCliente.Text.Trim().Equals(""))
            {
                grillaClientes.Rows.Add(txtDni.Text, txtNombreCliente.Text, txtApellidoCliente.Text);
            }
            else
            {
                MessageBox.Show("Todos los campos deben contener algun dato");
            }
                
        }

        private void btnBuscarPropiedad_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Propiedades.GetPropiedadesPorDesigCatastral(int.Parse(txtDesigCatastral.Text.Trim()));
                if (tablaResultado.Rows.Count > 0)
                {
                    txtCalle.Text = tablaResultado.Rows[0][1].ToString();
                    txtNroCalle.Text = tablaResultado.Rows[0][2].ToString();
                    txtIDBarrio.Text = tablaResultado.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Propiedad no encontrada");
                    txtDesigCatastral.Focus();
                    txtCalle.Text = "";
                    txtNroCalle.Text = "";
                    txtIDBarrio.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener propiedad");
            }
        }

        private void btnAgregarPropiedad_Click(object sender, EventArgs e)
        {
            if (!txtDesigCatastral.Text.Trim().Equals("") && !txtCalle.Text.Trim().Equals("") && !txtNroCalle.Text.Trim().Equals("") && !txtIDBarrio.Text.Trim().Equals(""))
            {
                grillaPropiedades.Rows.Add(txtDesigCatastral.Text, txtCalle.Text, txtNroCalle.Text, txtIDBarrio.Text);
            }    
            else
            {
                MessageBox.Show("Todos los campos deben contener algun dato");
            }
        }



        private void btnBuscarDueño_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Dueños.ObtenerDueñoPorDocumento(int.Parse(txtDniDueño.Text.Trim()));
                if (tablaResultado.Rows.Count > 0)
                {
                    txtNombreDueño.Text = tablaResultado.Rows[0][2].ToString();
                    txtApellidoDueño.Text = tablaResultado.Rows[0][3].ToString();
                    //txtIdCliente.Text = tablaResultado.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("Dueño no encontrado");
                    txtDniDueño.Focus();
                    txtNombreDueño.Text = "";
                    txtApellidoDueño.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dueño");
            }
        }

        private void btnAgregarDueño_Click(object sender, EventArgs e)
        {
            if (!txtDniDueño.Text.Trim().Equals("") && !txtNombreDueño.Text.Trim().Equals("") && !txtApellidoDueño.Text.Trim().Equals(""))
            {
                grillaDueño.Rows.Add(txtDniDueño.Text, txtNombreDueño.Text, txtApellidoDueño.Text);
            }
            else
            {
                MessageBox.Show("Todos los campos deben contener algun dato");
            }
        }

        private void LimpiarCampos()
        {
            txtTotalComision.Text = "";
            txtDni.Text = "";
            txtDniDueño.Text = "";
            txtDesigCatastral.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            txtIDBarrio.Text = "";
            txtNombreDueño.Text = "";
            txtApellidoDueño.Text = "";
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            List<int> listaClientes = new List<int>();
            for (int i = 0; i < grillaClientes.Rows.Count; i++)
            {
                listaClientes.Add(int.Parse(grillaClientes.Rows[i].Cells[0].Value.ToString()));
            }
            
            List<int> listaPropiedades = new List<int>();
            for (int i = 0; i < grillaPropiedades.Rows.Count; i++)
            {
                listaPropiedades.Add(int.Parse(grillaPropiedades.Rows[i].Cells[0].Value.ToString()));
            }

            List<int> listaDueños = new List<int>();
            for (int i = 0; i < grillaDueño.Rows.Count; i++)
            {
                listaDueños.Add(int.Parse(grillaDueño.Rows[i].Cells[0].Value.ToString()));
            }

            if (!txtTotalComision.Text.Trim().Equals("") && !cmbMedioPagos.Text.Trim().Equals("") && listaClientes.Count > 0 && listaPropiedades.Count > 0 && listaDueños.Count > 0)
            {
                bool resultado = AD_Facturas.AltaNuevaFactura(int.Parse(txtNumFac.Text), float.Parse(txtTotalComision.Text), (int)cmbMedioPagos.SelectedValue, listaClientes, listaPropiedades, listaDueños);
                if (resultado)
                {
                    MessageBox.Show("Factura generada con éxito");
                    grillaClientes.Rows.Clear();
                    grillaPropiedades.Rows.Clear();
                    grillaDueño.Rows.Clear();
                    LimpiarCampos();
                    ObtenerUltimoNumFactura();
                    CargarComboMediosPago();
                }
                else
                {
                    MessageBox.Show("Error al generar la factura");
                }
            }
            else
            {
                MessageBox.Show("Revise que todos los datos esten cargados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
