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
    public class AD_Recibos
    {

        public static DataTable ObtenerRecibos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetRecibos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }
        }


        public static int ObtenerUltimoIdRecibo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetMaxIdRecibo";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int utlimoId = (int)cmd.ExecuteScalar();
                return utlimoId;

            }
            catch (Exception ex)
            {
                return 0;
            }

            finally
            {
                cn.Close();
            }
        }


        public static bool AgregarRecibo(Recibo r)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertRecibo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaCobro", r.FechaCobroRecibo);
                cmd.Parameters.AddWithValue("@importe", r.ImporteRecibo);
                cmd.Parameters.AddWithValue("@mesExpensa", r.MesExpensaRecibo);
                cmd.Parameters.AddWithValue("@añoExpensa", r.AñoExpensaRecibo);
                cmd.Parameters.AddWithValue("@legajoEncargadoExp", r.LegajoEncargadoExpRecibo);
                cmd.Parameters.AddWithValue("@idEdificio", r.IdEdificioRecibo);
                cmd.Parameters.AddWithValue("@piso", r.PisoRecibo);
                cmd.Parameters.AddWithValue("@denominacion", r.DenominacionRecibo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaRecibo");
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
