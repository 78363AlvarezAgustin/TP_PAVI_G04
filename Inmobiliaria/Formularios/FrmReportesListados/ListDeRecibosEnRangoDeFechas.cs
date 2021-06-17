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
    public partial class ListDeRecibosEnRangoDeFechas : Form
    {
        public ListDeRecibosEnRangoDeFechas()
        {
            InitializeComponent();
        }

        private void ListDeRecibosEnRangoDeFechas_Load(object sender, EventArgs e)
        {
            txtDesde.Focus();
            
        }


        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtDesde.Text = "";
                txtHasta.Text = "";
                txtDesde.Enabled = false;
                txtHasta.Enabled = false;
            } else
            {
                txtDesde.Enabled = true;
                txtHasta.Enabled = true;
                txtDesde.Focus();
            }
        }


        private void CargarReporteCompleto()
        {
            DataTable tabla = new DataTable();
            tabla = AD_Recibos.ObtenerRecibos();

            ReportDataSource ds = new ReportDataSource("DatosRecibos", tabla);

            reporteRecibos.LocalReport.DataSources.Clear();
            reporteRecibos.LocalReport.DataSources.Add(ds);
            this.reporteRecibos.RefreshReport();
        }


        private void CargarReporteFiltrado(string desde, string hasta)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Recibos.ObtenerRecibosPorFecha(desde, hasta);

            ReportDataSource ds = new ReportDataSource("DatosRecibos", tabla);

            reporteRecibos.LocalReport.DataSources.Clear();
            reporteRecibos.LocalReport.DataSources.Add(ds);
            this.reporteRecibos.RefreshReport();
        }


        private void LimpiarFiltros()
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
            chkTodos.Checked = false;
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if ((txtDesde.Text.Equals("  /  /") || txtHasta.Text.Equals("  /  /")) && chkTodos.Checked == false)
            {
                MessageBox.Show("Faltan rellenar filtros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesde.Focus();
            }
            else if (chkTodos.Checked)
            {
                CargarReporteCompleto();
                reporteRecibos.RefreshReport();
                LimpiarFiltros();
            }
            else
            {
                CargarReporteFiltrado(txtDesde.Text, txtHasta.Text);
                reporteRecibos.RefreshReport();
                LimpiarFiltros();
            }
        }
    }
}
