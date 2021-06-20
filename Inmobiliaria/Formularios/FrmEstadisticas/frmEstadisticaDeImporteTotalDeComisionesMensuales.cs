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

namespace Inmobiliaria.Formularios.FrmEstadisticas
{
    public partial class frmEstadisticaDeImporteTotalDeComisionesMensuales : Form
    {
        public frmEstadisticaDeImporteTotalDeComisionesMensuales()
        {
            InitializeComponent();
        }

        private void frmEstadisticaDeImporteTotalDeComisionesMensuales_Load(object sender, EventArgs e)
        {
            txtAño.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtAño.Text.Equals(""))
            {
                MessageBox.Show("Faltan rellenar filtros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAño.Focus();
            }
            else
            {
                DataTable tabla = new DataTable();
                int año = int.Parse(txtAño.Text);
                tabla = AD_Facturas.ObtenerComisionesPorAño(año);

                ReportDataSource ds = new ReportDataSource("EstadisticaComisionesMensuales", tabla);

                EstadisticaComisiones.LocalReport.DataSources.Clear();
                EstadisticaComisiones.LocalReport.DataSources.Add(ds);
                this.EstadisticaComisiones.RefreshReport();
            }
        }
    }
}
