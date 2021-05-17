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
    public class AD_Edificios
    {
        public static DataTable ObtenerListadoEdificios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEdificios";

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

        public static bool AgregarEdificioBD(Edificios ed)
        {
            bool res = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreEdificio", ed.NombreEdificio);
                cmd.Parameters.AddWithValue("@cantidadDptos", ed.CantidadDptosEdificio);
                cmd.Parameters.AddWithValue("@tieneAscensor", ed.TieneAscensorEdificio);
                cmd.Parameters.AddWithValue("@Calle", ed.CalleEdificio);
                cmd.Parameters.AddWithValue("@numeroCalle", ed.NumeroCalleEdificio);
                cmd.Parameters.AddWithValue("@idBarrio", ed.IdBarrioEdificio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertEdificios";

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

        public static Edificios ObtenerEdificio(string nombreEdificio)
        {
            Edificios ed = new Edificios();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "SELECT * FROM edificios where n_edificio like @nombreEdificio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreEdificio", nombreEdificio);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ObtenerEdificio";

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ed.NombreEdificio = dr["n_edificio"].ToString();
                    ed.CantidadDptosEdificio = int.Parse(dr["cantidad_deptos"].ToString());
                    ed.TieneAscensorEdificio = bool.Parse(dr["tiene_ascensor"].ToString());
                    ed.CalleEdificio = dr["calle"].ToString();
                    ed.NumeroCalleEdificio = int.Parse(dr["nro_calle"].ToString());
                    ed.IdBarrioEdificio = int.Parse(dr["id_barrio"].ToString());


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
            return ed;

        }

        public static bool ActualizarEdificio(Edificios ed)//********************************************************************
        {

            bool res = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nombreEdificio", ed.NombreEdificio);
                cmd.Parameters.AddWithValue("@cantidadDptos", ed.CantidadDptosEdificio);
                cmd.Parameters.AddWithValue("@tieneAscensor", ed.TieneAscensorEdificio);
                cmd.Parameters.AddWithValue("@Calle", ed.CalleEdificio);
                cmd.Parameters.AddWithValue("@numeroCalle", ed.NumeroCalleEdificio);
                cmd.Parameters.AddWithValue("@idBarrio", ed.IdBarrioEdificio);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateEdificio";

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

        public static bool ExisteEdificio(string nombreEdificio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetEdificioPorNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreEdificio", nombreEdificio);
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


        public static bool EliminarEdificio(Edificios ed)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DeleteEdificio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreEdificio", ed.NombreEdificio);

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

        public static DataTable GetEdificioPorNombre(string nombreEdificio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetEdificioPorNombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreEdificio", nombreEdificio);
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

