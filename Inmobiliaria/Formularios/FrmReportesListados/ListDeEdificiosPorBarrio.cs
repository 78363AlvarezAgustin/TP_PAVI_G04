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
    public partial class ListDeEdificiosPorBarrio : Form
    {
        public ListDeEdificiosPorBarrio()
        {
            InitializeComponent();
        }

        private void ListDeEdificiosPorBarrio_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.AD_Edificios.ObtenerTabla("edificios");

            ReportDataSource ds = new ReportDataSource("DatosBarrios", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
            //reportViewer1.LocalReport.Refresh();        }
        }

        private void btnFiltrarDni_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = AD_Edificios.ObtenerEdificioPorNombre(txtNombre.Text);

            ReportDataSource ds = new ReportDataSource("DatosBarrios", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void btnFiltrarDes_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = AD_Edificios.ObtenerEdificioPorBarrio(txtBarrio.Text);

            ReportDataSource ds = new ReportDataSource("DatosBarrios", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBarrio.Text = " ";
            txtNombre.Text = "";
            ListDeEdificiosPorBarrio_Load(sender, e);

        }
    }
}

