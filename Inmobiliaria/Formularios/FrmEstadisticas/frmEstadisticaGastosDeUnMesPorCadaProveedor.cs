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
    public partial class frmEstadisticaGastosDeUnMesPorCadaProveedor : Form
    {
        public frmEstadisticaGastosDeUnMesPorCadaProveedor()
        {
            InitializeComponent();
        }

        private void frmEstadisticaGastosDeUnMesPorCadaProveedor_Load(object sender, EventArgs e)
        {

            this.rpGastosProv.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtMes.Text.Equals(""))
            {
                MessageBox.Show("Faltan rellenar filtros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMes.Focus();
            }
            else
            {
                DataTable tabla = new DataTable();
                int mes = int.Parse(txtMes.Text);
                tabla = AD_Proveedores.ObtenerGastosPorMes(mes);

                ReportDataSource ds = new ReportDataSource("DataProvGastos", tabla);

                rpGastosProv.LocalReport.DataSources.Clear();
                rpGastosProv.LocalReport.DataSources.Add(ds);
                this.rpGastosProv.RefreshReport();
            }
        }
    }
}
