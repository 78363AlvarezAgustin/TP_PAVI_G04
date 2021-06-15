using Inmobiliaria.AccesoADatos;
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
    public partial class ListClientesPorLocalidad : Form
    {
        public ListClientesPorLocalidad()
        {
            InitializeComponent();
        }

        private void ListClientesPorLocalidad_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = AD_Clientes.ObtenerClientePorLocalidad();

            ReportDataSource ds = new ReportDataSource("DatosClientesPorLocalidad", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            //reportViewer1.LocalReport.Refresh();
        }

        private void btnFiltrarDni_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = AD_Clientes.ObtenerClienteYDesigCatastralPorDocumento(txtDni.Text);

            ReportDataSource ds = new ReportDataSource("DatosClientesPorLocalidad", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void btnFiltrarDes_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = AD_Clientes.ObtenerClienteYDesigCatastralPorDocumento(txtDni.Text);

            ReportDataSource ds = new ReportDataSource("DatosClientesPorLocalidad", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtDes.Text = "";
            txtDni.Text = "";
            ListClientesPorLocalidad_Load(sender, e);
        }
    }
}
