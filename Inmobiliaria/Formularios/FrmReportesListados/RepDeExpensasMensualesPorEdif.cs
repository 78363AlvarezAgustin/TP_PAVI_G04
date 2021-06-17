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
    public partial class RepDeExpensasMensualesPorEdif : Form
    {
        public RepDeExpensasMensualesPorEdif()
        {
            InitializeComponent();
        }

        private void RepDeExpensasMensualesPorEdif_Load(object sender, EventArgs e)
        {
            txtMes.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(txtMes.Text.Equals("") || txtAño.Text.Equals(""))
            {
                MessageBox.Show("Faltan rellenar filtros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMes.Focus();
            } else
            {
                DataTable tabla = new DataTable();
                int mes = int.Parse(txtMes.Text);
                int año = int.Parse(txtAño.Text);
                tabla = AD_Expensas.ObtenerExpensasPorMesYAño(mes, año);

                ReportDataSource ds = new ReportDataSource("DatosExpensasMensualesXEdificio", tabla);

                reporteExpensas.LocalReport.DataSources.Clear();
                reporteExpensas.LocalReport.DataSources.Add(ds);
                this.reporteExpensas.RefreshReport();
            }
        }
    }
}
