using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseH2
{
    class DatabaseWrapper
    {
        private readonly string _connectionString;
        public List<Kunder> Kundeliste = new List<Kunder>();
        public List<Biler> BilListe = new List<Biler>();
        public DatabaseWrapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void ExecuteQuery(string query)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void ExecuteReadQuery(string query)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kunder kunde = new Kunder(
                                    reader["Navn"].ToString(),
                                    reader["Efternavn"].ToString(),
                                    Convert.ToInt32(reader["Telefon"]),
                                    reader["City"].ToString(),
                                    reader["Adresse"].ToString());
                                Kundeliste.Add(kunde);
                            }
                            reader.Close();
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExecuteFindCars(string query)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Biler bil = new Biler(
                                    reader["VIN"].ToString(),
                                    reader["Farve"].ToString(),
                                    reader["Mærke"].ToString(),
                                    reader["Model"].ToString(),
                                    Convert.ToInt32(reader["UniqueID"]),
                                    reader["City"].ToString()
                                    );
                                BilListe.Add(bil);
                            }
                            reader.Close();
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
