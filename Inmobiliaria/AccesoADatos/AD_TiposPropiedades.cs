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
    public class AD_TiposPropiedades
    {
        public static DataTable ObtenerTiposPropiedades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetTiposPropiedades";

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
        public static bool EliminarTipoPropiedad(TipoPropiedad tp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteTipoPropiedad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreTipoPropiedad", tp.NombreTipoPropiedad);

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



        public static bool ActualizarTipoPropiedad(TipoPropiedad tp)//********************************************************************
        {

            bool res = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                //cmd.Parameters.AddWithValue("@id", tp.Id);
                cmd.Parameters.AddWithValue("@nombreTipoPropiedad", tp.NombreTipoPropiedad);
                cmd.Parameters.AddWithValue("@descripcion", tp.Descripcion);




                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateTipoPropiedad";

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


        public static bool AgregarTipoPropiedadD(TipoPropiedad tp)
        {
            bool res = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombreTipoPropiedad", tp.NombreTipoPropiedad);
                cmd.Parameters.AddWithValue("@descripcion", tp.Descripcion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertTipoPropiedad";

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
