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

namespace Inmobiliaria.Formularios.FrmEstadisticas
{
    public partial class frmEstadisticaImporteTotalGastadoEnPublicidPorIdDeMedioPublicitario : Form
    {
        public frmEstadisticaImporteTotalGastadoEnPublicidPorIdDeMedioPublicitario()
        {
            InitializeComponent();
        }

        private void frmEstadisticaImporteTotalGastadoEnPublicidPorIdDeMedioPublicitario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
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
    }
}
