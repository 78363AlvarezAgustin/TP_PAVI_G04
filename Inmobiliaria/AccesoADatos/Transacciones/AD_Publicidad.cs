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
    public class AD_Publicidad
    {
        public static bool AgregarPublicidad(Publicidad publi)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertPublicidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", (publi.FechaPubli));
                cmd.Parameters.AddWithValue("@desigCat", publi.DesigCatastralPubli);
                cmd.Parameters.AddWithValue("@idMedio", publi.IdMedioPubli);
                cmd.Parameters.AddWithValue("@descrip", publi.DescripcionPubli);
                cmd.Parameters.AddWithValue("@costo", publi.CostoPubli);
                cmd.Parameters.AddWithValue("@idSeccion", publi.IdSeccionPubli);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaDeCurso");
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
        public static DataTable ObtenerPublicidades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetPublicidades";

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
    }
}
