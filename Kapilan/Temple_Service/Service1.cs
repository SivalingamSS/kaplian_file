using System;
using System.Collections.Generic;
using System.Data;
using System.ServiceProcess;
using System.Timers;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Temple_Service
{
    public partial class Service1 : ServiceBase
    { 

        System.Timers.Timer timer = new System.Timers.Timer();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 120000; // 120 seconds
            timer.AutoReset = true; // Set this to true to repeatedly trigger the timer.
            timer.Enabled = true;
            ExecuteDbData();
            WriteToFile("Service is started at " + DateTime.Now);
        }

        protected override void OnStop()
        {
            timer.Enabled = false; // Disable the timer before stopping the service.
            timer.Dispose(); // Dispose of the timer.
            WriteToFile("Service is stopped at " + DateTime.Now);
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            try
            {
                ExecuteDbData();
                WriteToFile("Service is recalled at " + DateTime.Now);
            }
            catch (Exception ex)
            {
                WriteToFile("Error in executing database operation: " + ex.Message);
            }
        }

        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

        public void ExecuteDbData()
        {
            var lst = new List<Modal>();
            using (SqlConnection sqlServerConnection = new SqlConnection("Data Source=103.168.19.20;Initial Catalog=TempleDB;Persist Security Info=False;uid=sa; Password=Templedb@2023;"))
            using (MySqlConnection mysqlConnection = new MySqlConnection("server=85.187.128.43;user=srmvcas_test;database=srmvcas_temple;port=3306;password=1H+}%uh58cit;"))
            {
                sqlServerConnection.Open();
                mysqlConnection.Open();

                using (MySqlCommand command = new MySqlCommand("getDevoteeDetail", mysqlConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                var item = new Modal();
                                {
                                    item.app_no = Convert.ToInt32(reader["app_no"]);
                                    item.dev_name = reader["dev_name"].ToString();
                                    item.mobile = reader["mobile"].ToString();
                                }
                                lst.Add(item);
                            }
                            reader.Close();
                            if (lst.Count > 0)
                            {
                                foreach (var item in lst)
                                {
                                    using (SqlCommand commands = new SqlCommand("[SSO].[AddUsers]", sqlServerConnection))
                                    {
                                        commands.CommandType = CommandType.StoredProcedure;
                                        commands.Parameters.Clear();
                                        commands.Parameters.AddWithValue("@FirstName", item.dev_name);
                                        commands.Parameters.AddWithValue("@LastName", "Devotees");
                                        commands.Parameters.AddWithValue("@userTypeId", 1009);
                                        commands.Parameters.AddWithValue("@PhoneNumber", item.mobile);
                                        commands.Parameters.AddWithValue("@WhatsappNumber", item.mobile);
                                        commands.ExecuteNonQuery();
                                    }


                                    using (MySqlCommand commands = new MySqlCommand("updateDevotees", mysqlConnection))
                                    {
                                        commands.CommandType = CommandType.StoredProcedure;
                                        commands.Parameters.Clear();
                                        commands.Parameters.AddWithValue("@id", MySqlDbType.Int32).Value = item.app_no;
                                        commands.Parameters.AddWithValue("@isAddValue", MySqlDbType.Bit).Value = 1;
                                        commands.ExecuteNonQuery();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("no records found");
                            }
                        }
                        catch (Exception ex)
                        {
                            WriteToFile("Error in executing database operation: " + ex.Message);
                        }
                    }
                }
                mysqlConnection.Close();
                sqlServerConnection.Close();
            }
        }
    }
}
