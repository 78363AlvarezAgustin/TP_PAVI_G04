using Inmobiliaria.Formularios;
using Inmobiliaria.Formularios.FrmEstadisticas;
using Inmobiliaria.Formularios.FrmReportesListados;
using Inmobiliaria.Formularios.FrmTransacciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ABM_empleados ventana = new frm_ABM_empleados();
            ventana.ShowDialog();
        }

        private void ABMDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroDepartamentos ventana = new frmFiltroDepartamentos();
            ventana.ShowDialog();
        }


        private void registrarEliminarPropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroPropiedades ventana = new frmFiltroPropiedades();
            ventana.ShowDialog();
        }

        private void aBMEscribanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroEscribanos ventana = new frmFiltroEscribanos();
            ventana.ShowDialog();
        }

        private void aBMLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroLocalidades ventana = new frmFiltroLocalidades();
            ventana.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aBMMonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroMoneda ventana = new frmFiltroMoneda();
            ventana.ShowDialog();
        }

        private void aBMEncExpensasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroEncExpensas ventana = new frmFiltroEncExpensas();
            ventana.ShowDialog();
        }

        private void aBMBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroBarrios ventana = new frmFiltroBarrios();
            ventana.ShowDialog();
        }

        private void aBMDueñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroDueños ventana = new frmFiltroDueños();
            ventana.ShowDialog();
        }

        private void aBMEdificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroEdificios ventana = new frmFiltroEdificios();
            ventana.ShowDialog();
        }

        private void aBMTIpoDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMTipoDocumento ventana = new frmABMTipoDocumento();
            ventana.ShowDialog();
        }

        private void aBMProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroProveedores ventana = new frmFiltroProveedores();
            ventana.ShowDialog();
        }

        private void aBMProvinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroProvincias ventana = new frmFiltroProvincias();
            ventana.ShowDialog();
        }

        private void aBMDeptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroDeptos ventana = new frmFiltroDeptos();
            ventana.ShowDialog();
        }

        private void aBMMedioPublicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMMediosPublic ventana = new frmABMMediosPublic();
            ventana.ShowDialog();
        }

        private void aBMTipoPropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMTipoProp ventana = new frmABMTipoProp();
            ventana.ShowDialog();
        }

        private void aBMMediosPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroMedioPago ventana = new frmFiltroMedioPago();
            ventana.ShowDialog();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroFactura ventana = new frmRegistroFactura();
            ventana.ShowDialog();
        }

        private void registrarReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroRecibo ventana = new frmRegistroRecibo();
            ventana.ShowDialog();
        }

        private void registrarPublicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaPublicidad ventana = new frmAltaPublicidad();
            ventana.ShowDialog();
        }

        private void registrarClienteInteresadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarPropiedadInteresParaClientes ventana = new frmRegistrarPropiedadInteresParaClientes();
            ventana.ShowDialog();
        }

        private void registrarDueñoPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDueñosXPropiedad ventana = new frmAltaDueñosXPropiedad();
            ventana.ShowDialog();
        }

        private void registrarExpensasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroExpensas ventana = new frmRegistroExpensas();
            ventana.ShowDialog();
        }

        private void registrarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroGastos ventana = new frmRegistroGastos();
            ventana.ShowDialog();
        }

        private void listEmpleadosPorPatronApeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEmpleadosPorPatronApe ventana = new ListEmpleadosPorPatronApe();
            ventana.ShowDialog();
        }

        private void reporteDeEmpleadosPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepEmpleadosPorBarrio ventana = new RepEmpleadosPorBarrio();
            ventana.ShowDialog();
        }

        private void listadoDeClientesPorLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListClientesPorLocalidad ventana = new ListClientesPorLocalidad();
            ventana.ShowDialog();
        }

        private void listadoDeDueñosPorLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDeDueñosPorLocalidad ventana = new ListDeDueñosPorLocalidad();
            ventana.ShowDialog();
        }

        private void repPublicRealizadasEnUnRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepDePublicidadesEnRangoDeFechas ventana = new RepDePublicidadesEnRangoDeFechas();
            ventana.ShowDialog();
        }

        private void repDeFacturasRealizadasEnUnRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepDeFacturasEnRangoDeFechas ventana = new RepDeFacturasEnRangoDeFechas();
            ventana.ShowDialog();
        }

        private void listadoDeRecibosGeneradosEnUnRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDeRecibosEnRangoDeFechas ventana = new ListDeRecibosEnRangoDeFechas();
            ventana.ShowDialog();
        }

        private void listadoDeEdificiosPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDeEdificiosPorBarrio ventana = new ListDeEdificiosPorBarrio();
            ventana.ShowDialog();
        }

        private void listadoDePropiedadesPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDePropiedadesPorTipo ventana = new ListDePropiedadesPorTipo();
            ventana.ShowDialog();
        }

        private void listadoDeDepartamentosPorEncargadoDeExpensasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDeDeptosPorEncDeExpensas ventana = new ListDeDeptosPorEncDeExpensas();
            ventana.ShowDialog();
        }

        private void reporteDeExpensasMensualesPorEdificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepDeExpensasMensualesPorEdif ventana = new RepDeExpensasMensualesPorEdif();
            ventana.ShowDialog();
        }

        private void empleadosPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaEmpleadosPorBarrio ventana = new frmEstadisticaEmpleadosPorBarrio();
            ventana.ShowDialog();
        }

        private void importeTotalDeComisionesMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaDeImporteTotalDeComisionesMensuales ventana = new frmEstadisticaDeImporteTotalDeComisionesMensuales();
            ventana.ShowDialog();
        }

        private void importesDeRecibosRealizadasPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaImporteDeReciboRealizadaPorMes ventana = new frmEstadisticaImporteDeReciboRealizadaPorMes();
            ventana.ShowDialog();
        }

        private void expensasCobradasMensualmentePorEdificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaExpenCobradasMensualEdificio ventana = new frmEstadisticaExpenCobradasMensualEdificio();
            ventana.ShowDialog();
        }

        private void gastosMensualesPorCadaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaGastosDeUnMesPorCadaProveedor ventana = new frmEstadisticaGastosDeUnMesPorCadaProveedor();
            ventana.ShowDialog();
        }

        private void importeTotalGastadoEnPublicidadPorPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad ventana = new frmEstadisticaImporteTotalGastadoEnPublicidadPorPropiedad();
            ventana.ShowDialog();
        }

        private void importeTotalGastadoEnPublicidadPorIdDeMediosPublicitariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaImporteTotalGastadoEnPublicidPorIdDeMedioPublicitario ventana = new frmEstadisticaImporteTotalGastadoEnPublicidPorIdDeMedioPublicitario();
            ventana.ShowDialog();
        }
    }
}
