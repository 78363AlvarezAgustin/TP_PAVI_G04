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
    public partial class ListDeDeptosPorEncDeExpensas : Form
    {
        public ListDeDeptosPorEncDeExpensas()
        {
            InitializeComponent();
        }

        private void ListDeDeptosPorEncDeExpensas_Load(object sender, EventArgs e)
        {

            this.RVExpensas.RefreshReport();
        }

        private void RVExpensas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Departamentos.ObtenerDepartamentos();
            ReportDataSource ds = new ReportDataSource("DptosXEnc", tabla);

            RVExpensas.LocalReport.DataSources.Clear();
            RVExpensas.LocalReport.DataSources.Add(ds);
            RVExpensas.LocalReport.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLegajo.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese algun legajo");
                    DataTable tabla1 = new DataTable();
                    tabla1 = AD_Departamentos.ObtenerDepartamentos();
                    ReportDataSource ds = new ReportDataSource("DptosXEnc", tabla1);
                    RVExpensas.LocalReport.DataSources.Clear();
                    RVExpensas.LocalReport.DataSources.Add(ds);
                    RVExpensas.RefreshReport();
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = AD_Departamentos.ObtenerDptosPorLegajo(Convert.ToInt32(txtLegajo.Text));
                    if (tabla.Rows.Count > 0)
                    {
                        ReportDataSource ds = new ReportDataSource("DptosXEnc", tabla);
                        RVExpensas.LocalReport.DataSources.Clear();
                        RVExpensas.LocalReport.DataSources.Add(ds);
                        RVExpensas.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Departamento Inexistente");
                        txtLegajo.Focus();
                        DataTable tabla1 = new DataTable();
                        tabla1 = AD_Departamentos.ObtenerDepartamentos();
                        ReportDataSource ds = new ReportDataSource("DptosXEnc", tabla1);
                        RVExpensas.LocalReport.DataSources.Clear();
                        RVExpensas.LocalReport.DataSources.Add(ds);
                        RVExpensas.RefreshReport();
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
