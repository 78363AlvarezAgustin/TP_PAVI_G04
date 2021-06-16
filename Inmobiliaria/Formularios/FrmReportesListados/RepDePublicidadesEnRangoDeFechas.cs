using Inmobiliaria.AccesoADatos.Transacciones;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios.FrmReportesListados
{
    public partial class RepDePublicidadesEnRangoDeFechas : Form
    {
        public RepDePublicidadesEnRangoDeFechas()
        {
            InitializeComponent();
           // this.reportViewer1.RefreshReport();
            txtDesde.Focus();
        }

        private void RepDePublicidadesEnRangoDeFechas_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.RefreshReport();
        }

        private void btnBuscarXFecha_Click(object sender, EventArgs e)
        {

            GenerarReportePublicidades();


        }
        private void GenerarReportePublicidades()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = AD_Publicidad.ObtenerPublicidadesXFecha(txtDesde.Text, txtHasta.Text);
                if (tabla.Rows.Count > 0)
                {
                    ReportDataSource ds = new ReportDataSource("DataSetPublicidades", tabla);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Inmobiliaria.Formularios.FrmReportesListados.InformePublicidadesXFecha.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);//agregar data set
                    reportViewer1.RefreshReport();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros de Publicidades en ese rango de Fechas");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Obtener Publicidades revise las fechas solicitadas");
            }




        }
        private void LimpiarCampos()
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
