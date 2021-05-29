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
    public class AD_Dueños
    {
        public static DataTable ObtenerListadoDueños()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDueños";

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

        public static DataTable ObtenerTabla(string nombreTabla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM " + nombreTabla;

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




        public static bool AgregarDueñoBD(Dueños du)
        {
            bool res = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NumeroDocumento", du.NumeroDocumentoDueño);
                cmd.Parameters.AddWithValue("@TipoDocumento", du.TipoDocumentoDueño);
                cmd.Parameters.AddWithValue("@NombreDueño", du.NombreDueño);
                cmd.Parameters.AddWithValue("@ApellidoDueño", du.ApellidoDueño);
                cmd.Parameters.AddWithValue("@Calle", du.CalleDueño);
                cmd.Parameters.AddWithValue("@NumeroCalle", du.NumeroCalleDueño);
                cmd.Parameters.AddWithValue("@IdBarrio", du.IdBarrioDueño);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDueños";

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

        public static Dueños ObtenerDueño(int nroDocumento)
        {
            Dueños du = new Dueños();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NumeroDocumento", nroDocumento);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ObtenerDueño";

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {

                    du.NumeroDocumentoDueño = int.Parse(dr["nro_documento"].ToString());
                    du.TipoDocumentoDueño = int.Parse(dr["tipo_documento"].ToString());
                    du.NombreDueño = dr["n_dueño"].ToString();
                    du.ApellidoDueño = dr["apellido_dueño"].ToString();
                    du.CalleDueño = dr["calle"].ToString();
                    du.NumeroCalleDueño = int.Parse(dr["nro_calle"].ToString());
                    du.IdBarrioDueño = int.Parse(dr["id_barrio"].ToString());


                }
                else
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return du;

        }

        public static bool ActualizarDueño(Dueños du)
        {

            //UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;

            bool res = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@NumeroDocumento", du.NumeroDocumentoDueño);
                cmd.Parameters.AddWithValue("@TipoDocumento", du.TipoDocumentoDueño);
                cmd.Parameters.AddWithValue("@NombreDueño", du.NombreDueño);
                cmd.Parameters.AddWithValue("@ApellidoDueño", du.ApellidoDueño);
                cmd.Parameters.AddWithValue("@Calle", du.CalleDueño);
                cmd.Parameters.AddWithValue("@NumeroCalle", du.NumeroCalleDueño);
                cmd.Parameters.AddWithValue("@IdBarrio", du.IdBarrioDueño);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDueño";

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

        public static bool ExisteDueño(int nroDueño)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetDueñosPorDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numeroDocumento", nroDueño);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(tabla);
                int filas = tabla.Rows.Count;
                if (filas == 1)
                {
                    resultado = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public static bool EliminarDueño(Dueños du)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteDueño";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numeroDocumento", du.NumeroDocumentoDueño);

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

        public static DataTable ObtenerDueñoPorDocumento(int nroDocumento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * from dueños where nro_documento like '" + nroDocumento + "'";

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
