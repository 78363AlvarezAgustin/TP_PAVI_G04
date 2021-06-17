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

namespace Inmobiliaria.Formularios.FrmReportesListados
{
    public partial class ListDePropiedadesPorTipo : Form
    {
        public ListDePropiedadesPorTipo()
        {
            InitializeComponent();
        }

        private void ListDePropiedadesPorTipo_Load(object sender, EventArgs e)
        {
            this.RVPropTipo.RefreshReport();
            CargarComboTipos();
        }

        private void CargarComboTipos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM tipos_propiedades";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbTipo.DataSource = tabla;
                cmbTipo.DisplayMember = "n_tipo_propiedad";
                cmbTipo.ValueMember = "id_tipo_propiedad";
                cmbTipo.SelectedIndex = -1;

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

        private void RVPropTipo_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Propiedades.ObtenerPropiedadesCompleto();
            ReportDataSource ds = new ReportDataSource("DSPropTipo", tabla);

            RVPropTipo.LocalReport.DataSources.Clear();
            RVPropTipo.LocalReport.DataSources.Add(ds);
            RVPropTipo.LocalReport.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.Text.Equals(""))
                {
                    MessageBox.Show("Selecciones algun Tipo");
                }
                else
                {

                    DataTable tabla = new DataTable();
                    tabla = AD_Propiedades.GetPropiedadesPorTipo((int)cmbTipo.SelectedValue);
                    ReportDataSource ds = new ReportDataSource("DSPropTipo", tabla);
                    RVPropTipo.LocalReport.DataSources.Clear();
                    RVPropTipo.LocalReport.DataSources.Add(ds);
                    RVPropTipo.RefreshReport();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        
    }
}
