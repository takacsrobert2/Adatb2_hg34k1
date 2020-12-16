using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernKonyvtar_AdatbazisBeadando.Models.Records;
using Oracle.ManagedDataAccess.Client;

namespace ModernKonyvtar_AdatbazisBeadando.Models.Manager
{
    class Konyvek_Tabla
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;User Id=HG34K1;Password=EKE2020;";
            oc.ConnectionString = connectionString;

                return oc;
        }

        public List<Konyvek> Select()
        {
            List<Konyvek> records = new List<Konyvek>();

            OracleConnection oc = new OracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "Select k.cim, k.isbn_azonosito, sz.nev FROM" +
                    "konyvek k INNER JOIN szerzok sz ON sz.id = k.szerzo_id"
            };

            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Konyvek konyv = new Konyvek();
                konyv.Cim = reader["cim"].ToString();
                konyv.Isbn_azonosito = reader["isbn_azonosito"].ToString();
                konyv.Szerzo = reader["nev"].ToString();

                records.Add(konyv);
            }
                oc.Close();

                   return records;
        }

        public int Delete(Konyvek record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM konyvek WHERE isbn_azonosito = :isbn_azonosito"
            };

            OracleParameter isbn_azonositoParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":isbn_azonosito",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Isbn_azonosito
            };
            command.Parameters.Add(isbn_azonositoParameter);

            command.Connection = oc;
            command.Transaction = ot;

            int affectedRows = 0;
            try
            {
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                ot.Rollback();
            }
            oc.Close();
            return affectedRows;
        }

        public int Insert(Konyvek record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_konyvek"

            };

            OracleParameter cimParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":p_cim",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Cim
            };
            command.Parameters.Add(cimParameter);

            OracleParameter szerzoParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":p_szerzo",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Szerzo
            };
            command.Parameters.Add(szerzoParameter);

            OracleParameter kiadoParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":p_kiado",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Kiado
            };
            command.Parameters.Add(kiadoParameter);

            OracleParameter kiadas_eveParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":p_kiadas_eve",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Kiadas_eve
            };
            command.Parameters.Add(kiadas_eveParameter);

            OracleParameter isbn_azonositoParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":p_isbn_azonosito",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Isbn_azonosito
            };

            command.Parameters.Add(isbn_azonositoParameter);

            OracleParameter nyelvParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":p_nyelv",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Nyelv
            };
            command.Parameters.Add(nyelvParameter);

            OracleParameter kategoriaParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":p_kategoria",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Kategoria
            };
            command.Parameters.Add(kategoriaParameter);

            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };

            command.Connection = oc;
            command.Transaction = ot;

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
                ot.Commit();
                return affectedRows;
            }
            catch (Exception)
            {
                ot.Rollback();
                return 0;
            }
        }

        public bool CheckIsbn_azonosito(string isbn_azonosito)
        {
            OracleConnection oc = new OracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_isbn_azonosito"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter isbn_azonositoParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_isbn_azonosito",
                Direction = System.Data.ParameterDirection.Input,
                Value = isbn_azonosito
            };
            command.Parameters.Add(isbn_azonositoParameter);

            command.Connection = oc;
            try
            {
                int successful = int.Parse(correct.Value.ToString());

                return successful != 0;
            }
            catch (Exception)
            {

                return false;
            }

        }
        
    }
}
