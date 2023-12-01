using DatatLibrary.Interface;
using DBClass.DB;
using DBClass.ViewModal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Text;


namespace DatatLibrary.Class
{
    public class DataClass : DataInterface
    {
        private readonly DBContext _dBContext;
        private readonly IConfiguration _configuration;
        public DataClass(DBContext dBContext, IConfiguration configuration)
        {
            _dBContext = dBContext;
            _configuration = configuration;
        }
        public async Task<object> GET_SP()
        {
            SqlConnection sqlcon = null;
            string constring = _configuration.GetConnectionString("MVC6CrudConnectionString");
            var sql = new List<ViewClass>();
            using (sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand("API_DB_GET", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ViewClass data = new ViewClass
                            {
                                staff_id = reader.GetInt32("staff_id"),
                                staff_name = reader.GetString("staff_name"),
                                staff_age = reader.GetInt32("staff_age"),
                                staff_city = reader.GetString("staff_city"),
                                staff_mob_number = reader.GetInt32("staff_mob_number"),
                                work_id = reader.GetInt32("work_id"),
                                email_id = reader.GetString("email_id"),
                                address = reader.GetString("address")
                            };
                            sql.Add(data);
                        }
                    }

                }
            }
            return sql;
        }
        public async Task<object> POST_SP(ViewClass view)
        {
            SqlConnection sqlconn = null;
            string constring = _configuration.GetConnectionString("MVC6CrudConnectionString");
            using (sqlconn = new SqlConnection(constring))
            {
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("API_DB_POST", sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@staff_id", SqlDbType.Int).Value = view.staff_id;
                cmd.Parameters.Add("@staff_name", SqlDbType.VarChar).Value = view.staff_name;
                cmd.Parameters.Add("@staff_age", SqlDbType.Int).Value = view.staff_age;
                cmd.Parameters.Add("@staff_city", SqlDbType.VarChar).Value = view.staff_city;
                cmd.Parameters.Add("@staff_mob_number", SqlDbType.Int).Value = view.staff_mob_number;
                cmd.Parameters.Add("@email_id", SqlDbType.VarChar).Value = view.email_id;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = view.address;
                cmd.ExecuteNonQuery();
                sqlconn.Close();
                _dBContext.SaveChanges();
            }
            return view;
        }
        public async Task<object> PUT_SP(ViewClass view)
        {
            SqlConnection sqlconn = null;
            string constring = _configuration.GetConnectionString("MVC6CrudConnectionString");
            using (sqlconn = new SqlConnection(constring))
            {
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("API_DB_PUT", sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@staff_id", SqlDbType.Int).Value = view.staff_id;
                cmd.Parameters.AddWithValue("@staff_name", SqlDbType.VarChar).Value = view.staff_name;
                cmd.Parameters.AddWithValue("@staff_age", SqlDbType.Int).Value = view.staff_age;
                cmd.Parameters.AddWithValue("@staff_city", SqlDbType.VarChar).Value = view.staff_city;
                cmd.Parameters.AddWithValue("@staff_mob_number", SqlDbType.Int).Value = view.staff_mob_number;
                cmd.Parameters.AddWithValue("@email_id", SqlDbType.VarChar).Value = view.email_id;
                cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = view.address;
                cmd.ExecuteNonQuery();
                sqlconn.Close();
            }
            return view;
        }
        public async Task<object> DELETE_SP(int id)
        {
            SqlConnection sqlconn = null;
            string constring = _configuration.GetConnectionString("MVC6CrudConnectionString");
            using (sqlconn = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("API_DB_DELETE", sqlconn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("staff_id", SqlDbType.Int).Value = id;
                    sqlconn.Open();
                    cmd.ExecuteNonQuery();
                    sqlconn.Close();
                }
            }
            return id;
        }
    }
}
