using Business_Layer.Interface_BL;
using DOT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace curd_repository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBusiness _ibusiness;
        private readonly IConfiguration _con;

        public ValuesController(IBusiness ibusiness)
        {
            _ibusiness = ibusiness;
        }

        [HttpPost("post")]
        public ActionResult post(View name)
        {
            var per = _ibusiness.POST(name);
            return Ok(per);
        }
        [HttpGet("get")]
        public ActionResult get()
        {
            var p = _ibusiness.GET();
            return Ok(p);
        }
        [HttpPut("put")]
        public ActionResult put(View detials)
        {
            var b = _ibusiness.PUT(detials);
            return Ok(b);
        }
        [HttpDelete("delete")]
        public ActionResult delete(int id)
        {
            var d = _ibusiness.DELETE(id);
            return Ok(d);
        }
        [HttpPost("SP_post")]

        public async Task<IActionResult> SP_post([FromBody] int CUSTOMER_ID, string CUSTOMER_NAME, int CUSTOMER_AGE, string CUSTOMER_ADDRESS,string EMAIL_ID, string GENDER)

        {

            SqlConnection sqlCon = null;
            String SqlconString = _con.GetConnectionString("MVC6CrudConnectionString");
            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                SqlCommand sql_cmnd = new SqlCommand("SPM_Procedures", sqlCon);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@CUSTOMER_ID", SqlDbType.Int).Value = CUSTOMER_ID;
                sql_cmnd.Parameters.AddWithValue("@CUSTOMER_NAME", SqlDbType.VarChar).Value = CUSTOMER_NAME;
                sql_cmnd.Parameters.AddWithValue("@CUSTOMER_AGE", SqlDbType.Int).Value = CUSTOMER_AGE;
                sql_cmnd.Parameters.AddWithValue("@CUSTOMER_ADDRESS", SqlDbType.VarChar).Value = CUSTOMER_ADDRESS;
                sql_cmnd.Parameters.AddWithValue("@GENDER", SqlDbType.VarChar).Value = GENDER;
                sql_cmnd.Parameters.AddWithValue("@EMAIL_ID", SqlDbType.VarChar).Value = EMAIL_ID;
                sql_cmnd.ExecuteNonQuery();
                sqlCon.Close();
            }
            return Ok();
        }

        [HttpGet("SP_get")]
        public async Task<IActionResult> SP_Get()
        {
            SqlConnection sqlCon = null;
            String SqlconString = _con.GetConnectionString("MVC6CrudConnectionString");
            var sql = new List<View>();
            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                using (SqlCommand command = new SqlCommand("SPM_GetProcedure", sqlCon))

                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            View ss = new View
                            {
                                CUSTOMER_ID = reader.GetInt32("CUSTOMER_ID"),
                                CUSTOMER_NAME = reader.GetString("CUSTOMER_NAME"),
                                CUSTOMER_AGE = reader.GetInt32("CUSTOMER_AGE"),
                                CUSTOMER_ADDRESS = reader.GetString("CUSTOMER_ADDRESS"),                               
                                GENDER = reader.GetString("GENDER"),
                                EMAIL_ID = reader.GetString("EMAIL_ID")

                            };
                            sql.Add(ss);
                        }
                    }
                }
                return Ok(sql);
            }

        }
        [HttpDelete("Sp_Delect")]
        public async Task<IActionResult> Sp_Delect(int CUSTOMER_ID)
        {
            SqlConnection sqlCon = null;
            String SqlconString = _con.GetConnectionString("MVC6CrudConnectionString");

            using (sqlCon = new SqlConnection(SqlconString))
            {


                using (SqlCommand command = new SqlCommand("SPM_Deleteprocedure", sqlCon))

                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@CUSTOMER_ID", SqlDbType.Int);
                    command.Parameters["@CUSTOMER_ID"].Value = (CUSTOMER_ID);
                    sqlCon.Open();
                    command.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
            return Ok();
        }
        [HttpPut("Sp_Put")]
        public async Task<IActionResult> Sp_Put(View Model)

        {

            SqlConnection sqlCon = null;
            String SqlconString = _con.GetConnectionString("MVC6CrudConnectionString");
            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                SqlCommand sql_cmnd = new SqlCommand("SPM_Puteprocedure", sqlCon);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@CUSTOMER_ID", SqlDbType.Int).Value = Model.CUSTOMER_ID;
                sql_cmnd.Parameters.AddWithValue("@CUSTOMER_NAME", SqlDbType.VarChar).Value = Model.CUSTOMER_NAME;
                sql_cmnd.Parameters.AddWithValue("@CUSTOMER_AGE", SqlDbType.Int).Value = Model.CUSTOMER_AGE;
                sql_cmnd.Parameters.AddWithValue("@CUSTOMER_ADDRESS", SqlDbType.VarChar).Value = Model.CUSTOMER_ADDRESS;
                sql_cmnd.Parameters.AddWithValue("@GENDER", SqlDbType.VarChar).Value = Model.GENDER;
                sql_cmnd.Parameters.AddWithValue("@EMAIL_ID", SqlDbType.VarChar).Value = Model.EMAIL_ID;
                sql_cmnd.ExecuteNonQuery();
                sqlCon.Close();
            }
            return Ok();
        }
    }
}