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
    public class AD_Barrio
    {
        public static Barrios ObtenerBarrio(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Barrios bar = new Barrios();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM barrios where id_barrio like @id_barrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_barrio", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    bar.IdBarrio = int.Parse(dr["id_barrio"].ToString());
                    bar.NombreBarrio = dr["n_barrio"].ToString();
                    bar.IdLocalidadBarrio = int.Parse(dr["id_localidad"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw;

            }
            finally
            {
                cn.Close();
            }

            return bar;

        }


        public static DataTable ObtenerBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT id_barrio, n_barrio, n_localidad FROM barrios INNER JOIN localidades ON barrios.id_localidad = localidades.id_localidad";

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

        public static bool AgregarBarrioABD(Barrios bar)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "GetUsuario";
                string consulta = "INSERT INTO barrios (n_barrio, id_localidad) VALUES (@nombre, @idLocalidad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", bar.NombreBarrio);
                cmd.Parameters.AddWithValue("@idLocalidad", bar.IdLocalidadBarrio);
                cmd.CommandType = CommandType.Text;
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


        public static bool ValidarAlRegistrar(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM barrios WHERE n_barrio like @nombreBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBarrio", nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        public static DataTable ObtenerBarrioXNombre(string parametro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT id_barrio, n_barrio, n_localidad FROM barrios INNER JOIN localidades ON barrios.id_localidad = localidades.id_localidad where n_barrio = @barrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@barrio", parametro);
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
   
