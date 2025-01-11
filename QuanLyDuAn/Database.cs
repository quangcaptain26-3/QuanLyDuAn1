using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn
{
    internal class Database
    {
        private static string sqlConnection =
            @"Data Source=PHAMMINHQUANG;Initial Catalog=QuanLyDuAn;Integrated Security=True;TrustServerCertificate=True";

        public static DataTable Query(string sql)
        {
            SqlConnection connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static DataTable Query(string sql, Dictionary<string, object> dictionary)
        {
            SqlConnection connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            foreach (string key in dictionary.Keys)
            {
                adapter.SelectCommand.Parameters.AddWithValue(key, dictionary[key]);
            }
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void Execute(string sql)
        {
            SqlConnection connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void Execute(string sql, Dictionary<string, object> dictionary)
        {
            SqlConnection connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            foreach (string key in dictionary.Keys)
            {
                command.Parameters.AddWithValue(key, dictionary[key]);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
