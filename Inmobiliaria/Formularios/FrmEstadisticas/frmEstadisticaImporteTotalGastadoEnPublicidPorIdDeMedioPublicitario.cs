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
    public partial class frmEstadisticaImporteTotalGastadoEnPublicidPorIdDeMedioPublicitario : Form
    {
        public frmEstadisticaImporteTotalGastadoEnPublicidPorIdDeMedioPublicitario()
        {
            InitializeComponent();
            CargarComboBarrios();
        }

        private void frmEstadisticaImporteTotalGastadoEnPublicidPorIdDeMedioPublicitario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void CargarComboBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM secciones_publicidad";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbBarrio.DataSource = tabla;
                cmbBarrio.DisplayMember = "n_seccion_publicidad";
                cmbBarrio.ValueMember = "id_seccion";
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


        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = AD_MediosPago.ObtenerDatosEstadistica();

            ReportDataSource ds = new ReportDataSource("DatoEstadisticaImporteXIdMed", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBarrio.Text.Equals(""))
                {
                    MessageBox.Show("Selecciones algun filtro");
                }
                if (cmbBarrio.Text.Equals("Principal"))
                {
                    DataTable tabla = new DataTable();
                    tabla = AD_MediosPago.ObtenerDatosEstadisticaXIdSeccion(1);
                    ReportDataSource ds = new ReportDataSource("DatoEstadisticaImporteXIdMed", tabla);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.RefreshReport();

                }
                if (cmbBarrio.Text.Equals("Secundaria"))
                {
                    DataTable tabla = new DataTable();
                    tabla = AD_MediosPago.ObtenerDatosEstadisticaXIdSeccion(2);
                    ReportDataSource ds = new ReportDataSource("DatoEstadisticaImporteXIdMed", tabla);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.RefreshReport();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
