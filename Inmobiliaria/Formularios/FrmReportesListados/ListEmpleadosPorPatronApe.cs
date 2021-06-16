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
    public partial class ListEmpleadosPorPatronApe : Form
    {
        public ListEmpleadosPorPatronApe()
        {
            InitializeComponent();
        }

        private void ListEmpleadosPorPatronApe_Load(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Empleados.ObtenerEmpleados();
            ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese algun apellido");
                    DataTable tabla1 = new DataTable();
                    tabla1 = AD_Empleados.ObtenerEmpleados();
                    ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla1);
                    reportViewer2.LocalReport.DataSources.Clear();
                    reportViewer2.LocalReport.DataSources.Add(ds);
                    reportViewer2.RefreshReport();
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = AD_Empleados.ObtenerEmpleadoXApellido(txtApellido.Text.Trim());
                    if (tabla.Rows.Count > 0)
                    {
                        ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);
                        reportViewer2.LocalReport.DataSources.Clear();
                        reportViewer2.LocalReport.DataSources.Add(ds);
                        reportViewer2.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Empleado Inexistente");
                        txtApellido.Focus();
                        DataTable tabla1 = new DataTable();
                        tabla1 = AD_Empleados.ObtenerEmpleados();
                        ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla1);
                        reportViewer2.LocalReport.DataSources.Clear();
                        reportViewer2.LocalReport.DataSources.Add(ds);
                        reportViewer2.RefreshReport();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
