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
    public partial class frmEstadisticaImporteDeReciboRealizadaPorMes : Form
    {
        public frmEstadisticaImporteDeReciboRealizadaPorMes()
        {
            InitializeComponent();
        }

        private void frmEstadisticaImporteDeReciboRealizadaPorMes_Load(object sender, EventArgs e)
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
                tabla = AD_Recibos.ObtenerRecibosPorAño(año);

                ReportDataSource ds = new ReportDataSource("DatosRecibosMensuales", tabla);

                EstadisticaRecibos.LocalReport.DataSources.Clear();
                EstadisticaRecibos.LocalReport.DataSources.Add(ds);
                this.EstadisticaRecibos.RefreshReport();

                txtAño.Text = "";
                txtAño.Focus();
            }
        }
    }
}
