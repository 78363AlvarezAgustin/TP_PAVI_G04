using Inmobiliaria.AccesoADatos;
using Inmobiliaria.AccesoADatos.Transacciones;
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

namespace Inmobiliaria.Formularios.FrmEstadisticas
{
    public partial class frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad : Form
    {
        public frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad()
        {
            InitializeComponent();
            CargarGrillaPropiedades();
            limpiarCampos();


        }

        private void frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        private void CargarGrillaPropiedades()
        {
            try
            {
                grillaPropiedades.DataSource = AD_Propiedades.ObtenerPropiedades();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla!");
                throw;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            if (rdMensual.Checked || rdAnual.Checked || rdTotal.Checked || chkOtro.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = CalcularImporteEnPublicidades();


                ReportDataSource ds = new ReportDataSource("InformeEstadisticaGastoPublicidades", tabla); //crear data set


                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);//agregar data set
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar en que cantidad de dias desea saber los gastos publicitarios");
            }
        }

        private void grillaPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaPropiedades.Rows[indice];

            int desigCatastral = int.Parse(filaSeleccionada.Cells["DesignacionCatastral"].Value.ToString());

            Propiedad p = AD_Propiedades.ObtenerPropiedadPorDesigCatastral(desigCatastral);

            CargarPropiedad(p);
            btnReporte.Enabled = true;

        }
        private void CargarPropiedad(Propiedad p)
        {
            txtDesigCatastral.Text = p.DesignacionCatastralPropiedad.ToString();
            txtCalle.Text=p.CallePropiedad;
            DataTable tipoProp = AD_TiposPropiedades.ObtenerTiposPropiedadesXid(p.IdTipoPropPropiedad);
            txtTipoPropiedad.Text = tipoProp.Rows[0][1].ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDesigCat.Text.Equals(""))
            {
                MessageBox.Show("Selecciona una Designacion Catastral para Buscar", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesigCat.Focus();
            }
            else
            {
                grillaPropiedades.DataSource = AD_Propiedades.GetPropiedadesPorDesigCatastral(int.Parse(txtDesigCat.Text));
                btnReporte.Enabled = true;
                if (grillaPropiedades.Rows.Count == 0)
                {
                    btnReporte.Enabled = false;
                    MessageBox.Show("No se encontraron resultados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtDesigCat.Focus();
            limpiarCampos();

        }

        private void btnCargarGrillaCompleta_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            CargarGrillaPropiedades();
            txtDesigCat.Text = "";
        }

        private int CalcularImporte(DataTable publicidades)
        {
            int total = 0;
            //int i = 0; i < 3; i++
            for (int i=0; i<publicidades.Rows.Count;i++)
            {
                total = total + Int32.Parse(publicidades.Rows[i][4].ToString());
            }
            return total;
        }

        private DataTable CalcularImporteEnPublicidades()
        {
            DataTable res = CrearTablaEstadistica();




            DateTime hoy = DateTime.Today;
            if(rdMensual.Checked || rdAnual.Checked || rdTotal.Checked || chkOtro.Checked)
            {
                if (rdMensual.Checked)
                {
                    DateTime mensual = hoy.AddDays(-30);
                    DataTable tabla = AD_Publicidad.ObtenerPublicidadesXFechayDesig(mensual.ToString(), hoy.ToString(), txtDesigCatastral.Text);
                    int total = CalcularImporte(tabla);
                    res = AddRowEstadistica(res, "30 Dias", total);

                }
                if (rdAnual.Checked)
                {
                    DateTime anual = hoy.AddDays(-365);
                    DataTable tabla = AD_Publicidad.ObtenerPublicidadesXFechayDesig(anual.ToString(), hoy.ToString(), txtDesigCatastral.Text);
                    int total = CalcularImporte(tabla);
                    res = AddRowEstadistica(res, "365 Dias", total);

                }
                if (rdTotal.Checked)
                {
                    DateTime tot = hoy.AddYears(-50);
                    DataTable tabla = AD_Publicidad.ObtenerPublicidadesXFechayDesig(tot.ToString(), hoy.ToString(), txtDesigCatastral.Text);
                    int total = CalcularImporte(tabla);
                    res = AddRowEstadistica(res, "Inicio de los tiempos", total);


                }
                if (chkOtro.Checked)
                {
                    if (txtDiasOtro.Text != "")
                    {
                        DateTime diasSelect = hoy.AddDays(int.Parse(txtDiasOtro.Text)*-1);
                        DataTable tabla = AD_Publicidad.ObtenerPublicidadesXFechayDesig(diasSelect.ToString(), hoy.ToString(), txtDesigCatastral.Text);
                        int total = CalcularImporte(tabla);
                        res = AddRowEstadistica(res, (txtDiasOtro.Text + " Dias"), total);
                    }
                    else
                    {
                        MessageBox.Show("Se debe completar el campo de cantidad de dias para continuar");
                        txtDiasOtro.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar en que cantidad de dias desea saber los gastos publicitarios");
            }
             



            return res;
            
        }
        private DataTable AddRowEstadistica(DataTable res, string rango, int gasto)
        {
            DataRow drow = res.NewRow();
            drow["GastoPublicitario"] = gasto;
            drow["RangoTiempo"] = rango;

            res.Rows.Add(drow);

            return res;
        }

        private DataTable CrearTablaEstadistica()
        {
            DataTable res = new DataTable();
            // DataColumn RangoTiempo = new DataColumn();
            //DataColumn GastoPublicitario = new DataColumn();
            //res.Columns.Add(RangoTiempo);
            //res.Columns.Add(GastoPublicitario);
            res.Columns.Add("RangoTiempo", typeof(String));
            res.Columns.Add("GastoPublicitario", typeof(int));

            return res;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


            reportViewer1.LocalReport.Refresh();

        }
        private void limpiarCampos()
        {
            txtCalle.Text = "";
            txtDesigCat.Text = "";
            txtDesigCatastral.Text = "";
            txtDiasOtro.Text = "";
            txtTipoPropiedad.Text = "";
            rdAnual.Checked = false;
            rdMensual.Checked = false;
            rdTotal.Checked = false;
            chkOtro.Checked = false;
            txtDiasOtro.Enabled = false;
        }

        private void chkOtro_CheckedChanged(object sender, EventArgs e)
        {
            txtDiasOtro.Enabled = true;
        }

    }
}
