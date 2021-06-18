using Inmobiliaria.AccesoADatos;
using Microsoft.Reporting.WinForms;
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

namespace Inmobiliaria.Formularios.FrmEstadisticas
{
    public partial class frmEstadisticaEmpleadosPorBarrio : Form
    {
        public frmEstadisticaEmpleadosPorBarrio()
        {
            InitializeComponent();
            CargarComboBarrios();
        }

        private void CargarComboBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM barrios";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbBarrio.DataSource = tabla;
                cmbBarrio.DisplayMember = "n_barrio";
                cmbBarrio.ValueMember = "id_barrio";
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


        private void frmEstadisticaEmpleadosPorBarrio_Load(object sender, EventArgs e)
        {

            this.reportViewer3.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Empleados.ObtenerEstadisticaEmpleados();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticasEmpleados", tabla);

            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(ds);
            reportViewer3.LocalReport.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBarrio.Text.Equals(""))
                {
                    MessageBox.Show("Selecciones algun barrio");
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = AD_Empleados.ObtenerEstadisticaEmpleadosXBarrio(cmbBarrio.Text);
                    ReportDataSource ds = new ReportDataSource("DatosEstadisticasEmpleados", tabla);
                    reportViewer3.LocalReport.DataSources.Clear();
                    reportViewer3.LocalReport.DataSources.Add(ds);
                    reportViewer3.RefreshReport();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
