using Inmobiliaria.AccesoADatos;
using Inmobiliaria.AccesoADatos.Transacciones;
using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Formularios.FrmTransacciones
{
    public partial class frmRegistroRecibo : Form
    {
        public frmRegistroRecibo()
        {
            InitializeComponent();
        }

        private void frmRegistroRecibo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboEncargadoExp();
            CargarGrillaDepartamentos();
            CargarGrillaRecibos();
        }


        //private void SetUltimoIdRecibo()
        //{
        //    int ultimoId = AD_Recibos.ObtenerUltimoIdRecibo();

        //    if (ultimoId == 0)
        //    {
        //        MessageBox.Show("Ocurrió un error al acceder a los datos de la provincia", "Error");
        //    }
        //    else
        //    {
        //        ultimoId++;
        //        txtIdRecibo.Text = ultimoId.ToString();
        //    }
        //}


        private void LimpiarCampos()
        {
            txtIdRecibo.Text = (AD_Recibos.ObtenerUltimoIdRecibo() + 1).ToString();
            txtFechaCobro.Text = "";
            txtImporte.Text = "";
            txtMesExpensa.Text = "";
            txtAñoExpensa.Text = "";
            cmbEncargadoExp.SelectedIndex = -1;
            txtIdEdificio.Text = "";
            txtPiso.Text = "";
            txtDenominacion.Text = "";
        }


        private void CargarComboEncargadoExp()
        {
            try
            {
                cmbEncargadoExp.DataSource = AD_EncExpensas.ObtenerEncExpensas();
                cmbEncargadoExp.DisplayMember = "apellido_encargado";
                cmbEncargadoExp.ValueMember = "legajo_encargado";
                cmbEncargadoExp.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los encargados de expensas!");
                throw;
            }
        }


        private void CargarGrillaDepartamentos()
        {
            try
            {
                grillaDepartamentos.DataSource = AD_Departamentos.ObtenerDepartamentos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla de Departamentos!");
                throw;
            }
        }

        private void grillaDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaDepartamentos.Rows[indice];

            int encargadoExp = int.Parse(filaSeleccionada.Cells["LegajoEncargadoExp"].Value.ToString());
            int idEdificio = int.Parse(filaSeleccionada.Cells["IdEdificio"].Value.ToString());
            int piso = int.Parse(filaSeleccionada.Cells["Piso"].Value.ToString());
            string denominacion = filaSeleccionada.Cells["Denominacion"].Value.ToString();

            cmbEncargadoExp.SelectedValue = encargadoExp;
            txtIdEdificio.Text = idEdificio.ToString();
            txtPiso.Text = piso.ToString();
            txtDenominacion.Text = denominacion.ToString();
        }


        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdRecibo.Text.Equals("") || txtFechaCobro.Text.Equals("") || txtImporte.Text.Equals("") || txtMesExpensa.Text.Equals("") || txtAñoExpensa.Text.Equals("") || cmbEncargadoExp.SelectedIndex.Equals(-1) || txtIdEdificio.Text.Equals("") || txtPiso.Text.Equals("") || txtDenominacion.Text.Equals(""))
            {
                DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Recibo r = ObtenerDatosRecibo();
                bool resultado = AD_Recibos.AgregarRecibo(r);

                if (resultado)
                {
                    MessageBox.Show("Recibo agredado correctamente!", "Informacion");
                    LimpiarCampos();
                    CargarComboEncargadoExp();
                    CargarGrillaDepartamentos();
                    CargarGrillaRecibos();
                }
                else
                {
                    MessageBox.Show("Error al insertar el Recibo!");
                }
            }
        }


        private Recibo ObtenerDatosRecibo()
        {
            Recibo r = new Recibo();

            r.IdRecibo = int.Parse(txtIdRecibo.Text);
            r.FechaCobroRecibo = DateTime.Parse(txtFechaCobro.Text);
            r.ImporteRecibo = int.Parse(txtImporte.Text);
            r.MesExpensaRecibo = int.Parse(txtMesExpensa.Text);
            r.AñoExpensaRecibo = int.Parse(txtAñoExpensa.Text);
            r.LegajoEncargadoExpRecibo = (int)cmbEncargadoExp.SelectedValue;
            r.IdEdificioRecibo = int.Parse(txtIdEdificio.Text);
            r.PisoRecibo = int.Parse(txtPiso.Text);
            r.DenominacionRecibo = txtDenominacion.Text;

            return r;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la transacción?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void CargarGrillaRecibos()
        {
            try
            {
                grillaRecibos.DataSource = AD_Recibos.ObtenerRecibos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla de recibos!");
                throw;
            }
        }
    }
}
