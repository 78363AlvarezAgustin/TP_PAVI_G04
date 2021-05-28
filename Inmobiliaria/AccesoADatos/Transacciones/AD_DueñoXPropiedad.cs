using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.AccesoADatos.Transacciones
{
    public class AD_DueñoXPropiedad
    {




        public static DataTable ObtenerListadoDueñosxPropiedad(int desiCatastral)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desCat", desiCatastral);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDueñosPropiedadesRepeated";

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }





        public static bool AgregarDueñosXPropiedades(int designacionCatastralPropiedad, int numeroDocumentoDueño, int tipoDocumentoDueño)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertDueñosxPropiedad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@designacionCatastral", designacionCatastralPropiedad);
                cmd.Parameters.AddWithValue("@nroDocumento", numeroDocumentoDueño);
                cmd.Parameters.AddWithValue("@tipoDocumento", tipoDocumentoDueño);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaDueñosxPropiedades");
                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                objTransaccion.Commit();
                return true;
            }
            catch (Exception)
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
