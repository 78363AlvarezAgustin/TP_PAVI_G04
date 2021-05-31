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
    public class AD_Expensas
    {
        public static bool AgregarExpensa(Expensas expe)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO expensas (id_edificio, mes, año, importe) VALUES (@id_edificio, @mes, @año, @importe)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_edificio", (expe.IdDeEdificio));
                cmd.Parameters.AddWithValue("@mes", expe.mesExpensa);
                cmd.Parameters.AddWithValue("@año", expe.anoExpensa);
                cmd.Parameters.AddWithValue("@importe", expe.importeExpensa);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                throw;
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerExpensas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM expensas";

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
            catch (Exception)
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
