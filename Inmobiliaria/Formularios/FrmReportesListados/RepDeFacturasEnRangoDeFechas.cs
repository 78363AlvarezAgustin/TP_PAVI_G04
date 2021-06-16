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
    public partial class RepDeFacturasEnRangoDeFechas : Form
    {
        public RepDeFacturasEnRangoDeFechas()
        {
            InitializeComponent();
        }

        private void RepDeFacturasEnRangoDeFechas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Facturas.ObtenerListadoFacturas();

            ReportDataSource ds = new ReportDataSource("DataSetFacturas", tabla);

            reporteFacturasPorFecha.LocalReport.DataSources.Clear();
            reporteFacturasPorFecha.LocalReport.DataSources.Add(ds);
            this.reporteFacturasPorFecha.RefreshReport();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtFechaDesde.Text.Equals("  /  /") || txtFechaHasta.Text.Equals("  /  /")) && chkTodas.Checked == false)
            {
                MessageBox.Show("Ingrese algun filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFechaDesde.Focus();
            }
            else if (chkTodas.Checked)
            {
                CargarReporteCompleto();
                reporteFacturasPorFecha.RefreshReport();
                LimpiarFiltros();
            }
            else 
            { 
                CargarReporte(txtFechaDesde.Text, txtFechaHasta.Text);
                reporteFacturasPorFecha.RefreshReport();
                LimpiarFiltros();
            }
        }
        private void CargarReporte(string desde, string hasta)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Facturas.ObtenerFacturasPorFecha(desde, hasta);

            ReportDataSource ds = new ReportDataSource("DataSetFacturas", tabla);

            reporteFacturasPorFecha.LocalReport.DataSources.Clear();
            reporteFacturasPorFecha.LocalReport.DataSources.Add(ds);
            reporteFacturasPorFecha.Refresh();
        }

        private void LimpiarFiltros()
        {
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            chkTodas.Checked = false;
        }

        private void CargarReporteCompleto()
        {
            DataTable tabla = new DataTable();
            tabla = AD_Facturas.ObtenerListadoFacturas();

            ReportDataSource ds = new ReportDataSource("DataSetFacturas", tabla);

            reporteFacturasPorFecha.LocalReport.DataSources.Clear();
            reporteFacturasPorFecha.LocalReport.DataSources.Add(ds);
            reporteFacturasPorFecha.Refresh();
        }
    }
}
