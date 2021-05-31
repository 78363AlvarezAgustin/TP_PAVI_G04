using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.AccesoADatos.Transacciones
{
    public class AD_PropiedadInteresClientes
    {

        public static bool AgregarClientesXPropiedades(int numeroDocumentoCliente, int tipoDocumentoCliente, int designacionCatastralPropiedad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertClientesxPropiedad";
                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@nroDocumento", numeroDocumentoCliente);
                cmd.Parameters.AddWithValue("@tipoDocumento", tipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@designacionCatastral", designacionCatastralPropiedad);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();


                //LO NARANJA ESTA BIEN?
                objTransaccion = cn.BeginTransaction("RegPropIntPClientes");
                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                objTransaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                objTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
