using System.Collections.Generic;

namespace WebApplication.Models
{
    public class DBContext
    {

        public static List<Cpe> ConsultaCpeAnulaciones(string empresa)
        {
            //List<Cpe> listaDB = null;
            //Cpe cpeTmp = null;
            //try
            //{
            //    string connectionString = ConfigurationManager.ConnectionStrings["suite-test"].ConnectionString;
            //    using (SqlConnection connection = new SqlConnection(connectionString)) {
            //        string cmdText = "VER_BAJAS_FRP";
            //        using (SqlCommand cmd = new SqlCommand(cmdText, connection)) {
            //                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@empresa", "esuiteDIGIFLOW");
            //                cmd.Parameters.AddWithValue("@fechaInicio", "2019-01-01");
            //                cmd.Parameters.AddWithValue("@fechafinal", "2019-01-31");
            //            connection.Open();
            //            using (SqlDataReader reader = cmd.ExecuteReader()) {
            //                listaDB = new List<Cpe>();
            //                while (reader.Read())
            //                {
            //                    cpeTmp = new Cpe();
            //                    //reader["aaaaaaaaaaa"].ToString()
            //                        cpeTmp.RUC = reader["RUC"].ToString();
            //                        cpeTmp.Comprobante = reader["COMPROBANTE"].ToString();
            //                        cpeTmp.Serie = reader["SERIE"].ToString();
            //                        cpeTmp.Correlativo = reader["CORRELATIVO"].ToString();
            //                        cpeTmp.FechaEmision = reader["FECHA_EMISION"].ToString();
            //                        cpeTmp.FechaCarga = reader["FECHA_CARGA"].ToString();
            //                        //reader["MOTIVO_ANULACIÓN"].ToString();
            //                        cpeTmp.Estado = reader["ESTADO"].ToString();
            //                        cpeTmp.CodigoEmpresa = reader["NUMERO_EMPRESA"].ToString();
            //                        cpeTmp.Mensaje = reader["MENSAJE"].ToString();
            //                    listaDB.Add(cpeTmp);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex )
            //{
            //    throw ex;
            //}

            List<Cpe> lista = new List<Cpe>();
            Cpe cpe = new Cpe();
            cpe.RUC = "20510675411";
            cpe.Comprobante = "00002";
            cpe.Serie = "F001";
            cpe.Correlativo = "2";
            cpe.FechaEmision = "13-06-2019";
            cpe.FechaCarga = "14-06-2019";
            cpe.Estado = "DOK";
            cpe.CodigoEmpresa = "DGF";
            cpe.Mensaje = "Sin observaciones";
            lista.Add(cpe);

            cpe = new Cpe();
            cpe.RUC = "20010675411";
            cpe.Comprobante = "00003";
            cpe.Serie = "F001";
            cpe.Correlativo = "3";
            cpe.FechaEmision = "13-06-2019";
            cpe.FechaCarga = "14-06-2019";
            cpe.Estado = "DOK";
            cpe.CodigoEmpresa = "DGF";
            cpe.Mensaje = "Sin observaciones";
            lista.Add(cpe);

            return lista;
        }

        public static List<Cpe> consultaCpeBoletasAnulaciones()
        {
            List<Cpe> lista = new List<Cpe>();
                Cpe cpe = new Cpe();
                    cpe.RUC = "20510675411";
                    cpe.Comprobante = "00000004";
                    cpe.Serie = "B001";
                    cpe.Correlativo = "4";
                    cpe.FechaEmision = "13-06-2019";
                    cpe.FechaCarga = "14-06-2019";
                    cpe.Estado = "DOK";
                    cpe.CodigoEmpresa = "DGF";
                    cpe.Mensaje = "Sin observaciones";
                lista.Add(cpe);

                cpe = new Cpe();
                    cpe.RUC = "20010675411";
                    cpe.Comprobante = "00000005";
                    cpe.Serie = "B001";
                    cpe.Correlativo = "5";
                    cpe.FechaEmision = "13-06-2019";
                    cpe.FechaCarga = "14-06-2019";
                    cpe.Estado = "DOK";
                    cpe.CodigoEmpresa = "DGF";
                    cpe.Mensaje = "Sin observaciones";
                lista.Add(cpe);
            return lista;
        }

        public static List<Cpe> consultaCpeRetePerceAnulaciones()
        {
            List<Cpe> lista = new List<Cpe>();
            Cpe cpe = new Cpe();
            cpe.RUC = "20510675411";
            cpe.Comprobante = "00000006";
            cpe.Serie = "R001";
            cpe.Correlativo = "6";
            cpe.FechaEmision = "13-06-2019";
            cpe.FechaCarga = "14-06-2019";
            cpe.Estado = "DOK";
            cpe.CodigoEmpresa = "DGF";
            cpe.Mensaje = "Sin observaciones";
            lista.Add(cpe);

            cpe = new Cpe();
            cpe.RUC = "20010675411";
            cpe.Comprobante = "00000007";
            cpe.Serie = "R001";
            cpe.Correlativo = "7";
            cpe.FechaEmision = "13-06-2019";
            cpe.FechaCarga = "14-06-2019";
            cpe.Estado = "DOK";
            cpe.CodigoEmpresa = "DGF";
            cpe.Mensaje = "Sin observaciones";
            lista.Add(cpe);
            return lista;
        }
    }
}