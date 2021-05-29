using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.AccesoADatos.Transacciones
{
    public class AD_Facturas
    {
        public static int ObtenerUltimoNumFactura()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT MAX(nro_factura) FROM facturas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
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

        //public static bool AltaNuevaFactura(int idCurso, string nombreCurso, string descripcionCurso, int idCarrera, List<int> listaIdsAlumnos)
        public static bool AltaNuevaFactura(int idFactura, float totalComision, int medioPago, List<int> listaIdsClientes, List<int> listaIdsPropiedades, List<int> listaIdsDueños)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Insert into facturas values(@fecha,@total_comision,@idMedioPago)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@total_comision", totalComision);
                cmd.Parameters.AddWithValue("@idMedioPago", medioPago);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaDeFactura");
                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                foreach (var idCliente in listaIdsClientes)
                {
                    string consultaFacturaXCliente = "INSERT INTO clientes_x_factura values(@nroDocCliente,@tipoDocCliente,@nroFactura)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nroDocCliente", idCliente);
                    cmd.Parameters.AddWithValue("@tipoDocCliente", 1);
                    cmd.Parameters.AddWithValue("@nroFactura", idFactura);

                    cmd.CommandText = consultaFacturaXCliente;
                    cmd.ExecuteNonQuery();
                }

                foreach (var idPropiedad in listaIdsPropiedades)
                {
                    string consultaFacturaXCliente = "INSERT INTO propiedades_x_factura values(@desigCatastral,@nroFactura)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@desigCatastral", idPropiedad);
                    cmd.Parameters.AddWithValue("@nroFactura", idFactura);

                    cmd.CommandText = consultaFacturaXCliente;
                    cmd.ExecuteNonQuery();
                }

                foreach (var idDueño in listaIdsDueños)
                {
                    string consultaFacturaXCliente = "INSERT INTO dueños_x_factura values(@nroDocDueño,@tipoDocDueño,@nroFactura)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nroDocDueño", idDueño);
                    cmd.Parameters.AddWithValue("@tipoDocDueño", 1);
                    cmd.Parameters.AddWithValue("@nroFactura", idFactura);

                    cmd.CommandText = consultaFacturaXCliente;
                    cmd.ExecuteNonQuery();
                }

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


        public static DataTable ObtenerListadoFacturas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM facturas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

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
    }
}
