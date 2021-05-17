﻿using Inmobiliaria.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Entidades;

namespace Inmobiliaria
{
    public partial class ABM_TipoDocumentos : Form
    {
        public ABM_TipoDocumentos()
        {
            InitializeComponent();
            txtTipoDocumento.Text = "";
            txtID.Text = "";
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                gdrTiposDocumentos.DataSource = AD_TipoDocumentos.ObtenerListadoTipoDocumentos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener Tipo de Documentos");
            }


        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtTipoDocumento.Text = "";
            txtID.Text = "";
        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            TipoDeDocumento tDoc = new TipoDeDocumento();
            tDoc.NombreTipoDocumento = txtTipoDocumento.Text;



            

            if (txtID.Text.Equals(""))
            {
                if (txtTipoDocumento.Text.Equals(""))
                {
                    DialogResult mensaje = MessageBox.Show("Ingrese todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTipoDocumento.Focus();
                }
                else
                {
                    bool res = AD_TipoDocumentos.AgregarTipoDocumentoBD(tDoc);

                    if (res)
                    {
                        MessageBox.Show("Tipo de Documento agredado correctamente!", "Informacion");
                        txtTipoDocumento.Text = "";
                        txtID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar Tipo de Documento!");
                    }
                }
            }
            else
            {
                tDoc.Id = int.Parse(txtID.Text);
                bool res = AD_TipoDocumentos.ActualizarTipoDocumento(tDoc);
                txtTipoDocumento.Focus();
                MessageBox.Show("Tipo de Documento actualizado correctamente!", "Informacion");
            }
            CargarGrilla();
            txtID.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show("¿Esta seguro que desea cancelar la carga de datos?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aviso == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar el Tipo de Documento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                TipoDeDocumento tDoc = new TipoDeDocumento();
                tDoc.NombreTipoDocumento = txtTipoDocumento.Text;
                bool resultado = AD_TipoDocumentos.EliminarTipoDocumento(tDoc);
                if (resultado)
                {
                    MessageBox.Show("Tipo de Documento eliminado con exito!");
                }
                else
                {
                    MessageBox.Show("Error al eliminar Tipo de Documento!");
                }

            }
            else if (confirmacion == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada!");
            }
            CargarGrilla();
            txtID.Text = "";
        }

        private void gdrTiposDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionda = gdrTiposDocumentos.Rows[indice];
            string documento = filaSeleccionda.Cells["TipodeDocumento"].Value.ToString();
            string id = filaSeleccionda.Cells["ID"].Value.ToString();



            txtTipoDocumento.Text = "";
            txtID.Text = "";
            txtID.Text = id;
            txtTipoDocumento.Text = documento;
        }

        private void ABM_TipoDocumentos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            txtTipoDocumento.Text = "";
            txtID.Text = "";
        }
    }
}
