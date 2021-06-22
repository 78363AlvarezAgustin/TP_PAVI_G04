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
    public partial class frmEstadisticaExpenCobradasMensualEdificio : Form
    {
        public frmEstadisticaExpenCobradasMensualEdificio()
        {
            InitializeComponent();
        }

        private void frmEstadisticaExpenCobradasMensualEdificio_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Facturas.ObtenerFacturasMediosPago();

            ReportDataSource ds = new ReportDataSource("DatosEstadFacturasMediosPago", tabla);

            estadFactXMedioPago.LocalReport.DataSources.Clear();
            estadFactXMedioPago.LocalReport.DataSources.Add(ds);
            this.estadFactXMedioPago.RefreshReport();
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
                CargarEstadisticaCompleta();
                estadFactXMedioPago.RefreshReport();
                LimpiarFiltros();
            }
            else
            {
                CargarEstadistica(txtFechaDesde.Text, txtFechaHasta.Text);
                estadFactXMedioPago.RefreshReport();
                LimpiarFiltros();
            }
        }
        private void CargarEstadistica(string desde, string hasta)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Facturas.ObtenerFacturasMediosPagoPorFecha(desde, hasta);

            ReportDataSource ds = new ReportDataSource("DatosEstadFacturasMediosPago", tabla);

            estadFactXMedioPago.LocalReport.DataSources.Clear();
            estadFactXMedioPago.LocalReport.DataSources.Add(ds);
            estadFactXMedioPago.Refresh();
        }
        private void LimpiarFiltros()
        {
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            chkTodas.Checked = false;
        }
        private void CargarEstadisticaCompleta()
        {
            DataTable tabla = new DataTable();
            tabla = AD_Facturas.ObtenerFacturasMediosPago();

            ReportDataSource ds = new ReportDataSource("DatosEstadFacturasMediosPago", tabla);

            estadFactXMedioPago.LocalReport.DataSources.Clear();
            estadFactXMedioPago.LocalReport.DataSources.Add(ds);
            estadFactXMedioPago.Refresh();
        }
    }
   }



