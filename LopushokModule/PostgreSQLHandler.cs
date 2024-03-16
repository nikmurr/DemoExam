using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace LopushokModule
{
    public class PostgreSQLHandler
    {
        NpgsqlConnection connection;
        public PostgreSQLHandler(string host, string username, string database, string password)
        {
            try
            {
                string connectionParams = $"Host={host}; Database = {database}; Username = {username}; Password = {password};";
                connection = new NpgsqlConnection(connectionParams);
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Произошла ошибка подключения к БД: {ex.Message}", "Ошибка!", MessageBoxButtons.OK);
                throw;
            }
        }

        //public DataTable SelectProducts()
        //{
        //    string query = "SELECT \"Title\";"
        //}

        public List<UserControl1> RetrieveProducts()
        {
            connection.Open();

            List<UserControl1> cards = new List<UserControl1>();
            string sql = @"SELECT p.""Title"", p.""ArticleNumber"", p.""Image"", p.""MinCostForAgent"", pt.""Title"" as ""ProductTypeTitle""
                               FROM ""Product"" p
                               LEFT JOIN ""ProductType"" pt ON p.""ProductTypeID"" = pt.""ID""";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string title = reader.GetString(reader.GetOrdinal("Title"));
                        string articleNumber = reader.GetString(reader.GetOrdinal("ArticleNumber"));
                        string image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : reader.GetString(reader.GetOrdinal("Image"));
                        decimal minCostForAgent = reader.GetDecimal(reader.GetOrdinal("MinCostForAgent"));
                        string productTypeTitle = reader.IsDBNull(reader.GetOrdinal("ProductTypeTitle")) ? null : reader.GetString(reader.GetOrdinal("ProductTypeTitle"));

                        UserControl1 card = new UserControl1(title, articleNumber, image, minCostForAgent, productTypeTitle);
                        cards.Add(card);
                    }

                    return cards;
                }
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            connection.Open();
            try
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка выполнения запроса: {ex.Message}", "Ошибка!", MessageBoxButtons.OK);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            connection.Open();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка выполнения запроса: {ex.Message}", "Ошибка!", MessageBoxButtons.OK);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }
}
