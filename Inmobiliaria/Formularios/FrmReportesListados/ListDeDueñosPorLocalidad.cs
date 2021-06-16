using Inmobiliaria.AccesoADatos;
using Inmobiliaria.Entidades;
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
    public partial class ListDeDueñosPorLocalidad : Form
    {
        public ListDeDueñosPorLocalidad()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void ListDeDueñosPorLocalidad_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void CargarGrilla()
        {
            try
            {
                gdrLocalidades.DataSource = AD_Localidades.ObtenerLocalidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener localidades");
            }

        }
        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtDep.Text = "";
            txtNomLoc.Text = "";
            btnReporte.Enabled = false;
        }


        private void CargarCampos(Localidades loc)
        {
            txtId.Text = loc.IdLocalidad.ToString();
            txtNomLoc.Text = loc.NombreLocalidad;
            txtDep.Text = loc.IdDepartamentoLocalidad.ToString();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            btnReporte.Enabled = false;
            GenerarReporteDueñosxLocalidad(txtId.Text);
            LimpiarCampos();


        }

        private void gdrLocalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrLocalidades.Rows[indice];//crea obj tipo fila y asigna la fila del indice
            string id = filaSeleccionda.Cells["IdLocal"].Value.ToString();//devolver valor de celda "Documento"
            Localidades loc = AD_Localidades.ObtenerLocalidad(id);

            CargarCampos(loc);
            btnReporte.Enabled = true;
        }
        private void GenerarReporteDueñosxLocalidad(string idLocalidad)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Barrio.ObtenerDueñosXLocalidad(idLocalidad);

            if (tabla.Rows.Count > 0)
            {
                ReportDataSource ds = new ReportDataSource("DataSetDueñosXLocalidades", tabla);

                reportViewer1.LocalReport.ReportEmbeddedResource = "Inmobiliaria.Formularios.FrmReportesListados.InformeDueñosXLocalidades.rdlc";





                // MessageBox.Show(tabla.Rows.Count.ToString());





                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);//agregar data set


                reportViewer1.RefreshReport();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se encuentran registros de Dueños en esa Localidad");
            }




        }
    }
}
