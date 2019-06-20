using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System;

namespace WebApplication.Models
{
    public class DBContext
    {

        public static List<Cpe> ConsultaCpeAnulaciones(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> lista = null;
            Cpe cpeTmp = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["suite-test"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string cmdText = "VER_BAJAS_FRP";
                    using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@empresa", empresa);
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechafinal", fechaFinal);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lista = new List<Cpe>();
                            while (reader.Read())
                            {
                                cpeTmp = new Cpe();
                                    cpeTmp.RUC = reader["RUC"].ToString();
                                    cpeTmp.Comprobante = reader["COMPROBANTE"].ToString();
                                    cpeTmp.Serie = reader["SERIE"].ToString();
                                    cpeTmp.Correlativo = reader["CORRELATIVO"].ToString();
                                    cpeTmp.FechaEmision = reader["FECHA_EMISION"].ToString();
                                    cpeTmp.FechaCarga = reader["FECHA_CARGA"].ToString();
                                    cpeTmp.Estado = reader["ESTADO"].ToString();
                                    cpeTmp.CodigoEmpresa = reader["NUMERO_EMPRESA"].ToString();
                                    cpeTmp.Mensaje = reader["MENSAJE"].ToString();
                                lista.Add(cpeTmp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }

        public static List<Cpe> consultaCpeBoletasAnulaciones(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> lista = null;
            Cpe cpeTmp = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["suite-test"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string cmdText = "VER_BAJAS_RB";
                    using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@empresa", empresa);
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechafinal", fechaFinal);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lista = new List<Cpe>();
                            while (reader.Read())
                            {
                                cpeTmp = new Cpe();
                                    cpeTmp.RUC = reader["RUC"].ToString();
                                    cpeTmp.Comprobante = reader["COMPROBANTE"].ToString();
                                    cpeTmp.Serie = reader["SERIE"].ToString();
                                    cpeTmp.Correlativo = reader["CORRELATIVO"].ToString();
                                    cpeTmp.FechaEmision = reader["FECHA_EMISION"].ToString();
                                    cpeTmp.FechaCarga = reader["FECHA_CARGA"].ToString();
                                    cpeTmp.Estado = reader["ESTADO"].ToString();
                                    cpeTmp.CodigoEmpresa = reader["NUMERO_EMPRESA"].ToString();
                                    cpeTmp.Mensaje = reader["MENSAJE"].ToString();
                                lista.Add(cpeTmp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }

        public static List<Cpe> consultaCpeRetePerceAnulaciones(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> lista = null;
            Cpe cpeTmp = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["suite-test"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string cmdText = "VER_BAJAS_RP";
                    using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@empresa", empresa);
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechafinal", fechaFinal);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lista = new List<Cpe>();
                            while (reader.Read())
                            {
                                cpeTmp = new Cpe();
                                cpeTmp.RUC = reader["RUC"].ToString();
                                cpeTmp.Comprobante = reader["COMPROBANTE"].ToString();
                                cpeTmp.Serie = reader["SERIE"].ToString();
                                cpeTmp.Correlativo = reader["CORRELATIVO"].ToString();
                                cpeTmp.FechaEmision = reader["FECHA_EMISION"].ToString();
                                cpeTmp.FechaCarga = reader["FECHA_CARGA"].ToString();
                                cpeTmp.Estado = reader["ESTADO"].ToString();
                                cpeTmp.CodigoEmpresa = reader["NUMERO_EMPRESA"].ToString();
                                cpeTmp.Mensaje = reader["MENSAJE"].ToString();
                                lista.Add(cpeTmp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }

        public static List<Empresa> consultaEmpresas()
        {
            List<Empresa> lista = null;
            Empresa empresaTmp = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["suite-test"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string cmdText = "VER_EMPRESAS";
                    using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lista = new List<Empresa>();
                            while (reader.Read())
                            {
                                empresaTmp = new Empresa();
                                    empresaTmp.nombre = reader["NOMBRE"].ToString();
                                    empresaTmp.codiEmex = reader["CODIEMEX"].ToString();
                                lista.Add(empresaTmp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }
    }
}