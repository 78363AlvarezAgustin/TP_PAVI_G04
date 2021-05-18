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
    class AD_MediosPublicidad
    {
        public static DataTable ObtenerListadoMedioPublicitario()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetMedioPublicitario";

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
        public static bool EliminarMedioPublicitario(MedioPublicidad mp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteMedioPublicitario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreMedioPublicitario", mp.NombreMedioPublicitario);

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



        public static bool ActualizarMedioPublicitario(MedioPublicidad mp)//********************************************************************
        {

            bool res = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", mp.Id);
                cmd.Parameters.AddWithValue("@nombreMedioPublicitario", mp.NombreMedioPublicitario);




                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateMedioPublicitario";

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


        public static bool AgregarMedioPublicitario(MedioPublicidad mp)
        {
            bool res = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombreMedioPublicitario", mp.NombreMedioPublicitario);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertMedioPublicitario";

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
