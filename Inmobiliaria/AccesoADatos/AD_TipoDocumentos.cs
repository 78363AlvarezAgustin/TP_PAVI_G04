using Inmobiliaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.AccesoADatos
{
    public class AD_TipoDocumentos
    {
        public static DataTable ObtenerListadoTipoDocumentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetTipoDocumentos";

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
        public static bool EliminarTipoDocumento(TipoDeDocumento tDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteTDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombretDoc", tDoc.NombreTipoDocumento);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }



        public static bool ActualizarTipoDocumento(TipoDeDocumento tDoc)//********************************************************************
        {

            bool res = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", tDoc.Id);
                cmd.Parameters.AddWithValue("@nombreTdoc", tDoc.NombreTipoDocumento.Trim());




                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateTipoDocumento";

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return res;
        }


        public static bool AgregarTipoDocumentoBD(TipoDeDocumento tDoc)
        {
            bool res = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombreTdoc", tDoc.NombreTipoDocumento);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertTipoDocumento";

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;



            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return res;

        }



    }
}
