using Getdata_Mysql.Modal;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System.Configuration;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Getdata_Mysql
{
    public class Program
    {
        public void Getdata()
        {
            string mysqlConnectionString = "server=192.168.0.3;user=visualapp;database=sakila;port=3306;password=visualapp@2023";
            MySqlConnection connection = new MySqlConnection(mysqlConnectionString);
            {
                connection.Open();

                string query = "SELECT * FROM actor";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("actor_id");
                            string firstname = reader.GetString("first_name");
                            string lastname = reader.GetString("last_name");
                            string update = reader.GetString("last_update");

                            Console.WriteLine($"actor_id: {id}, first_name: {firstname},last_name: {lastname}, last_update: {update}");
                        }
                    }
                }
                connection.Close();
            }
        }
        public void GetData_Sp()
        {
            string mysqlConnectionString = "server=192.168.0.3;user=visualapp;database=sakila;port=3306;password=visualapp@2023";

            using (MySqlConnection mysqlConnection = new MySqlConnection(mysqlConnectionString))

            {
                mysqlConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand("GET_ACTOR", mysqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = Convert.ToInt32(reader["actor_id"]);
                            string FirstName = reader["first_name"].ToString();
                            string LastName = reader["last_name"].ToString();
                            string Lastupdate = reader["last_update"].ToString();

                            Console.WriteLine($"actor_id: {ID}, first_name: {FirstName}, last_name: {LastName}, last_update: {Lastupdate}");
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                mysqlConnection.Close();
            }
        }
        public void Send_Data()
        {
            string mysqlConnectionString = "server=192.168.0.3;user=visualapp;database=sakila;port=3306;password=visualapp@2023";
            string sqlServerConnectionString = "Server=192.168.0.252;Database=Training2023;User Id=sa;Password=local@vaf@123;TrustServerCertificate=True;";

            using (MySqlConnection mysqlConnection = new MySqlConnection(mysqlConnectionString))
            using (SqlConnection sqlServerConnection = new SqlConnection(sqlServerConnectionString))
            {
                mysqlConnection.Open();
                sqlServerConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand("GET_ACTOR", mysqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = Convert.ToInt32(reader["actor_id"]);
                            string FirstName = reader["first_name"].ToString();
                            string LastName = reader["last_name"].ToString();
                            string LastUpdate = reader["last_update"].ToString();

                            string insertQuery = "INSERT INTO Get_MySqlData (ID, FirstName, LastName, LastUpdate) VALUES (@ID, @FirstName, @LastName, @LastUpdate)";
                            using (SqlCommand sqlServerCommand = new SqlCommand(insertQuery, sqlServerConnection))
                            {
                                sqlServerCommand.Parameters.AddWithValue("@ID", ID);
                                sqlServerCommand.Parameters.AddWithValue("@FirstName", FirstName);
                                sqlServerCommand.Parameters.AddWithValue("@LastName", LastName);
                                sqlServerCommand.Parameters.AddWithValue("@LastUpdate", LastUpdate);

                                sqlServerCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                mysqlConnection.Open();
                sqlServerConnection.Open();
            }
        }
        public static void Main()
        {
            Program Get = new Program();
            Get.Getdata();
            Get.GetData_Sp();
            // Get.Send_Data();
        }
    }
}